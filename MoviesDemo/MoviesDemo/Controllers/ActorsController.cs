using MoviesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesDemo.Controllers
{
    public class ActorsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Actors";
            var actors = new List<Actor>
            {
                new Actor { Id=1, Name="Mark Hamill",Rating=9 },
                new Actor { Id=2, Name="Harrison Ford",Rating=10 },
                new Actor { Id=3, Name="Carrie Fisher",Rating=10 }
            };
            //Render List
            return View(actors);
        }

        public ActionResult Details(int id)
        {
            var actor = new Actor { Id = id, Name = "Mark Hamill", Rating = 9 };
            return View(actor);
        }

        public ActionResult Edit(int id)
        {
            var actor = new Actor { Id = id, Name = "Mark Hamill", Rating = 9 };
            return View(actor);
        }

        [HttpPost]
        public ActionResult Edit(Actor actor)
        {
            return View(actor);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Actor actor)
        {
            //Insert actor into database
            return View(actor);
        }
    }
}