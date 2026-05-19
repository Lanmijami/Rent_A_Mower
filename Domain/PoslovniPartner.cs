using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PoslovniPartner : IEntity
    {
        public int IdPoslovniPartner { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public Mesto Mesto { get; set; }

        public int idMesto;
        public string TableName => "PoslovniPartner";

        public string InsertColumns => "ime, prezime, email, idMesto";

        public string InsertParameters => "@Ime, @Prezime, @Email, @IdMesto";

        public string UpdateStatement => "ime = @Ime, prezime = @Prezime, email = @Email, idMesto = @IdMesto";

        public string Condition => $"idPoslovniPartner = @IdPoslovniPartner";

        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdPoslovniPartner", IdPoslovniPartner },
            { "@Ime", Ime },
            { "@Prezime", Prezime },
            { "@Email", Email },
            { "@IdMesto", Mesto?.IdMesto },
        };

        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "ime", Ime },
            { "prezime", Prezime },
            { "email", Email },
            { "idMesto", Mesto?.IdMesto },
        };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            PoslovniPartner pp = new PoslovniPartner();
            pp.IdPoslovniPartner = reader.GetInt32(reader.GetOrdinal("idPoslovniPartner"));
            pp.Ime = reader.GetString(reader.GetOrdinal("ime"));
            pp.Prezime = reader.GetString(reader.GetOrdinal("prezime"));
            pp.Email = reader.GetString(reader.GetOrdinal("email"));
            pp.idMesto = reader.GetInt32(reader.GetOrdinal("idMesto"));
            return pp;
        }

        public override string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
