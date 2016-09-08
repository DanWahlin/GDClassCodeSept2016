using MoviesDemo.Models;
using MoviesDemo.ViewModels;
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
            movie.Id = 1;
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

        public ActionResult Edit(int id)
        {
            //Movies table
            var movie = new Movie();
            movie.Id = 1;
            movie.Title = "Star Wars";
            movie.Director = "George Lucas";

            //Categories table
            var categories = new List<Category>
            {
                new Category { Id=1, Name="Action" },
                new Category { Id=2, Name="Horror" }
            };

            var vm = new MovieEditViewModel
            {
                Movie = movie,
                Categories = categories
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            return View();
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
            //ALWAYS PUT THIS!!!!
            if (!ModelState.IsValid)
            {
                return View(movie);
            }
            //Insert into database
            return RedirectToAction("Index");
        }
    }
}