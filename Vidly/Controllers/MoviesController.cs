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

        public ActionResult MovieForm()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres=genres
            };
            return View(viewModel);
        }

        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
               
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return Content("Id = " + movie.Id + " Name = " + movie.Name);
            }    
            else
            {
                return Content("YOu can not edit yet man");
            }



            return RedirectToAction("Index");
              
        }

        public ActionResult Detail(int Id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == Id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == Id);
            var genres = _context.Genres.ToList();
            if(movie == null)
            {
                return HttpNotFound();
            }
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }
    }
}