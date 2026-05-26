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
    public class UbaciMestoSO : SystemOperationBase
    {
        private readonly Mesto m;
        public UbaciMestoSO(Mesto m)
        {
            this.m = m;
        }
        protected override void Execute()
        {
            try
            {
                repository.Add(m);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da ubaci mesto!");
            }
        }
    }
}
