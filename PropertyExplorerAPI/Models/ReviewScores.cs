using MongoDB.Bson.Serialization.Attributes;
namespace PropertyExplorerAPI.Models
{
    public class ReviewScores
    {
        [BsonElement("review_scores_accuracy")]
        public int ReviewScoresAccuracy { get; set; }

        [BsonElement("review_scores_cleanliness")]
        public int ReviewScoresCleanliness { get; set; }

        [BsonElement("review_scores_checkin")]
        public int ReviewScoresCheckin { get; set; }

        [BsonElement("review_scores_communication")]
        public int ReviewScoresCommunication { get; set; }

        [BsonElement("review_scores_location")]
        public int ReviewScoresLocation { get; set; }

        [BsonElement("review_scores_value")]
        public int ReviewScoresValue { get; set; }

        [BsonElement("review_scores_rating")]
        public int ReviewScoresRating { get; set; }
    }

}
