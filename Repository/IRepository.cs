using Domain;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(IEntity obj);
        IEntity Get(IEntity obj);
        void Add(T obj);
        int AddReturnId(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> Search(IEntity criteria);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
