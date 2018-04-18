using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VisitedPlaces.Models;


namespace VisitedPlaces.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpGet("/places/{id}")]
        public ActionResult Details(int id)
        {
            Place place = Place.Find(id);
            return View(place);
        }

        [HttpPost("/places")]
        public ActionResult Create()
        {
          Place newJob = new Place(Request.Form["new-city"], Request.Form["new-country"], Request.Form["new-image"]);

          List<Place> allPlaces = Place.GetAll();
          return View("Index", allPlaces);
        }
    }
}
