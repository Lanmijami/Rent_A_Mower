using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OstavaVlasnik : IEntity
    {
        public Ostava Ostava { get; set; }
        public Vlasnik Vlasnik { get; set; }
        public DateTime DatumOtvaranja { get; set; }
        public int idOstava;
        public int idVlasnik;
        public string TableName => "OstavaVlasnik";

        public string InsertColumns => "idOstava, idVlasnik, datumOtvaranja";

        public string InsertParameters => "@IdOstava, @IdVlasnik, @DatumOtvaranja";

        public string UpdateStatement => "idOstava = @IdOstava, idVlasnik = @IdVlasnik, datumOtvaranja = @DatumOtvaranja";

        public string Condition => "idOstava = @IdOstava AND idVlasnik = @IdVlasnik";

        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdOstava", Ostava?.IdOstava },
            { "@IdVlasnik", Vlasnik?.IdVlasnik },
            { "@DatumOtvaranja", DatumOtvaranja },
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {

        };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            OstavaVlasnik ov = new OstavaVlasnik();
            ov.idOstava = reader.GetInt32(reader.GetOrdinal("idOstava"));
            ov.idVlasnik = reader.GetInt32(reader.GetOrdinal("idVlasnik"));
            ov.DatumOtvaranja = reader.GetDateTime(reader.GetOrdinal("datumOtvaranja"));
            return ov;
        }

        public override string ToString()
        {
            return $"{Ostava?.KorisnickoIme ?? "N/A"} na {Vlasnik?.Ime ?? "N/A"} od {DatumOtvaranja}";
        }
    }
}
