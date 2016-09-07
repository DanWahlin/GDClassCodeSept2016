using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesDemo.Models
{
    public class Movie
    {
        //prop (tab + tab)
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Actors { get; set; }
    }
}