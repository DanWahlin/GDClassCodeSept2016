using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesDemo.Models
{
    public class Movie
    {
        //prop (tab + tab)
        public int Id { get; set; }

        [Required(ErrorMessage="Title is required!")]
        [MinLength(5, ErrorMessage="Title must be at least 5 chars")]
        public string Title { get; set; }


        [Required]
        public string Director { get; set; }
        public List<Actor> Actors { get; set; }
        public Category Category { get; set; }
    }
}