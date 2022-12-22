using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Linq;


namespace BestRestaurants.Controllers
{
public class RestaurantsController : Controller
{
  private readonly BestRestaurantContext _db;
  public RestaurantsController(BestRestaurantContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    List<Restaurant> model = _db.Restaurants.ToList();
    return View(model);
  }
  public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }
    }
  }



// //here's where we left off!

// public ItemsController(ToDoListContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Item> model = _db.Items
//                             .Include(item => item.Category)
//                             .ToList();
//       return View(model);
//     }