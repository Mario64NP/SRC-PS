using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Aplikacija.Zajednicko
{
    public class Communicator
    {
        private readonly Socket socket;
        private readonly NetworkStream stream;
        private readonly BinaryFormatter formatter;

        public Communicator(Socket s)
        {
            socket = s;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public void Send(object argument) 
        {
            formatter.Serialize(stream, argument);
        }

        public T Receive<T>() where T : class
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}