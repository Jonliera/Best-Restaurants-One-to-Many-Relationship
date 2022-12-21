using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Linq;

namespace BestRestaurants.Controllers
{
public class CuisinesController : Controller
{
  private readonly BestRestaurantContext _db;

  public CuisinesController(BestRestaurantContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    List<Cuisine> model = _db.Cuisines.ToList();
    return View(model);
  }
  public ActionResult Create()
  {
      return View();
  }
  [HttpPost]
  public ActionResult Create (Cuisine cuisine)
  {
    _db.Cuisines.Add(cuisine);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }
}
}

