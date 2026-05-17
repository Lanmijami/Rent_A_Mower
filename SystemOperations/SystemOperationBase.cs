using Domain;
using Repository;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IRepository<IEntity> repository = new GenericRepository();
        public void ExecuteTemplate()
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                Execute();
                repository.Commit();
            }
            catch(Exception ex)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void Execute();
    }
}
