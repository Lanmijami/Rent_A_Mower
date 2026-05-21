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
    public class KreirajKosilicaSO : SystemOperationBase
    {
        private readonly Kosilica k;
        public KreirajKosilicaSO(Kosilica k)
        {
            this.k = k;
        }
        protected override void Execute()
        {
            try
            {
                repository.Add(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()} || error: {ex.Message}");
                throw new SystemOperationException(">>> Sistem nije kreirao kosilicu");
            }
            
        }
    }
}
