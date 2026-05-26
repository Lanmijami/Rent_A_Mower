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
    public class PromeniKosilicaSO : SystemOperationBase
    {
        private readonly Kosilica k;
        public PromeniKosilicaSO(Kosilica k)
        {
            this.k = k;
        }
        protected override void Execute()
        {
            try
            {
                repository.Update(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()} error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne moze da promeni kosilicu!");
            }
        }
    }
}
