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
    public class VratiListuSveMestoSO : SystemOperationBase
    {
        public List<Mesto> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.GetAll(new Mesto()).OfType<Mesto>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da vrati listu svih mesta!");
            }
        }
    }
}
