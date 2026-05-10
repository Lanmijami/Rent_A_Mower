using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepository : IRepository<IEntity>
    {
        private Broker broker = new Broker();
        public void Add(IEntity obj)
        {
            throw new NotImplementedException();
        }

        public int AddReturnId(IEntity obj)
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(IEntity obj)
        {
            throw new NotImplementedException();
        }

        public IEntity Get(IEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetAll(IEntity obj)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public List<IEntity> Search(IEntity criteria)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
