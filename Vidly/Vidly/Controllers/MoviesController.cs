using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
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

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies/Index
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        // GET: Movies/Details
        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(x => x.Id == Id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MoviesViewModel
            {
                Movie = new Movie(),
                Genres = genres
            };
            ViewBag.Title = "New Movies";
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new MoviesViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }


            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.Single(m => m.Id == Id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MoviesViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            ViewBag.Title = "Edit Movies";
            return View("MovieForm", viewModel);
        }
        //toberemoved
        //attribute routing
        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

    }
}