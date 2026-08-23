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
    public class ObrisiOstavaSO : SystemOperationBase
    {
        private readonly Ostava o;
        public ObrisiOstavaSO(Ostava o)
        {
            this.o = o;
        }

        protected override void Execute()
        {
            try
            {
                repository.Delete(o);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da obriše ostavu!");
            }
        }
    }
}
