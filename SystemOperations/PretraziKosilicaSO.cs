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
    public class PretraziKosilicaSO : SystemOperationBase
    {
        private readonly Kosilica k;

        public PretraziKosilicaSO(Kosilica k)
        {
            this.k = k;
        }
        public Kosilica Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = (Kosilica)repository.Get(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da nađe kosilicu!");
            }
        }
    }
}
