using Common.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiListuSviStavkaIznajmljivanjaSO : SystemOperationBase
    {
        public List<StavkaIznajmljivanja> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.GetAll(new StavkaIznajmljivanja()).OfType<StavkaIznajmljivanja>().ToList();

                List<Kosilica> kosilice = repository.GetAll(new Kosilica()).OfType<Kosilica>().ToList();
                foreach (var stavka in Result)
                {
                    stavka.Kosilica = kosilice.FirstOrDefault(b => b.IdKosilica == stavka.idKosilica);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da vrati listu svih stavki!");
            }
        }
    }
}
