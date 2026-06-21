using Common;
using Common.Exceptions;
using Domain;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.ServerCommunication
{
    public class Communication
    {
        private Socket socket;
        private CommunicationHelper helper;
        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        public Communication()
        {
            
        }

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            helper = new CommunicationHelper(socket);
        }

        private async Task<T> GetResult<T>()
        {
            Response response = await helper.Recieve<Response>();

            if (response.isSuccessful)
            {
                return response.GetData<T>();
            }
            else
            {
                throw new SystemOperationException(response.Message);
            }
        }

        private async Task GetResult()
        {
            Response response = await helper.Recieve<Response>();
            if (!response.isSuccessful)
            {
                throw new SystemOperationException(response.Message);
            }
        }

        private async Task SendRequest<T>(Operation operation, T requestObject = null) where T : class
        {
            try
            {
                Request request = new Request
                {
                    Operation = operation,
                    JsonData = JsonSerializer.Serialize(requestObject)
                };

                await helper.Send(request);
            }
            catch (IOException ex)
            {

                throw new ServerCommunicationException(ex.Message);
            }
        }
        public async Task Close()
        {
            if (socket == null || helper == null) return;

            await SendRequest<object>(Operation.Kraj);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }

        internal async Task<Ostava> PrijaviOstava(Ostava o)
        {
            await SendRequest(Operation.PrijaviOstava, o);
            return (Ostava)await GetResult<Ostava>();
        }

        internal async Task UbaciOstavaVlasnik(Ostava o, Vlasnik v = null)
        {
            OstavaVlasnikDTO dto = new OstavaVlasnikDTO
            {
                Ostava = o,
                Vlasnik = v
            };
            await SendRequest(Operation.UbaciOstavaVlasnik, dto);
            await GetResult();
        }

        internal async Task UbaciOstava(Ostava o)
        {
            await SendRequest(Operation.UbaciOstava, o);
            await GetResult();
        }

        internal async Task<List<Vlasnik>> VratiListuSveVlasnik()
        {
            await SendRequest<object>(Operation.VratiListuSveVlasnik);
            return (List<Vlasnik>)await GetResult<List<Vlasnik>>();
        }

        internal async Task UbaciVlasnik(Vlasnik v)
        {
            await SendRequest(Operation.UbaciVlasnik, v);
            await GetResult();
        }

        internal async Task<List<Mesto>> VratiListuSviMesto()
        {
            await SendRequest<object>(Operation.VratiListuSveMesto);
            return (List<Mesto>)await GetResult<List<Mesto>>();
        }

        internal async Task<List<PoslovniPartner>> VratiListuSviPoslovniPartner()
        {
            await SendRequest<object>(Operation.VratiListuSvePoslovniPartner);
            return (List<PoslovniPartner>)await GetResult<List<PoslovniPartner>>();
        }

        internal async Task UbaciPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest(Operation.UbaciPoslovniPartner, p);
            await GetResult();
        }

        internal async Task ObrisiPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest(Operation.ObrisiPoslovniPartner, p);
            await GetResult();
        }

        internal async Task PromeniPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest(Operation.PromeniPoslovniPartner, p);
            await GetResult();
        }

        internal async Task<List<PoslovniPartner>> VratiListuPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest<object>(Operation.VratiListuPoslovniPartner, p);
            return (List<PoslovniPartner>)await GetResult<List<PoslovniPartner>>();
        }

        internal async Task<PoslovniPartner> PretraziPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest<object>(Operation.PretraziPoslovniPartner, p);
            return (PoslovniPartner)await GetResult<PoslovniPartner>();
        }

        internal async Task KreirajPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest(Operation.KreirajPoslovniPartner, p);
            await GetResult();
        }

        internal async Task UbaciMesto(Mesto m)
        {
            await SendRequest(Operation.UbaciMesto, m);
            await GetResult();
        }

        internal async Task<List<Kosilica>> VratiListuSveKosilice()
        {
            await SendRequest<object>(Operation.VratiListuSveKosilice);
            return (List<Kosilica>)await GetResult<List<Kosilica>>();
        }

        internal async Task<Kosilica> PretraziBicikla(Kosilica k)
        {
            await SendRequest<object>(Operation.PretraziKosilica, k);
            return (Kosilica)await GetResult<Kosilica>();
        }

        internal async Task KreirajKosilica(Kosilica k)
        {
            await SendRequest(Operation.KreirajKosilica, k);
            await GetResult();
        }

        internal async Task ObrisiKosilica(Kosilica k)
        {
            await SendRequest(Operation.ObrisiKosilica, k);
            await GetResult();
        }

        internal async Task UbaciKosilica(Kosilica k)
        {
            await SendRequest(Operation.UbaciKosilica, k);
            await GetResult();
        }

        internal async Task PromeniKosilica(Kosilica k)
        {
            await SendRequest(Operation.PromeniKosilica, k);
            await GetResult();
        }

        internal async Task<List<Kosilica>> VratiListuKosilica(Kosilica b)
        {
            await SendRequest<object>(Operation.VratiListuKosilica, b);
            return (List<Kosilica>)await GetResult<List<Kosilica>>();
        }

        internal async Task<List<Ostava>> VratiListuSveOstava()
        {
            await SendRequest<object>(Operation.VratiListuSveOstava);
            return (List<Ostava>)await GetResult<List<Ostava>>();
        }

        internal async Task<List<Iznajmljivanje>> VratiListuSviIznajmljivanje()
        {
            await SendRequest<object>(Operation.VratiListuSveIznajmljivanje);
            return (List<Iznajmljivanje>)await GetResult<List<Iznajmljivanje>>();
        }

        internal async Task ObrisiIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest(Operation.ObrisiIznajmljivanje, i);
            await GetResult();
        }

        internal async Task KreirajIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest(Operation.KreirajIznajmljivanje, i);
            await GetResult();
        }

        internal async Task UbaciIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest(Operation.UbaciIznajmljivanje, i);
            await GetResult();
        }

        internal async Task PromeniIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest(Operation.PromeniIznajmljivanje, i);
            await GetResult();
        }

        internal async Task<List<Iznajmljivanje>> VratiListuIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest<object>(Operation.VratiListuIznajmljivanje, i);
            return (List<Iznajmljivanje>)await GetResult<List<Iznajmljivanje>>();
        }

        internal async Task<Iznajmljivanje> PretraziIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest<object>(Operation.PretraziIznajmljivanje, i);
            return (Iznajmljivanje)await GetResult<Iznajmljivanje>();
        }
    }
}
