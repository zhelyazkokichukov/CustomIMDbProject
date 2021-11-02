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

        public IActionResult Rate(int id, int rate)
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
                    Id = m.Id,
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = data.Movies.Where(m => m.Id == id).FirstOrDefault();

            var movieFormModel = new MovieFormModel
            {
                Title = movie.Title,
                PlotSummary = movie.PlotSummary,
                Storyline = movie.Storyline,
                Length = movie.Length,
                ImageUrl = movie.ImageUrl,
                ReleaseDate = movie.ReleaseDate,
            };

            return View(movieFormModel);
        }

        [HttpPost]
        public IActionResult Edit(int id,MovieFormModel preEditedMovie)
        {
            var movie = data.Movies.Where(x => x.Id == id).FirstOrDefault();

            if (ModelState.IsValid)
            {
                //var postEditedMovie = new Movie
                //{
                //    Title = preEditedMovie.Title,
                //    PlotSummary = preEditedMovie.PlotSummary,
                //    ImageUrl = preEditedMovie.ImageUrl,
                //    Length = preEditedMovie.Length,
                //    ReleaseDate = preEditedMovie.ReleaseDate,
                //    Storyline = preEditedMovie.Storyline
                //};
                
                //data.Movies.Remove(preEditedMovie);

                data.SaveChanges();

                return Redirect("/Movies/All");
            }

            return Redirect("/Movies/All");                 
        }

        public IActionResult Add()
        {
            var movie = new MovieFormModel();

            return View(movie);
        }

        [HttpPost]
        public IActionResult Add(MovieFormModel movieForm)
        {
            if (ModelState.IsValid)
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

            return Redirect("/Movies/Add");
            
               // add model state check
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

        public IActionResult PhotoGallery()
        {
            return View();
        }
    }
}
