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
    public class PretraziPoslovniPartnerSO : SystemOperationBase
    {
        private readonly PoslovniPartner p;

        public PretraziPoslovniPartnerSO(PoslovniPartner p)
        {
            this.p = p;
        }
        public PoslovniPartner Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = (PoslovniPartner)repository.Get(p);

                if (Result != null)
                {
                    List<Mesto> mesta = repository.GetAll(new Mesto()).OfType<Mesto>().ToList();
                    foreach (Mesto m in mesta)
                    {
                        if (Result.idMesto == m.IdMesto)
                        {
                            Result.Mesto = m;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da nađe poslovnog partnera!");
            }
        }
    }
}
