using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Domen;

namespace KlijentskiInterfejs
{
    internal class Communication
    {
        private static Communication instance;
        private Socket klijentskiSocket;
        private BinaryFormatter formatter;
        private NetworkStream stream;
        public User CurrentUser { get; set; }
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }
        private Communication()
        {
            klijentskiSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
        }
        public void Connect()
        {
            klijentskiSocket.Connect("127.0.0.1", 9999);
            formatter = new BinaryFormatter();
            stream = new NetworkStream(klijentskiSocket);
        }
        public void Send(Domen.Message request) { 
            formatter.Serialize(stream, request);
        }
        public Domen.Message Recieve()
        {
            return (Domen.Message)formatter.Deserialize(stream);
        }
    }
}
