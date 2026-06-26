using ApplicationLogic;
using Common;
using Common.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
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
                    case Operation.PrijaviOstava:
                        Ostava ostava = JsonSerializer.Deserialize<Ostava>(request.JsonData);
                        Ostava resultPrijaviOstavu = Controller.Instance.PrijaviOstava(ostava);
                        response.JsonData = JsonSerializer.Serialize(resultPrijaviOstavu);
                        if (resultPrijaviOstavu == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Ostava ne postoji!";
                        }
                        break;

                    case Operation.UbaciOstava:
                        ostava = JsonSerializer.Deserialize<Ostava>(request.JsonData);
                        Controller.Instance.UbaciOstava(ostava);
                        break;

                    case Operation.UbaciOstavaVlasnik:
                        OstavaVlasnik dto = JsonSerializer.Deserialize<OstavaVlasnik>(request.JsonData);
                        Controller.Instance.UbaciOstavaVlasnik(dto.Ostava, dto.Vlasnik);
                        break;

                    case Operation.VratiListuSveVlasnik:
                        List<Vlasnik> resultVratiListuSvihVlasnika = Controller.Instance.VratiListuSveVlasnik();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSvihVlasnika);
                        break;

                    case Operation.UbaciVlasnik:
                        Vlasnik lokacija = JsonSerializer.Deserialize<Vlasnik>(request.JsonData);
                        Controller.Instance.UbaciVlasnik(lokacija);
                        break;

                    case Operation.VratiListuSveMesto:
                        List<Mesto> resultVratiListuSviMesto = Controller.Instance.VratiListuSviMesto();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviMesto);
                        break;

                    case Operation.VratiListuSvePoslovniPartner:
                        List<PoslovniPartner> resultVratiListuSviPoslovniPartner = Controller.Instance.VratiListuSviPoslovniPartner();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviPoslovniPartner);
                        break;

                    case Operation.UbaciPoslovniPartner:
                        PoslovniPartner partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        Controller.Instance.UbaciPoslovniPartner(partner);
                        break;

                    case Operation.ObrisiPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        Controller.Instance.ObrisiPoslovniPartner(partner);
                        break;

                    case Operation.PromeniPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        Controller.Instance.PromeniPoslovniPartner(partner);
                        break;

                    case Operation.VratiListuPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        List<PoslovniPartner> resultVratiListuPoslovniPartner = Controller.Instance.VratiListuPoslovniPartner(partner);
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuPoslovniPartner);
                        break;

                    case Operation.PretraziPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        PoslovniPartner resultPretraziPoslovniPartner = Controller.Instance.PretraziPoslovniPartner(partner);
                        response.JsonData = JsonSerializer.Serialize(resultPretraziPoslovniPartner);
                        break;

                    case Operation.KreirajPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        Controller.Instance.KreirajPoslovniPartner(partner);
                        break;

                    case Operation.UbaciMesto:
                        Mesto mesto = JsonSerializer.Deserialize<Mesto>(request.JsonData);
                        Controller.Instance.UbaciMesto(mesto);
                        break;

                    case Operation.VratiListuSveKosilice:
                        List<Kosilica> resultVratiListuSveKosilice = Controller.Instance.VratiListuSveKosilica();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSveKosilice);
                        break;

                    case Operation.PretraziKosilica:
                        Kosilica kosilica = JsonSerializer.Deserialize<Kosilica>(request.JsonData);
                        Kosilica resultPretraziBicikla = Controller.Instance.PretraziBicikla(kosilica);
                        response.JsonData = JsonSerializer.Serialize(resultPretraziBicikla);
                        break;

                    case Operation.KreirajKosilica:
                        kosilica = JsonSerializer.Deserialize<Kosilica>(request.JsonData);
                        Controller.Instance.KreirajKosilica(kosilica);
                        break;

                    case Operation.ObrisiKosilica:
                        kosilica = JsonSerializer.Deserialize<Kosilica>(request.JsonData);
                        Controller.Instance.ObrisiKosilica(kosilica);
                        break;

                    case Operation.UbaciKosilica:
                        kosilica = JsonSerializer.Deserialize<Kosilica>(request.JsonData);
                        Controller.Instance.UbaciKosilica(kosilica);
                        break;

                    case Operation.PromeniKosilica:
                        kosilica = JsonSerializer.Deserialize<Kosilica>(request.JsonData);
                        Controller.Instance.PromeniKosilica(kosilica);
                        break;

                    case Operation.VratiListuKosilica:
                        kosilica = JsonSerializer.Deserialize<Kosilica>(request.JsonData);
                        List<Kosilica> resultVratiListuBicikla = Controller.Instance.VratiListuKosilica(kosilica);
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuBicikla);
                        break;

                    case Operation.VratiListuSveOstava:
                        List<Ostava> resultVratiListuSviAutomat = Controller.Instance.VratiListuSveOstava();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviAutomat);
                        break;

                    case Operation.VratiListuSveIznajmljivanje:
                        List<Iznajmljivanje> resultVratiListuSviIznajmljivanje = Controller.Instance.VratiListuSviIznajmljivanje();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviIznajmljivanje);
                        break;

                    case Operation.ObrisiIznajmljivanje:
                        Iznajmljivanje iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        Controller.Instance.ObrisiIznajmljivanje(iznajmljivanje);
                        break;

                    case Operation.KreirajIznajmljivanje:
                        iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        Controller.Instance.KreirajIznajmljivanje(iznajmljivanje);
                        break;

                    case Operation.UbaciIznajmljivanje:
                        iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        Controller.Instance.UbaciIznajmljivanje(iznajmljivanje);
                        break;

                    case Operation.PromeniIznajmljivanje:
                        iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        Controller.Instance.PromeniIznajmljivanje(iznajmljivanje);
                        break;

                    case Operation.VratiListuIznajmljivanje:
                        iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        List<Iznajmljivanje> resultVratiListuIznajmljivanje = Controller.Instance.VratiListuIznajmljivanje(iznajmljivanje);
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuIznajmljivanje);
                        break;

                    case Operation.PretraziIznajmljivanje:
                        iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        Iznajmljivanje resultPretraziIznajmljivanje = Controller.Instance.PretraziIznajmljivanje(iznajmljivanje);
                        response.JsonData = JsonSerializer.Serialize(resultPretraziIznajmljivanje);
                        break;

                    case Operation.Kraj:
                        end = true;
                        break;

                    default:
                        break;
                }
            }
            catch (SystemOperationException ex)
            {
                Debug.WriteLine($">>>>>>>>>>> System Operation: {request.Operation} error: {ex.Message}");
                response.isSuccessful = false;
                response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>> Unexpected System Error: " + ex.Message);
                response.isSuccessful = false;
                response.Message = "Sistemska greška!";
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
