using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket socket;
        private List<ClientHandler> clients = new List<ClientHandler>();

        public bool isRunning {  get; private set; }
        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Start()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                socket.Bind(endPoint);
                socket.Listen(5);
                isRunning = true;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>> " + ex.Message);
                return false;
            }
        }

        public async Task Listen()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = await socket.AcceptAsync();
                    ClientHandler client = new ClientHandler(clientSocket);
                    clients.Add(client);
                    client.loggedOutClient += Handler_LoggedOutClient;
                    Task.Run(() => client.HandleRequests());
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine($">>>> {ex.Message}");
            }
        }

        public void Handler_LoggedOutClient(object sender, EventArgs args)
        {
            clients.Remove((ClientHandler)sender);
        }

        public void Stop()
        {
            socket.Close();
            foreach (ClientHandler handler in clients.ToList())
            {
                handler.CloseSocket();
            }
            isRunning = false;
        }
    }
}
