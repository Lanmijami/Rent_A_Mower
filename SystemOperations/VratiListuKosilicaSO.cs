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
    public class VratiListuKosilicaSO : SystemOperationBase
    {
        private readonly Kosilica k;
        public VratiListuKosilicaSO(Kosilica k)
        {
            this.k = k;
        }

        public List<Kosilica> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.Search(k).OfType<Kosilica>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da vrati listu kosilica po zadatom kriterijumu!");
            }
        }
    }
}
