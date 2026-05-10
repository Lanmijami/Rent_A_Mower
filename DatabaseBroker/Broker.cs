using System.Data.SqlClient;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=Rent_A_Mower; Integrated Security=True");
        }

        public void OpenConnection()
        {
            connection?.Open();
        }

        public void CloseConnection()
        { 
            connection?.Close();
        }

        public void BeginTransaction()
        { 
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection, transaction);
        }
    }
}
