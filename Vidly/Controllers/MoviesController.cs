using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
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
            var viewModel = new IndexMovieViewModel()
            {
                Movies = movies
            };
            return View(viewModel);
        }
    }
}