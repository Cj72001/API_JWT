using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebAPI.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class Direccion
    {
        [BsonElement("departamento")]
        public string Departamento { get; set; }

        [BsonElement("municipio")]
        public string Municipio { get; set; }

        [BsonElement("complemento")]
        public string Complemento { get; set; }
    }
}
