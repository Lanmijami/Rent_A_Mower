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
    public class ObrisiIznajmljivanjeSO : SystemOperationBase
    {
        private readonly Iznajmljivanje i;
        public ObrisiIznajmljivanjeSO(Iznajmljivanje i)
        {
            this.i = i;
        }

        protected override void Execute()
        {
            try
            {
                repository.Delete(i);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da obriše iznajmljivanje!");
            }
        }
    }
}
