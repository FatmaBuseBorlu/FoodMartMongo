using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodMartMongo.Entities
{
    public class Slider
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SlidertId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
