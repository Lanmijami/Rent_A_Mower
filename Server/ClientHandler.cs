using Common;
using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private CommunicationHelper helper;
        public EventHandler loggedOutClient;
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }

        private bool end = false;
        public async Task HandleRequests()
        {
            try
            {
                while (!end)
                {
                    Request request = await helper.Recieve<Request>();
                    Response response = CreateResponse(request);
                    await helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>> " + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }

        public Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.End:
                        end = true;
                        break;
                    default:
                        break;
                }
            }
            catch (SystemOperationException ex)
            {
                Debug.WriteLine($">>>> System Operation: {request.Operation} || error: {ex.Message}");
                response.isSuccessful = false;
                response.Message = ex.Message;
            }
            catch (Exception ex) {
                Debug.WriteLine(">>>> Generic system error: " + ex.Message);
                response.isSuccessful = false;
                response.Message = ex.Message;
            }
            return response;
        }

        private object lockObject = new object();

        internal void CloseSocket()
        {
            lock (lockObject) {
                if (socket != null) {
                    end = true;
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;

                    loggedOutClient?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
