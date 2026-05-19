using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Iznajmljivanje : IEntity
    {
        public int IdIznajmljivanje { get; set; }
        public DateTime? DatumIznajmljivanja { get; set; }
        public DateTime? DatumPovratka { get; set; }
        public Ostava Ostava { get; set; }
        public PoslovniPartner PoslovniPartner { get; set; }
        public List<StavkaIznajmljivanja> Stavke { get; set; }
        public Iznajmljivanje()
        {
            Stavke = new List<StavkaIznajmljivanja>();
        }
        public int idOstava;
        public int idPoslovniPartner;
        public string TableName => "Iznajmljivanje";

        public string InsertColumns => "datumIznajmljivanja, datumPovratka, idOstava, idPoslovniPartner";

        public string InsertParameters => "@DatumIznajmljivanja, @DatumPovratka, @IdOstava, @IdPoslovniPartner";

        public string UpdateStatement => "datumIznajmljivanja = @DatumIznajmljivanja, datumPovratka = @DatumPovratka, idOstava = @IdOstava, idPoslovniPartner = @IdPoslovniPartner";

        public string Condition => $"idIznajmljivanje = @IdIznajmljivanje";

        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdIznajmljivanje", IdIznajmljivanje },
            { "@DatumIznajmljivanja", DatumIznajmljivanja },
            { "@DatumPovratka", DatumPovratka },
            { "@IdOstava", Ostava?.IdOstava },
            { "@IdPoslovniPartner", PoslovniPartner?.IdPoslovniPartner },
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "idOstava", Ostava?.IdOstava },
            { "idPoslovniPartner", PoslovniPartner?.IdPoslovniPartner },
            { "datumIznajmljivanja", DatumIznajmljivanja },
            { "datumPovratka", DatumPovratka }
        };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Iznajmljivanje i = new Iznajmljivanje();
            i.IdIznajmljivanje = reader.GetInt32(reader.GetOrdinal("idIznajmljivanje"));
            i.DatumIznajmljivanja = reader.GetDateTime(reader.GetOrdinal("datumIznajmljivanja"));
            i.DatumPovratka = reader.GetDateTime(reader.GetOrdinal("datumPovratka"));
            i.idOstava = reader.GetInt32(reader.GetOrdinal("idOstava"));
            i.idPoslovniPartner = reader.GetInt32(reader.GetOrdinal("idPoslovniPartner"));
            return i;
        }

        public override string ToString()
        {
            return this.Ostava + "-" + this.PoslovniPartner + ": " + this.DatumIznajmljivanja + "-" + this.DatumPovratka;
        }
    }
}
