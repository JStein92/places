using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(Place.GetAll());
    }

    [HttpGet("/new-place")]
    public ActionResult PlaceForm()
    {
      return View("place-form");
    }

    [HttpPost("/")]
    public ActionResult PostIndex()
    {
      Place myPlace = new Place(Request.Form["city"], int.Parse(Request.Form["days"]), Request.Form["imagePath"]);

      return View("index", Place.GetAll());
    }

    [HttpGet("/{id}")]
    public ActionResult PlaceDetails(int id)
    {
      Place place = Place.Find(id);
      return View("place-details", place);
    }
  }
}
