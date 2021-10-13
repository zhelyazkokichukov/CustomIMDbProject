using Microsoft.AspNetCore.Mvc;
using MyCustomIMDb.Data;
using MyCustomIMDb.Data.Models;
using MyCustomIMDb.Models;
using MyCustomIMDb.Models.TVShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Controllers
{

    public class TVShowsController : Controller
    {

        private readonly CustomIMDbDbContext data;

        public TVShowsController(CustomIMDbDbContext data)
        {
            this.data = data;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var tvshow = new TVShowFormModel();

            return View(tvshow);
        }

        [HttpPost]
        public IActionResult Add(TVShowFormModel tvshowForm)
        {
            var tvshow = new TVShow
            {
                Title = tvshowForm.Title,
                PlotSummary = tvshowForm.PlotSummary,
                ImageUrl = tvshowForm.ImageUrl,
                Length = tvshowForm.Length,
                ReleaseDate = tvshowForm.ReleaseDate,
                Storyline = tvshowForm.Storyline
            };

            data.TVShows.Add(tvshow);
            data.SaveChanges();

            return Redirect("/Movies/All");
        }

        public IActionResult All()
        {
            var all = data.TVShows.Select(t => new AllTVShowsQueryModel
            {
                Id = t.Id,
                Title = t.Title,
                PlotSummary = t.PlotSummary,
                ImageURL = t.ImageUrl,
                ReleaseDate = t.ReleaseDate
            }).ToList();

            return View(all);
        }

        public IActionResult Details(int id)
        {
            var tvshow = data.TVShows
                .Where(t => t.Id == id)
                .Select(t => new TVShowDetails
                {
                    Id = t.Id,
                    Title = t.Title,
                    Length = t.Length,
                    PlotSummary = t.PlotSummary,
                    ImageURL = t.ImageUrl,
                    ReleaseDate = t.ReleaseDate,
                    Storyline = t.Storyline
                })
                .FirstOrDefault();

            //I Should add TVShow rating table and ratings column

            return View(tvshow);
        }

        public IActionResult Delete(int id)
        {
            var tvshow = data.TVShows.Where(t => t.Id == id)
                .FirstOrDefault();

            data.TVShows.Remove(tvshow);
            data.SaveChanges();

            return View(tvshow);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var tvshow = data.TVShows.Where(t => t.Id == id).FirstOrDefault();

            return View(tvshow);
        }


        [HttpPost]
        public IActionResult Edit(TVShow preEditedTVShow)
        {
            var postEditedTVShow = new TVShow
            {
                Title = preEditedTVShow.Title,
                PlotSummary = preEditedTVShow.PlotSummary,
                ImageUrl = preEditedTVShow.ImageUrl,
                Length = preEditedTVShow.Length,
                ReleaseDate = preEditedTVShow.ReleaseDate,
                Storyline = preEditedTVShow.Storyline
            };

            data.TVShows.Remove(preEditedTVShow);

            data.TVShows.Update(postEditedTVShow);

            data.SaveChanges();

            return Redirect("/TVShows/All");

        }
    }
}
