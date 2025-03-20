using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebAPI.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class Resumen
    {
        [BsonElement("totalGravada")]
        public double TotalGravada { get; set; }

        [BsonElement("descuento")]
        public double Descuento { get; set; }

        [BsonElement("porcentajeDescuento")]
        public double PorcentajeDescuento { get; set; }

        [BsonElement("totalDescu")]
        public double TotalDescu { get; set; }

        [BsonElement("seguro")]
        public double Seguro { get; set; }

        [BsonElement("flete")]
        public double Flete { get; set; }

        [BsonElement("montoTotalOperacion")]
        public double MontoTotalOperacion { get; set; }

        [BsonElement("totalNoGravado")]
        public double TotalNoGravado { get; set; }

        [BsonElement("totalPagar")]
        public double TotalPagar { get; set; }

        [BsonElement("totalLetras")]
        public string TotalLetras { get; set; }

        [BsonElement("condicionOperacion")]
        public int CondicionOperacion { get; set; }

        [BsonElement("pagos")]
        public object Pagos { get; set; }

        [BsonElement("codIncoterms")]
        public object CodIncoterms { get; set; }

        [BsonElement("descIncoterms")]
        public object DescIncoterms { get; set; }

        [BsonElement("numPagoElectronico")]
        public object NumPagoElectronico { get; set; }

        [BsonElement("observaciones")]
        public string Observaciones { get; set; }
    }
}
