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
    public class MoviesController : Controller
    {
        private readonly CustomIMDbDbContext data;
        public MoviesController(CustomIMDbDbContext data)
        {
            this.data = data;
        }

        public IActionResult Rate(int id,int rate)
        {
            var movie = data.Movies
                .Where(m => m.Id == id)
                .FirstOrDefault();

                       
            var rating = new MovieRating
            {
                Rating = rate
            };

            movie.MovieRating.Add(rating);
            data.SaveChanges();

            return Redirect("/");
        }

        public IActionResult Details(int id)
        {
            var movie = data.Movies
                .Where(m => m.Id == id)
                .Select(m => new MovieDetails 
                {
                    Id =m.Id,
                    Title = m.Title,
                    Length = m.Length,
                    PlotSummary = m.PlotSummary,
                    ImageURL = m.ImageUrl,
                    ReleaseDate = m.ReleaseDate,
                    Storyline = m.Storyline,
                    Ratings = m.MovieRating.Select(x => x.Rating).ToList()
                })
                .FirstOrDefault();


            return View(movie);
        }

        public IActionResult Delete(int id)
        {
            var movie = data.Movies.Where(m => m.Id == id)
                .FirstOrDefault();

            data.Movies.Remove(movie);
            data.SaveChanges();

            return View(movie);
        }

        public IActionResult Edit(int id)
        {
            var movie = data.Movies.Where(m => m.Id == id);


            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            var movie = new MovieFormModel();

            return View(movie);
        }

        [HttpPost]
        public IActionResult Add(MovieFormModel movieForm)
        {
            var movie = new Movie
            {
                Title = movieForm.Title,
                PlotSummary = movieForm.PlotSummary,
                ImageUrl = movieForm.ImageUrl,
                Length = movieForm.Length,
                ReleaseDate = movieForm.ReleaseDate,
                Storyline = movieForm.Storyline
            };

            data.Movies.Add(movie);
            data.SaveChanges();

            return Redirect("/Movies/All");
        }

        public IActionResult All()
        {
            var all = data.Movies.Select(m => new AllMoviesQueryModel
            { 
                Id = m.Id,
                Title = m.Title,
                PlotSummary = m.PlotSummary,
                ImageURL = m.ImageUrl,
                ReleaseDate = m.ReleaseDate
            }).ToList();

            return View(all);
        }
    }
}
