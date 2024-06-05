using MongoDB.Bson.Serialization.Attributes;
namespace PropertyExplorerAPI.Models
{
    public class Host
    {
        [BsonElement("host_id")]
        public string HostId { get; set; }

        [BsonElement("host_url")]
        public string HostUrl { get; set; }

        [BsonElement("host_name")]
        public string HostName { get; set; }

        [BsonElement("host_location")]
        public string HostLocation { get; set; }

        [BsonElement("host_about")]
        public string HostAbout { get; set; }

        [BsonElement("host_thumbnail_url")]
        public string HostThumbnailUrl { get; set; }

        [BsonElement("host_picture_url")]
        public string HostPictureUrl { get; set; }

        [BsonElement("host_neighbourhood")]
        public string HostNeighbourhood { get; set; }

        [BsonElement("host_is_superhost")]
        public bool HostIsSuperhost { get; set; }

        [BsonElement("host_has_profile_pic")]
        public bool HostHasProfilePic { get; set; }

        [BsonElement("host_identity_verified")]
        public bool HostIdentityVerified { get; set; }

        [BsonElement("host_listings_count")]
        public int HostListingsCount { get; set; }

        [BsonElement("host_total_listings_count")]
        public int HostTotalListingsCount { get; set; }

        [BsonElement("host_verifications")]
        public List<string> HostVerifications { get; set; }
    }


}