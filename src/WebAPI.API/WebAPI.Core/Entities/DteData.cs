using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class DteData
    {
        [BsonElement("identificacion")]
        public Identificacion Identificacion { get; set; }

        [BsonElement("emisor")]
        public Emisor Emisor { get; set; }

        [BsonElement("receptor")]
        public Receptor Receptor { get; set; }

        [BsonElement("cuerpoDocumento")]
        public List<CuerpoDocumento> CuerpoDocumento { get; set; }

        [BsonElement("resumen")]
        public Resumen Resumen { get; set; }

        [BsonElement("otrosDocumentos")]
        public object OtrosDocumentos { get; set; }

        [BsonElement("ventaTercero")]
        public object VentaTercero { get; set; }

        [BsonElement("apendice")]
        public object Apendice { get; set; }
    }
}
