using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesDemo.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [Compare("ConfirmedPassword", ErrorMessage ="Passwords do not match!")]
        public string Password { get; set; }

        [Required]
        public string ConfirmedPassword { get; set; }
    }
}