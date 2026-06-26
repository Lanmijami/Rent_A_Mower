using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class StavkaIznajmljivanja : IEntity
    {
        public int Rb { get; set; }
        public double CenaNajma { get; set; }
        public Kosilica Kosilica { get; set; }
        public int IdIznajmljivanje { get; set; }
        public int NewRb { get; set; }
        public int idKosilica { get; set; }
        public string TableName => "StavkaIznajmljivanja";
        public string InsertColumns => "idIznajmljivanje, rb, cenaNajma, idKosilica";
        public string InsertParameters => "@IdIznajmljivanje, @Rb, @CenaNajma, @IdKosilica";
        public string UpdateStatement => "idIznajmljivanje = @IdIznajmljivanje, rb = @NewRb, cenaNajma = @CenaNajma, idKosilica = @IdKosilica";
        public string Condition => "idIznajmljivanje = @IdIznajmljivanje AND rb = @Rb";
        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdIznajmljivanje", IdIznajmljivanje },
            { "@Rb", Rb },
            { "@CenaNajma", CenaNajma },
            { "@IdKosilica", Kosilica.IdKosilica },
            { "@NewRb", NewRb }
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "idIznajmljivanje", IdIznajmljivanje },
            /*{ "cenaNajma", CenaNajma },*/
            { "idKosilica", Kosilica?.IdKosilica },
        };
        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            StavkaIznajmljivanja si = new StavkaIznajmljivanja();
            si.IdIznajmljivanje = reader.GetInt32(reader.GetOrdinal("idIznajmljivanje"));
            si.Rb = reader.GetInt32(reader.GetOrdinal("rb"));
            si.CenaNajma = reader.GetDouble(reader.GetOrdinal("cenaNajma"));
            si.idKosilica = reader.GetInt32(reader.GetOrdinal("idKosilica"));
            return si;
        }

        public override string ToString()
        {
            return this.Kosilica.Model;
        }
    }
}
