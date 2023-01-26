using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Aplikacija.Domen;
using Aplikacija.Zajednicko;

namespace Aplikacija.Forme
{
    internal class GUIController
    {
        private static GUIController _instance;
        public static GUIController Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new GUIController();

                return _instance;
            }
        }

        private Communicator communicator;
        private readonly frmLogin frmLogin;
        private readonly frmMain frmMain;
        private GUIController()
        {
            Connect();

            frmLogin = new frmLogin();
            frmMain = new frmMain();
        }

        private void Connect()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect("127.0.0.1", 9988);
            communicator = new Communicator(s);
        }

        internal void Start()
        {
            if (frmLogin.ShowDialog() != DialogResult.OK)
                return;

            frmMain.ShowDialog();
        }

        public bool TryLogin(User u)
        {
            Request r = new Request { Operation = Operation.Login, Argument = u };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public List<Igrac> GetPlayers()
        {
            Request r = new Request { Operation = Operation.GetPlayers };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Igrac>)res.Result;
        }

        public List<Igrac> SearchPlayers(Igrac i)
        {
            Request r = new Request { Operation = Operation.SearchPlayers, Argument = i };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Igrac>)res.Result;
        }

        public bool AddPlayer(Igrac i)
        {
            Request r = new Request { Operation = Operation.AddPlayer, Argument = i };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool UpdatePlayer(Igrac i)
        {
            Request r = new Request { Operation = Operation.UpdatePlayer, Argument = i };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool DeletePlayer(Igrac i)
        {
            Request r = new Request { Operation = Operation.DeletePlayer, Argument = i };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public List<VideoIgra> GetGames()
        {
            Request r = new Request { Operation = Operation.GetGames };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<VideoIgra>)res.Result;
        }

        public List<VideoIgra> SearchGames(VideoIgra v)
        {
            Request r = new Request { Operation = Operation.SearchGames, Argument = v };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<VideoIgra>)res.Result;
        }

        public bool AddGame(VideoIgra v)
        {
            Request r = new Request { Operation = Operation.AddGame, Argument = v };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool UpdateGame(VideoIgra v)
        {
            Request r = new Request { Operation = Operation.UpdateGame, Argument = v };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool DeleteGame(VideoIgra v)
        {
            Request r = new Request { Operation = Operation.DeleteGame, Argument = v };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public List<Rezultat> GetResults()
        {
            Request r = new Request { Operation = Operation.GetResults };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Rezultat>)res.Result;
        }

        public List<Rezultat> SearchResults(Rezultat r)
        {
            Request request = new Request { Operation = Operation.SearchResults, Argument = r };
            communicator.Send(request);
            Response res = communicator.Receive<Response>();

            return (List<Rezultat>)res.Result;
        }

        public bool AddResult(Rezultat r)
        {
            Request request = new Request { Operation = Operation.AddResult, Argument = r };
            communicator.Send(request);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool UpdateResult(Rezultat v)
        {
            Request request = new Request { Operation = Operation.UpdateResult, Argument = v };
            communicator.Send(request);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool DeleteResult(Rezultat r)
        {
            Request request = new Request { Operation = Operation.DeleteResult, Argument = r };
            communicator.Send(request);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public List<Platforma> GetPlatforms()
        {
            Request r = new Request { Operation = Operation.GetPlatforms };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Platforma>)res.Result;
        }

        public List<Kategorija> GetCategories()
        {
            Request r = new Request { Operation = Operation.GetCategories };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Kategorija>)res.Result;
        }
    }
}