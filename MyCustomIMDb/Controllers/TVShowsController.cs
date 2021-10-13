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
    }
}
