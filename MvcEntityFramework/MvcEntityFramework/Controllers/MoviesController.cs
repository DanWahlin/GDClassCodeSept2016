using MvcEntityFramework.Models;
using MvcEntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEntityFramework.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new MoviesRepository().GetMovies();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var status = new MoviesRepository().InsertMovie(movie);
                if (status)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(movie);
        }
    }
}