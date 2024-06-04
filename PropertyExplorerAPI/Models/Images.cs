using MongoDB.Bson.Serialization.Attributes;
namespace PropertyExplorerAPI.Models
{
    public class Images
    {
        [BsonElement("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [BsonElement("medium_url")]
        public string MediumUrl { get; set; }

        [BsonElement("picture_url")]
        public string PictureUrl { get; set; }

        [BsonElement("xl_picture_url")]
        public string XlPictureUrl { get; set; }
    }

}
