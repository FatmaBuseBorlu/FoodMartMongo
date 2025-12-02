using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodMartMongo.Entities
{
    public class Feature
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FeatureId { get; set; }

        public string Title { get; set; }
        public string Url { get; set; }   
    }
}
