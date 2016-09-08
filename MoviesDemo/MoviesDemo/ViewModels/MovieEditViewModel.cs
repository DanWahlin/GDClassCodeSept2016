using MoviesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesDemo.ViewModels
{
    public class MovieEditViewModel
    {
        public Movie Movie { get; set; }
        public List<Category> Categories { get; set; }
    }
}