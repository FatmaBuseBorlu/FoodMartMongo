using AspNetCore.Identity.Mongo.Model;


namespace FoodMartMongo.Entities
{
    public class AppUser: MongoUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
        public string?  ProfileImageUrl { get; set; }
    }
}
