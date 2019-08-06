using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        [HttpGet]
        public Movie GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return movie;
        }

        [HttpPost]
        public Movie CreateMovie(Movie movie)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return movie;
        }

        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDB = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDB == null)
                return NotFound();

            movieInDB.Name = movie.Name;
            movieInDB.GenreId = movie.GenreId;
            movieInDB.NumberInStock = movie.NumberInStock;
            movieInDB.ReleaseDate = movie.ReleaseDate;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var customerInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (customerInDb == null)
                return NotFound();

            _context.Movies.Remove(customerInDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
