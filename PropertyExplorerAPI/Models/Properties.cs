using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PropertyExplorerAPI.Models
{
    public class Properties
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("categoryId")]
        public string CategoryId { get; set; }
        [BsonElement("description")]

        public string Description { get; set; }
        [BsonElement("price")]
        public int Price { get; set; }
        [BsonElement("location")]
        public Location Location { get; set; }
        [BsonElement("postedBy")]
        public string PostedBy { get; set; }
    }


}
