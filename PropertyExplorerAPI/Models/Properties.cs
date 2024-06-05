using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PropertyExplorerAPI.Models
{
    public class Properties
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("listing_url")]
        public string ListingUrl { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("summary")]
        public string Summary { get; set; }

        [BsonElement("space")]
        public string Space { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("neighborhood_overview")]
        public string NeighborhoodOverview { get; set; }

        [BsonElement("notes")]
        public string Notes { get; set; }

        [BsonElement("transit")]
        public string Transit { get; set; }

        [BsonElement("access")]
        public string Access { get; set; }

        [BsonElement("interaction")]
        public string Interaction { get; set; }

        [BsonElement("house_rules")]
        public string HouseRules { get; set; }

        [BsonElement("property_type")]
        public string PropertyType { get; set; }

        [BsonElement("room_type")]
        public string RoomType { get; set; }

        [BsonElement("bed_type")]
        public string BedType { get; set; }

        [BsonElement("minimum_nights")]
        public int MinimumNights { get; set; }

        [BsonElement("maximum_nights")]
        public int MaximumNights { get; set; }

        [BsonElement("cancellation_policy")]
        public string CancellationPolicy { get; set; }

        [BsonElement("last_scraped")]
        public DateTime LastScraped { get; set; }

        [BsonElement("calendar_last_scraped")]
        public DateTime CalendarLastScraped { get; set; }

        [BsonElement("first_review")]
        public DateTime FirstReview { get; set; }

        [BsonElement("last_review")]
        public DateTime LastReview { get; set; }

        [BsonElement("accommodates")]
        public int Accommodates { get; set; }

        [BsonElement("bedrooms")]
        public int Bedrooms { get; set; }

        [BsonElement("beds")]
        public int Beds { get; set; }

        [BsonElement("number_of_reviews")]
        public int NumberOfReviews { get; set; }

        [BsonElement("bathrooms")]
        public Decimal128 Bathrooms { get; set; }

        [BsonElement("amenities")]
        public List<string> Amenities { get; set; }

        [BsonElement("price")]
        public Decimal128 Price { get; set; }

        [BsonElement("security_deposit")]
        public Decimal128 SecurityDeposit { get; set; }

        [BsonElement("cleaning_fee")]
        public Decimal128 CleaningFee { get; set; }

        [BsonElement("extra_people")]
        public Decimal128 ExtraPeople { get; set; }

        [BsonElement("guests_included")]
        public Decimal128 GuestsIncluded { get; set; }

        [BsonElement("images")]
        public Images Images { get; set; }

        [BsonElement("host")]
        public Host Host { get; set; }

        [BsonElement("address")]
        public Address Address { get; set; }

        [BsonElement("availability")]
        public Availability Availability { get; set; }

        [BsonElement("review_scores")]
        public ReviewScores ReviewScores { get; set; }

        [BsonElement("reviews")]
        public List<Review> Reviews { get; set; }
    }

}
