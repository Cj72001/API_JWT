using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.Entities
{
    [BsonIgnoreExtraElements]
    public class Dte
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("dte")]
        public DteData DteData { get; set; }

        [BsonElement("responseMH")]
        public ResponseMH ResponseMH { get; set; }
    }
}
