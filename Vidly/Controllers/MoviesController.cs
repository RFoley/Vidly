using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            
            return View(movies);
        }

        // GET: Movies/Details/{id}
        public ActionResult Details(int Id)
        {
            // Use LINQ + lambda to find customer in list with matching Id
            var movie = GetMovies().SingleOrDefault(m => m.Id == Id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);

        }

        // temp. hard coded values until I sort out a Movies table in the db
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Shrek 2"},
                new Movie {Id = 3, Name = "Shrek the Third"},
                new Movie {Id = 4, Name = "Shrek Forever After"},
                new Movie {Id = 5, Name = "Shrek 5"},
                new Movie {Id = 6, Name = "Wall-E"}
            };
        }
    }
}