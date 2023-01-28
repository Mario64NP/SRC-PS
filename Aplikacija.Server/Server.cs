using Aplikacija.Domen;
using Aplikacija.Zajednicko;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Aplikacija.Server
{
    public class ServerEventArgs : EventArgs
    {
        public EndPoint EP { get; set; }
        public string User { get; set; }
        public ServerEventArgs(EndPoint ep, string user = null) 
        {
            EP = ep;
            User = user;
        }
    }
    internal class Server
    {
        private Socket socket;
        public event EventHandler<ServerEventArgs> ClientConnected;
        public event EventHandler<ServerEventArgs> ClientDisconnected;
        public event EventHandler<ServerEventArgs> ClientLoggedIn;

        public Server()
        {
        }

        public void Start()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9988));
            socket.Listen(5);

            try
            {
                while(true)
                {
                    Socket client = socket.Accept();
                    Thread handleClientThread = new Thread(() => HandleClient(client));
                    handleClientThread.IsBackground = true;
                    handleClientThread.Start();

                    ClientConnected?.Invoke(this, new ServerEventArgs(client.RemoteEndPoint));
                }
            }
            catch(Exception) { }
        }

        public void Stop()
        {
            socket.Close();
        }

        private void HandleClient(Socket clientsocket)
        {
            Communicator communicator = new Communicator(clientsocket);

            try
            {
                while (true)
                {
                    Request request = communicator.Receive<Request>();
                    Response response = ProcessRequest(request, clientsocket);
                    communicator.Send(response);
                }
            }
            catch (Exception)
            {
                ClientDisconnected?.Invoke(this, new ServerEventArgs(clientsocket.RemoteEndPoint));
            }
        }

        private Response ProcessRequest(Request request, Socket clsoc)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controller.Instance.Login((User)request.Argument);
                        if ((bool)response.Result)
                            ClientLoggedIn?.Invoke(this, new ServerEventArgs(clsoc.RemoteEndPoint, ((User)request.Argument).Username));
                        break;

                    case Operation.GetPlayers:
                        response.Result = Controller.Instance.GetPlayers();
                        break;

                    case Operation.SearchPlayers:
                        response.Result = Controller.Instance.SearchPlayers((string)request.Argument);
                        break;

                    case Operation.AddPlayer:
                        response.Result = Controller.Instance.AddPlayer((Igrac)request.Argument);
                        break;

                    case Operation.UpdatePlayer:
                        response.Result = Controller.Instance.UpdatePlayer((Igrac)request.Argument);
                        break;

                    case Operation.DeletePlayer:
                        response.Result = Controller.Instance.DeletePlayer((Igrac)request.Argument);
                        break;

                    case Operation.GetGames:
                        response.Result = Controller.Instance.GetGames();
                        break;

                    case Operation.SearchGames:
                        response.Result = Controller.Instance.SearchGames((string)request.Argument);
                        break;

                    case Operation.AddGame:
                        response.Result = Controller.Instance.AddGame(((VideoIgra, List<Kategorija>))request.Argument);
                        break;

                    case Operation.UpdateGame:
                        response.Result = Controller.Instance.UpdateGame(((VideoIgra, List<Kategorija>))request.Argument);
                        break;

                    case Operation.DeleteGame:
                        response.Result = Controller.Instance.DeleteGame((VideoIgra)request.Argument);
                        break;

                    case Operation.GetResults:
                        response.Result = Controller.Instance.GetResults();
                        break;

                    case Operation.SearchResults:
                        response.Result = Controller.Instance.SearchResults((string)request.Argument);
                        break;

                    case Operation.AddResult:
                        response.Result = Controller.Instance.AddResult((Rezultat)request.Argument);
                        break;

                    case Operation.UpdateResult:
                        response.Result = Controller.Instance.UpdateResult((Rezultat)request.Argument);
                        break;

                    case Operation.DeleteResult:
                        response.Result = Controller.Instance.DeleteResult((Rezultat)request.Argument);
                        break;

                    case Operation.GetPlatforms:
                        response.Result = Controller.Instance.GetPlatforms();
                        break;

                    case Operation.GetCategories:
                        response.Result = Controller.Instance.GetCategories();
                        break;

                    case Operation.GetGameCategories:
                        response.Result = Controller.Instance.GetGameCategories();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception exc)
            {
                response.Result = false;
            }
            return response;
        }
    }
}