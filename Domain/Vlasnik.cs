using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Vlasnik : IEntity
    {
        public int IdVlasnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

        public string TableName => "Vlasnik";

        public string InsertColumns => "ime, prezime, email";

        public string InsertParameters => "@Ime, @Prezime, @Email";

        public string UpdateStatement => "ime = @Ime, prezime = @Prezime, email = @Email";

        public string Condition => $"idVlasnik = @IdVlasnik";

        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            {"@IdVlasnik", IdVlasnik },
            {"@Ime", Ime },
            {"@Prezime", Prezime },
            {"@Email", Email },

        };

        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            {"Ime", Ime },
            {"Prezime", Prezime },
            {"Email", Email }
        };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Vlasnik v = new Vlasnik();
            v.IdVlasnik = reader.GetInt32(reader.GetOrdinal("idVlasnik"));
            v.Ime = reader.GetString(reader.GetOrdinal("ime"));
            v.Prezime = reader.GetString(reader.GetOrdinal("prezime"));
            v.Email = reader.GetString(reader.GetOrdinal("email"));
            return v;
        }
        public override string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
