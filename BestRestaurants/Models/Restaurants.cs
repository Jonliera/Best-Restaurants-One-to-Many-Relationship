using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Linq;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
  }
}
