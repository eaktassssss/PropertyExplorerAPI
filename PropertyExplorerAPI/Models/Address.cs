using MongoDB.Bson.Serialization.Attributes;

namespace PropertyExplorerAPI.Models
{
    public class Address
    {
        [BsonElement("street")]
        public string Street { get; set; }

        [BsonElement("suburb")]
        public string Suburb { get; set; }

        [BsonElement("government_area")]
        public string GovernmentArea { get; set; }

        [BsonElement("market")]
        public string Market { get; set; }

        [BsonElement("country")]
        public string Country { get; set; }

        [BsonElement("country_code")]
        public string CountryCode { get; set; }

        [BsonElement("location")]
        public Location Location { get; set; }
    }

}
