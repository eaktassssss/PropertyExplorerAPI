using MongoDB.Bson.Serialization.Attributes;
namespace PropertyExplorerAPI.Models
{
    public class Location
    {
        [BsonElement("city")]
        public string City { get; set; }
        [BsonElement("district")]
        public string District { get; set; }
    }
}
