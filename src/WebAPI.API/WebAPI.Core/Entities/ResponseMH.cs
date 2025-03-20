using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class ResponseMH
    {
        public int Version { get; set; }
        public string Ambiente { get; set; }
        public int VersionApp { get; set; }
        public string Estado { get; set; }
        public string CodigoGeneracion { get; set; }
        public string SelloRecibido { get; set; }
        public string FhProcesamiento { get; set; }
        public string ClasificaMsg { get; set; }
        public string CodigoMsg { get; set; }
        public string DescripcionMsg { get; set; }
        public List<object> Observaciones { get; set; }
    }
}