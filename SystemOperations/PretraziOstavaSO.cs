using Common.Exceptions;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class PretraziOstavaSO : SystemOperationBase
    {
        private readonly Ostava o;

        public PretraziOstavaSO(Ostava o)
        {
            this.o = o;
        }
        public Ostava Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = (Ostava)repository.Get(o);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da nađe ostavu!");
            }
        }
    }
}
