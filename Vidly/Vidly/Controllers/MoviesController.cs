using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Index
        public ActionResult Index()
        {
            var movie = new List<Movie>()
            {
                new Movie() { Name = "Shrek"},
                new Movie() { Name = "Wall-e"}
            };


            return View(movie);
        }


        //attribute routing
        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

    }
}