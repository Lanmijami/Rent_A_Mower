using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum Operation
    {
        Kraj, KreirajIznajmljivanje, KreirajKosilica, KreirajPoslovniPartner, ObrisiIznajmljivanje, ObrisiKosilica, ObrisiPoslovniPartner,
        PretraziIznajmljivanje, PretraziKosilica, PretraziPoslovniPartner, PrijaviOstava, PromeniIznajmljivanje, PromeniKosilica,
        PromeniPoslovniPartner, SystemOperationBase, UbaciIznajmljivanje, UbaciKosilica, UbaciMesto, UbaciOstava, UbaciOstavaVlasnik,
        UbaciPoslovniPartner, UbaciVlasnik, VratiListuIznajmljivanje, VratiListuKosilica, VratiListuPoslovniPartner, VratiListuSveIznajmljivanje,
        VratiListuSveKosilice, VratiListuSveMesto, VratiListuSveOstava, VratiListuSvePoslovniPartner, VratiListuSveStavkaIznajmljivanja, VratiListuSveVlasnik 
    }
}
