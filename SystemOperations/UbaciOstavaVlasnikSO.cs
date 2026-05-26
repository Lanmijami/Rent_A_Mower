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
    public class UbaciOstavaVlasnikSO : SystemOperationBase
    {
        private readonly Ostava o;
        private readonly Vlasnik v;
        public UbaciOstavaVlasnikSO(Ostava o, Vlasnik v)
        {
            this.o = o;
            this.v = v;
        }
        protected override void Execute()
        {
            try
            {
                o.IdOstava = repository.AddReturnId(o);

                if (v != null)
                {
                    OstavaVlasnik ostavaVlasnik = new OstavaVlasnik
                    {
                        Ostava = o,
                        Vlasnik = v,
                        DatumOtvaranja = DateTime.Now
                    };
                    repository.Add(ostavaVlasnik);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException(">>> Sistem ne može da ubaci ostavuVlasnika!");
            }
        }
    }
}
