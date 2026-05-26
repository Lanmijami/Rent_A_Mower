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
    public class UbaciVlasnikSO : SystemOperationBase
    {
        private readonly Vlasnik v;
        public UbaciVlasnikSO(Vlasnik v)
        {
            this.v = v;   
        }
        protected override void Execute()
        {
            try
            {
                repository.Add(v);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da ubaci vlasnika!");
            }

        }
    }
}
