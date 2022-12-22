using System.Collections.Generic;
using MySqlConnector;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
public class Cuisine
  {
    public int CuisineId { get; set; }
    public string Type { get; set; }
    // public List<Restaurant> Restaurants { get; set; }
  }
}
