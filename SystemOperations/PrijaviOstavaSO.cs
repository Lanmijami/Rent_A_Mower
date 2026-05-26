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
    public class PrijaviOstavaSO : SystemOperationBase
    {
        private readonly Ostava o;
        public PrijaviOstavaSO(Ostava o)
        {
            this.o = o;
        }

        public Ostava Result { get; private set; }

        protected override void Execute()
        {
            try
            {
                List<Ostava> ostave = repository.GetAll(new Ostava()).OfType<Ostava>().ToList();
                Validate(ostave);

                Result = null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da prijavi ostavu!");
            }
        }

        private void Validate(List<Ostava> ostave)
        {
            foreach(Ostava ostava in ostave)
            {
                if (ostava.KorisnickoIme == o.KorisnickoIme && ostava.Sifra == o.Sifra)
                {
                    Result = ostava;
                    return;
                }
            }
        }
    }
}
