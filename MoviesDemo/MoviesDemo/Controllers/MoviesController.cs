using MoviesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesDemo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        // Action
        public ActionResult Index()
        {
            var movie = new Movie();
            movie.Title = "Star Wars";
            movie.Director = "George Lucas";
            movie.Actors = new List<string>
            {
                "Mark Hamill",
                "Harrison Ford",
                "Carrie Fisher"
            };
            return View(movie);
        }

        //Serve the form to the browser
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //Receive data back from browser
        //when they submit the form
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            return View(movie);
        }
    }
}