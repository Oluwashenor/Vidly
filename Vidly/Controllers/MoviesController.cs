using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;
        
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m  => m.Genre).ToList();
            var viewModel = new IndexMovieViewModel()
            {
                Movies = movies
            };
            return View(viewModel);
        }

        public List<Movie> GetMovies()
        {
            var movies = new List<Movie>{
                new Movie
                {
                   Name="Futurama"
                },
                new Movie
                {
                   Name="Bojack Horseman"
                }
            };
            return movies;
        }
    }
}