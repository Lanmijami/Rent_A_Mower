using Domain;
using SystemOperations;

namespace ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Controller();
                }

                return instance;
            }
        }

        private Controller() { }

        public Ostava PrijaviOstava(Ostava o)
        {
            SystemOperationBase so = new PrijaviOstavaSO(o);
            so.ExecuteTemplate();
            return ((PrijaviOstavaSO)so).Result;
        }

        public List<Ostava> VratiListuSveOstava()
        {
            SystemOperationBase so = new VratiListuSveOstavaSO();
            so.ExecuteTemplate();
            return ((VratiListuSveOstavaSO)so).Result;
        }

        public void UbaciOstava(Ostava o)
        {
            SystemOperationBase so = new UbaciOstavaSO(o);
            so.ExecuteTemplate();
        }

        public void UbaciOstavaVlasnik(Ostava o, Vlasnik v)
        {
            SystemOperationBase so = new UbaciOstavaVlasnikSO(o, v);
            so.ExecuteTemplate();
        }

        public List<Vlasnik> VratiListuSveVlasnik()
        {
            SystemOperationBase so = new VratiListuSveVlasnikSO();
            so.ExecuteTemplate();
            return ((VratiListuSveVlasnikSO)so).Result;
        }

        public void UbaciVlasnik(Vlasnik v)
        {
            SystemOperationBase so = new UbaciVlasnikSO(v);
            so.ExecuteTemplate();
        }

        public List<Mesto> VratiListuSviMesto()
        {
            SystemOperationBase so = new VratiListuSveMestoSO();
            so.ExecuteTemplate();
            return ((VratiListuSveMestoSO)so).Result;
        }

        public List<PoslovniPartner> VratiListuSviPoslovniPartner()
        {
            SystemOperationBase so = new VratiListuSviPoslovniPartnerSO();
            so.ExecuteTemplate();
            return ((VratiListuSviPoslovniPartnerSO)so).Result;
        }

        public void UbaciPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new UbaciPoslovniPartnerSO(p);
            so.ExecuteTemplate();
        }

        public void ObrisiPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new ObrisiPoslovniPartnerSO(p);
            so.ExecuteTemplate();
        }

        public void PromeniPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new PromeniPoslovniPartnerSO(p);
            so.ExecuteTemplate();
        }

        public List<PoslovniPartner> VratiListuPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new VratiListuPoslovniPartnerSO(p);
            so.ExecuteTemplate();
            return ((VratiListuPoslovniPartnerSO)so).Result;
        }

        public PoslovniPartner PretraziPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new PretraziPoslovniPartnerSO(p);
            so.ExecuteTemplate();
            return ((PretraziPoslovniPartnerSO)so).Result;

        }

        public void KreirajPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new KreirajPoslovniPartnerSO(p);
            so.ExecuteTemplate();
        }

        public void UbaciMesto(Mesto m)
        {
            SystemOperationBase so = new UbaciMestoSO(m);
            so.ExecuteTemplate();
        }

        public List<Kosilica> VratiListuSveKosilica()
        {
            SystemOperationBase so = new VratiListuSveKosilicaSO();
            so.ExecuteTemplate();
            return ((VratiListuSveKosilicaSO)so).Result;
        }

        public Kosilica PretraziBicikla(Kosilica k)
        {
            SystemOperationBase so = new PretraziKosilicaSO(k);
            so.ExecuteTemplate();
            return ((PretraziKosilicaSO)so).Result;
        }

        public void KreirajKosilica(Kosilica k)
        {
            SystemOperationBase so = new KreirajKosilicaSO(k);
            so.ExecuteTemplate();
        }

        public void ObrisiKosilica(Kosilica k)
        {
            SystemOperationBase so = new ObrisiKosilicaSO(k);
            so.ExecuteTemplate();
        }

        public void UbaciKosilica(Kosilica k)
        {
            SystemOperationBase so = new UbaciKosilicaSO(k);
            so.ExecuteTemplate();
        }

        public void PromeniKosilica(Kosilica k)
        {
            SystemOperationBase so = new PromeniKosilicaSO(k);
            so.ExecuteTemplate();
        }

        public List<Kosilica> VratiListuKosilica(Kosilica k)
        {
            SystemOperationBase so = new VratiListuKosilicaSO(k);
            so.ExecuteTemplate();
            return ((VratiListuKosilicaSO)so).Result;
        }

        public List<Iznajmljivanje> VratiListuSviIznajmljivanje()
        {
            SystemOperationBase so = new VratiListuSveIznajmljivanjeSO();
            so.ExecuteTemplate();
            return ((VratiListuSveIznajmljivanjeSO)so).Result;
        }

        public List<StavkaIznajmljivanja> VratiListuSviStavkaIznajmljivanja()
        {
            SystemOperationBase so = new VratiListuSviStavkaIznajmljivanjaSO();
            so.ExecuteTemplate();
            return ((VratiListuSviStavkaIznajmljivanjaSO)so).Result;
        }

        public void ObrisiIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new ObrisiIznajmljivanjeSO(i);
            so.ExecuteTemplate();
        }

        public void KreirajIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new KreirajIznajmljivanjeSO(i);
            so.ExecuteTemplate();
        }

        public void UbaciIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new UbaciIznajmljivanjeSO(i);
            so.ExecuteTemplate();
        }

        public void PromeniIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new PromeniIznajmljivanjeSO(i);
            so.ExecuteTemplate();
        }

        public List<Iznajmljivanje> VratiListuIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new VratiListuIznajmljivanjeSO(i);
            so.ExecuteTemplate();
            return ((VratiListuIznajmljivanjeSO)so).Result;
        }

        public Iznajmljivanje PretraziIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new PretraziIznajmljivanjeSO(i);
            so.ExecuteTemplate();
            return ((PretraziIznajmljivanjeSO)so).Result;
        }

    }
}
