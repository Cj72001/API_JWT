using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class Identificacion
    {
        [BsonElement("version")]
        public int Version { get; set; }

        [BsonElement("ambiente")]
        public string Ambiente { get; set; }

        [BsonElement("tipoDte")]
        public string TipoDte { get; set; }

        [BsonElement("numeroControl")]
        public string NumeroControl { get; set; }

        [BsonElement("codigoGeneracion")]
        public string CodigoGeneracion { get; set; }

        [BsonElement("tipoModelo")]
        public int TipoModelo { get; set; }

        [BsonElement("tipoOperacion")]
        public int TipoOperacion { get; set; }

        [BsonElement("tipoContingencia")]
        public object TipoContingencia { get; set; }

        [BsonElement("motivoContigencia")]
        public object MotivoContigencia { get; set; }

        [BsonElement("fecEmi")]
        public string FecEmi { get; set; }

        [BsonElement("horEmi")]
        public string HorEmi { get; set; }

        [BsonElement("tipoMoneda")]
        public string TipoMoneda { get; set; }
    }
}
