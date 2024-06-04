using MongoDB.Bson.Serialization.Attributes;
namespace PropertyExplorerAPI.Models
{
    public class Availability
    {
        [BsonElement("availability_30")]
        public int Availability30 { get; set; }

        [BsonElement("availability_60")]
        public int Availability60 { get; set; }

        [BsonElement("availability_90")]
        public int Availability90 { get; set; }

        [BsonElement("availability_365")]
        public int Availability365 { get; set; }
    }
}
