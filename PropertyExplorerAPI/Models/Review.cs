using MongoDB.Bson.Serialization.Attributes;
namespace PropertyExplorerAPI.Models
{
    public class Review
    {
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("date")]
        public BsonDateTime Date { get; set; }

        [BsonElement("listing_id")]
        public string ListingId { get; set; }

        [BsonElement("reviewer_id")]
        public string ReviewerId { get; set; }

        [BsonElement("reviewer_name")]
        public string ReviewerName { get; set; }

        [BsonElement("comments")]
        public string Comments { get; set; }
    }
}
