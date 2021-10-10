using Microsoft.AspNetCore.Mvc;
using MyCustomIMDb.Data;
using MyCustomIMDb.Data.Models;
using MyCustomIMDb.Models.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Controllers
{
    public class MenuController : Controller
    {

        private readonly CustomIMDbDbContext data;
        public MenuController(CustomIMDbDbContext data)
        {
            this.data = data;
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult TopRatedMovies()
        {
            var movies = data.Movies
                .Select(m => new TopRatedMovies
                {
                    Title = m.Title,
                    ReleaseDate = m.ReleaseDate,
                    Url = m.ImageUrl,
                    Ratings = m.MovieRating                  
                    .Select(x =>  x.Rating)
                    .ToList()
                })
                .ToList();

            var moviesList = movies.OrderByDescending(x => x.Ratings);

            return View(moviesList);
        }
    }
}
