using MongoDB.Bson.Serialization.Attributes;
namespace PropertyExplorerAPI.Models
{
    public class Location
    {
        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("coordinates")]
        public List<double> Coordinates { get; set; }

        [BsonElement("is_location_exact")]
        public bool IsLocationExact { get; set; }
    }

}
