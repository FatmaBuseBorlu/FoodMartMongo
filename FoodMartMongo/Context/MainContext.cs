using FoodMartMongo.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodMartMongo.Context
{
    public class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NBRMDOS;initial Catalog=EmailChatDb;integrated Security=true;trust server certificate=true");
        }
    }
}
