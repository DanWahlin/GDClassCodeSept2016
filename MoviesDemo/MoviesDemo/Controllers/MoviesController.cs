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
            return View(movie);
        }
    }
}