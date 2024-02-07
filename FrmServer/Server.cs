using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace FrmServer
{
    internal class Server
    {
        private Socket osluskujuciSocket;
        private List<ClientHandler> klijenti = new List<ClientHandler>();
        public List<ClientHandler> Klijenti { get { return klijenti; } set { klijenti = value; } }
        public Server()
        {
            osluskujuciSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start()
        {
            osluskujuciSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            osluskujuciSocket.Listen(1000);
        }
        public void HandleClients()
        {
            while (true)
            {
                try
                {
                    Socket klijentskiSocket = osluskujuciSocket.Accept();
                    ClientHandler klijent = new ClientHandler(klijentskiSocket);
                    klijenti.Add(klijent);
                    klijent.Klijenti = klijenti;
                    Thread nitKlijenta = new Thread(klijent.HandleRequests);
                    nitKlijenta.Start();
                }
                catch (SocketException se)
                {
                    Debug.WriteLine(se.ToString());
                }
                catch(ObjectDisposedException ode)
                {
                    Debug.WriteLine(ode.ToString());
                }
            }
        }
        public void Stop() {
            foreach (ClientHandler klijent in klijenti)
            {
                if (klijenti.Count == 0) return;
                klijent.Disconnect();
            }
            try
            {
                osluskujuciSocket.Shutdown(SocketShutdown.Both);
            }
            catch(SocketException se)
            {
                Debug.WriteLine(se.ToString());
            }
            finally
            {
                osluskujuciSocket.Close();
            }
        }
    }
}
