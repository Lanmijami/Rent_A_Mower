using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepository : IRepository<IEntity>
    {
        private Broker broker = new Broker();

        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker?.Commit();
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public List<IEntity> Search(IEntity criteria)
        {
            List<IEntity> result = new List<IEntity>();
            SqlCommand command = broker.CreateCommand();

            var props = criteria.SearchableProperties;
            List<string> conditions = new List<string>();

            foreach (var pair in props)
            {
                var value = pair.Value;

                if (value == null)
                    continue;

                if (value is string)
                {
                    conditions.Add($"{pair.Key} LIKE @{pair.Key}");
                    command.Parameters.AddWithValue($"@{pair.Key}", $"%{value}%");
                }
                else if (value is DateTime)
                {
                    conditions.Add($"{pair.Key} = @{pair.Key}");
                    command.Parameters.AddWithValue($"@{pair.Key}", value);
                }
                else
                {
                    conditions.Add($"{pair.Key} = @{pair.Key}");
                    command.Parameters.AddWithValue($"@{pair.Key}", value);
                }
            }

            string whereClause = conditions.Count > 0 ? "WHERE " + string.Join(" AND ", conditions) : "";
            command.CommandText = $"SELECT * FROM {criteria.TableName} {whereClause}";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IEntity rowObject = criteria.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }

            return result;
        }

        public void Update(IEntity obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"UPDATE {obj.TableName} SET {obj.UpdateStatement} WHERE {obj.Condition}";

            foreach (var param in obj.Parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void Delete(IEntity obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"DELETE FROM {obj.TableName} WHERE {obj.Condition}";

            foreach (var param in obj.Parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            command.ExecuteNonQuery();
            command.Dispose();
        }

        //public IEntity Get(IEntity obj)
        //{
        //    SqlCommand command = broker.CreateCommand();
        //    try
        //    {
        //        command.CommandText = $"SELECT * FROM {obj.TableName} WHERE {obj.Condition}";
        //    }
        //    catch (Exception ex) { 
        //        Debug.WriteLine(ex.Message);
        //    }


        //    foreach (var param in obj.Parameters)
        //    {
        //        command.Parameters.AddWithValue(param.Key, param.Value);
        //    }

        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        if (reader.Read())
        //        {
        //            return obj.ReadObjectRow(reader);
        //        }
        //    }
        //    return null;
        //}

        public IEntity Get(IEntity obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (broker == null)
                throw new InvalidOperationException("Broker is not initialized.");

            SqlCommand command = broker.CreateCommand();

            if (string.IsNullOrWhiteSpace(obj.TableName) || string.IsNullOrWhiteSpace(obj.Condition))
                throw new InvalidOperationException("Invalid SQL metadata (TableName or Condition is empty).");

            command.CommandText = $"SELECT * FROM {obj.TableName} WHERE {obj.Condition}";

            // safe parameters handling
            if (obj.Parameters != null)
            {
                foreach (var param in obj.Parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }
            }

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return obj.ReadObjectRow(reader);
                }
            }

            return null;
        }

        public List<IEntity> GetAll(IEntity obj)
        {
            List<IEntity> result = new List<IEntity>();
            //var result = new List<IEntity>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT * FROM {obj.TableName}";

            using (SqlDataReader reader = command.ExecuteReader()) 
            {
                while (reader.Read())
                {
                    IEntity rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            command.Dispose();
            return result;
        }

        public void Add(IEntity obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"INSERT INTO {obj.TableName} ({obj.InsertColumns}) VALUES ({obj.InsertParameters})";

            foreach (var param in obj.Parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public int AddReturnId(IEntity obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"INSERT INTO {obj.TableName} ({obj.InsertColumns}) VALUES ({obj.InsertParameters}); SELECT SCOPE_IDENTITY();";

            foreach (var param in obj.Parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            int result = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            return result;
        }
    }
}
