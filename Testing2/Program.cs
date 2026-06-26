using ApplicationLogic;
using DatabaseBroker;
using Domain;
using Repository;
using System.Net.Security;
using System.Runtime.CompilerServices;

namespace Testing2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            IRepository<IEntity> repository = new GenericRepository();
            List<Ostava> ostave = repository.GetAll(new Ostava()).OfType<Ostava>().ToList();
            
        }
    }
}
