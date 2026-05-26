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
    public class UbaciOstavaSO : SystemOperationBase
    {
        private readonly Ostava o;
        public UbaciOstavaSO(Ostava o)
        {
            this.o = o;
        }
        protected override void Execute()
        {
            try
            {
                repository.Add(o);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da ubaci ostavu!");
            }
        }
    }
}
