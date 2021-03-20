using Microsoft.EntityFrameworkCore;
namespace CavuCafe.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<FoodItem> FoodItems { get; set;}
        public DbSet<DrinkItem> DrinkItems { get; set;}
        public DbSet<Category> Categories {get; set;}
    }
}