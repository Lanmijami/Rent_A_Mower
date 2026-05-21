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
    public class ObrisiPoslovniPartnerSO : SystemOperationBase
    {
        private readonly PoslovniPartner pp;
        public ObrisiPoslovniPartnerSO(PoslovniPartner pp)
        {
            this.pp = pp;
        }

        protected override void Execute()
        {
            try
            {
                repository.Delete(pp);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da obriše poslovnog partnera!");
            }
        }
    }
}
