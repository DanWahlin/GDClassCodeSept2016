using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace MvcEntityFramework.Repository
{
    //Data access class
    public class MoviesRepository
    {
        public List<Movie> GetMovies()
        {
            using (var context = new MoviesDbContext())
            {
                var movies = (from m in context.Movies
                              select m).ToList();
                return movies;
            } //Dispose() = Close()
        }

        public bool InsertMovie(Movie movie)
        {
            using (var context = new MoviesDbContext())
            {
                context.Movies.Add(movie);
                return (context.SaveChanges() == 0) ? false : true;
            } 
        }

        public Movie GetMovie(int id)
        {
            using (var context = new MoviesDbContext())
            {
                var movie = (from m in context.Movies
                             where m.Id == id
                             select m).SingleOrDefault();
                return movie;
            }
        }

        public List<Distributor> GetDistributors()
        {
            using (var context = new MoviesDbContext())
            {
                var dists = (from d in context.Distributors
                             select d).ToList();
                return dists;
            }
        }
    }
}