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
    public class KreirajPoslovniPartnerSO : SystemOperationBase
    {
        private readonly PoslovniPartner pp;
        public KreirajPoslovniPartnerSO(PoslovniPartner pp)
        {
            this.pp = pp;
        }
        protected override void Execute()
        {
            try
            {
                repository.Add(pp);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()} || error: {ex.Message}");
                throw new SystemOperationException(">>> Sistem nije kreirao poslovnog partnera");
            }

        }
    }
}
