using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebAPI.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class CuerpoDocumento
    {
        [BsonElement("numItem")]
        public int NumItem { get; set; }

        [BsonElement("cantidad")]
        public decimal Cantidad { get; set; }

        [BsonElement("codigo")]
        public string Codigo { get; set; }

        [BsonElement("uniMedida")]
        public int UniMedida { get; set; }

        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("precioUni")]
        public double PrecioUni { get; set; }

        [BsonElement("montoDescu")]
        public double MontoDescu { get; set; }

        [BsonElement("ventaGravada")]
        public double VentaGravada { get; set; }

        [BsonElement("tributos")]
        public object Tributos { get; set; }

        [BsonElement("noGravado")]
        public double NoGravado { get; set; }
    }
}
