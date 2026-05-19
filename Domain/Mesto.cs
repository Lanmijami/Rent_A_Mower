using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Mesto : IEntity
    {
        public int IdMesto { get; set; }
        public string Naziv { get; set; }
        public string Opstina { get; set; }
        public string Drzava { get; set; }

        public string TableName => "Mesto";

        public string InsertColumns => "naziv, opstina, drzava";

        public string InsertParameters => "@Naziv, @Opstina, @Drzava";

        public string UpdateStatement => "naziv = @Naziv, opstina = @Opstina, drzava = @Drzava";

        public string Condition => $"idMesto = @IdMesto";

        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdMesto", IdMesto },
            { "@Naziv", Naziv },
            { "@Opstina", Opstina },
            { "@Drzava", Drzava },
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "Naziv", Naziv },
            { "Opstina", Opstina },
            { "Drzava", Drzava },
        };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Mesto m = new Mesto();
            m.IdMesto = reader.GetInt32(reader.GetOrdinal("idMesto"));
            m.Naziv = reader.GetString(reader.GetOrdinal("naziv"));
            m.Opstina = reader.GetString(reader.GetOrdinal("opstina"));
            m.Drzava = reader.GetString(reader.GetOrdinal("drzava"));
            return m;
        }

        public override string ToString()
        {
            return this.Naziv;
        }
    }
}
