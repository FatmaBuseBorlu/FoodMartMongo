using Microsoft.EntityFrameworkCore;

namespace FoodMartMongo.Context
{
    public class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EmailChatDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}