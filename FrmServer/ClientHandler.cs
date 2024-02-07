using Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace FrmServer
{
    public class ClientHandler
    {
        private Socket klijentskiSocket;
        private BinaryFormatter formatter;
        private NetworkStream stream;
        private List<ClientHandler> klijenti;
        public List<ClientHandler> Klijenti { get { return klijenti; } set { klijenti = value; } }
        public string Username { get; set; }

        public ClientHandler(Socket klijentskiSocket)
        {
            this.klijentskiSocket = klijentskiSocket;
            formatter= new BinaryFormatter();
            stream = new NetworkStream(klijentskiSocket);
        }

        

        internal void Disconnect()
        {
            throw new NotImplementedException();
        }

        internal void HandleRequests()
        {
            Message request;
            while (true)
            {
                try
                {
                    request = (Message)formatter.Deserialize(stream);
                    CreateResponse(request);
                }
                catch (IOException ex)
                {
                    Debug.WriteLine("At HandleRequest: "+ex.ToString());
                }
            }
        }

        private void CreateResponse(Message request)
        {
            Message response = new Message();
            switch (request.Operacija)
            {
                case Operacija.Login:
                    response.ResponseObject = Controller.Instance.LoginUser((User)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        User user= (User)response.ResponseObject;
                        Username = user.Username;
                    }
                    formatter.Serialize(stream, response);
                    break;
                    case Operacija.GetOnlineUsers:
                    List<string> users = new List<string>();
                    foreach (ClientHandler klijent in klijenti)
                    {
                        if(klijent.Username != Username)
                        {
                            users.Add(klijent.Username);
                        }
                    }
                    response.ResponseObject = users;
                    formatter.Serialize(stream, response);
                    break;
                case Operacija.SendToAll:
                    foreach (ClientHandler klijent in Klijenti)
                    {
                        response.Operacija = Operacija.PristiglaPoruka;
                        response.MessageText = request.MessageText;
                        response.FromWho = request.FromWho;
                        formatter.Serialize(klijent.stream, response);
                    }
                    break;
                case Operacija.DiskonektujKorisnika:
                    foreach (ClientHandler klijent in Klijenti)
                    {
                        if(klijent.Username == request.FromWho)
                        {
                            Klijenti.Remove(klijent);
                            klijentskiSocket.Shutdown(SocketShutdown.Both);
                            klijentskiSocket.Close();
                            return;
                        }
                    }
     
                    break;
                default:
                    break;
            }
        }
    }
}