using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class BestRestaurantContext : DbContext
  {
    public DbSet<Cuisine> Cuisines {get; set;}
    public DbSet<Restaurant> Restaurants { get; set; }

    public BestRestaurantContext(DbContextOptions options) : base(options) { }
  }
}