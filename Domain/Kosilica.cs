using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Kosilica : IEntity
    {
        public int IdKosilica { get; set; }
        public string Model { get; set; }
        public string Boja { get; set; }
        public int? GodinaProizvodnje { get; set; }
        public double? CenaKosilice { get; set; }
        public string TableName => "Kosilica";

        public string InsertColumns => "model, boja, godinaProizvodnje, cenaKosilice";

        public string InsertParameters => "@Model, @Boja, @GodinaProizvodnje, @CenaKosilice";

        public string UpdateStatement => "model = @Model, boja = @Boja, godinaProizvodnje = @GodinaProizvodnje, cenaKosilice = @CenaKosilice";

        public string Condition => "idKosilica = @IdKosilica";

        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdKosilica", IdKosilica },
            { "@Model", Model },
            { "@Boja", Boja },
            { "@GodinaProizvodnje", GodinaProizvodnje },
            { "@CenaKosilice", CenaKosilice },
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "model", Model },
            { "boja", Boja },
            { "godinaProizvodnje", GodinaProizvodnje },
            { "cenaKosilice", CenaKosilice },
        };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Kosilica k = new Kosilica();
            k.IdKosilica = reader.GetInt32(reader.GetOrdinal("idKosilica"));
            k.Model = reader.GetString(reader.GetOrdinal("model"));
            k.Boja = reader.GetString(reader.GetOrdinal("boja"));
            k.GodinaProizvodnje = reader.GetInt32(reader.GetOrdinal("godinaProizvodnje"));
            k.CenaKosilice = reader.GetDouble(reader.GetOrdinal("cenaKosilice"));
            return k;
        }

        public override string ToString()
        {
            return this.Model + " " + this.GodinaProizvodnje + " " + this.Boja;
        }
    }
}
