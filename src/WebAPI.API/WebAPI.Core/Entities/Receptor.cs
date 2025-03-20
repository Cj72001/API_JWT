using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebAPI.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class Receptor
    {
        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("tipoDocumento")]
        public string TipoDocumento { get; set; }

        [BsonElement("numDocumento")]
        public string NumDocumento { get; set; }

        [BsonElement("nombreComercial")]
        public string NombreComercial { get; set; }

        [BsonElement("codPais")]
        public string CodPais { get; set; }

        [BsonElement("nombrePais")]
        public string NombrePais { get; set; }

        [BsonElement("complemento")]
        public string Complemento { get; set; }

        [BsonElement("tipoPersona")]
        public int TipoPersona { get; set; }

        [BsonElement("descActividad")]
        public string DescActividad { get; set; }

        [BsonElement("telefono")]
        public string Telefono { get; set; }

        [BsonElement("correo")]
        public string Correo { get; set; }
    }
}
