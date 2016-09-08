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
            movie.Actors = new List<Actor>
            {
                new Actor { Id=1, Name="Mark Hamill",Rating=9 },
                new Actor { Id=2, Name="Harrison Ford",Rating=10 },
                new Actor { Id=3, Name="Carrie Fisher",Rating=10 }
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