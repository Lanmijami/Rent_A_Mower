using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ostava : IEntity
    {
        public int IdOstava{ get; set; }
        public DateTime DatumOtvaranja { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public string TableName => "Ostava";

        public string InsertColumns => "datumOtvaranja, korisnickoIme, sifra";

        public string InsertParameters => "@DatumOtvaranja, @KorisnickoIme, @Sifra";

        public string UpdateStatement => "datumOtvaranja = @DatumOtvaranja, korisnickoIme = @KorisnickoIme, sifra = @Sifra";
        public string Condition => $"idOstava = @IdOstava";

        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdOstava", IdOstava },
            { "@DatumOtvaranja", DatumOtvaranja },
            { "@KorisnickoIme", KorisnickoIme },
            { "@Sifra", Sifra },
        };

        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            {"korisnickoIme", KorisnickoIme},
        };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Ostava o = new Ostava();
            o.IdOstava = reader.GetInt32(reader.GetOrdinal("idOstava"));
            o.DatumOtvaranja = reader.GetDateTime(reader.GetOrdinal("datumOtvaranja"));
            o.KorisnickoIme = reader.GetString(reader.GetOrdinal("korisnickoIme"));
            o.Sifra = reader.GetString(reader.GetOrdinal("sifra"));
            return o;
        }

        public override string ToString()
        {
            return this.KorisnickoIme;
        }
    }
}
