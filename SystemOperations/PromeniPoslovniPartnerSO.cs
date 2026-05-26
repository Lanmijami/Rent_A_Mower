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
    public class PromeniPoslovniPartnerSO : SystemOperationBase
    {
        private readonly PoslovniPartner pp;
        public PromeniPoslovniPartnerSO(PoslovniPartner pp)
        {
            this.pp = pp;
        }
        protected override void Execute()
        {
            try
            {
                repository.Update(pp);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da promeni poslovnog partnera!");
            }
        }
    }
}
