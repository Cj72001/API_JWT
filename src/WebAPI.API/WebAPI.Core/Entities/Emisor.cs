using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebAPI.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class Emisor
    {
        [BsonElement("nit")]
        public string Nit { get; set; }

        [BsonElement("nrc")]
        public string Nrc { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("codActividad")]
        public string CodActividad { get; set; }

        [BsonElement("descActividad")]
        public string DescActividad { get; set; }

        [BsonElement("nombreComercial")]
        public string NombreComercial { get; set; }

        [BsonElement("tipoEstablecimiento")]
        public string TipoEstablecimiento { get; set; }

        [BsonElement("direccion")]
        public Direccion Direccion { get; set; }

        [BsonElement("telefono")]
        public string Telefono { get; set; }

        [BsonElement("correo")]
        public string Correo { get; set; }

        [BsonElement("codEstableMH")]
        public object CodEstableMH { get; set; }

        [BsonElement("codEstable")]
        public object CodEstable { get; set; }

        [BsonElement("codPuntoVentaMH")]
        public object CodPuntoVentaMH { get; set; }

        [BsonElement("codPuntoVenta")]
        public object CodPuntoVenta { get; set; }

        [BsonElement("tipoItemExpor")]
        public int TipoItemExpor { get; set; }

        [BsonElement("recintoFiscal")]
        public object RecintoFiscal { get; set; }

        [BsonElement("regimen")]
        public object Regimen { get; set; }
    }
}
