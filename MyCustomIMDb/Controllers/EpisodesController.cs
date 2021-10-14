using Microsoft.AspNetCore.Mvc;
using MyCustomIMDb.Data;
using MyCustomIMDb.Data.Models;
using MyCustomIMDb.Models.Episode;
using MyCustomIMDb.Models.TVShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Controllers
{

    public class EpisodesController : Controller
    {
        private readonly CustomIMDbDbContext data;

        public EpisodesController(CustomIMDbDbContext data)
        {
            this.data = data;
        }


        [HttpGet]
        public IActionResult Add()
        {
            var episode = new EpisodeFormModel();

            return View(episode);
        }

        [HttpPost]
        public IActionResult Add(int id, EpisodeFormModel episodeForm)
        {

            var tvshow = data.TVShows.Where(x => x.Id == id).FirstOrDefault();

            var episode = new Episode
            {
                Title = episodeForm.Title,
                PlotSummary = episodeForm.PlotSummary,
                ImageUrl = episodeForm.ImageUrl,
                Length = episodeForm.Length,
                EpisodeAiredDate = episodeForm.EpisodeAiredDate,
                Storyline = episodeForm.Storyline,
                TVShowId = id
            };

            //var sth = data.TVShows.Select(x => new TVShow
            //{
            //    Title = tvshow.Title,
            //    PlotSummary = tvshow.PlotSummary,
            //    Length = tvshow.Length,
            //    Storyline = tvshow.Storyline,
            //    ReleaseDate = tvshow.ReleaseDate,
            //    ImageUrl = tvshow.ImageUrl
            //});

            tvshow.Episodes.Add(episode);

            data.Episodes.Add(episode);

            data.SaveChanges();

            return Redirect("/Episodes/All");
        }

        public IActionResult All(int id)
        {
            var tvshow = data.TVShows.Where(x => x.Id == id).FirstOrDefault();

            var all = data.Episodes
                .Where(e => e.TVShowId == id)
                .Select(e => new AllEpisodesQueryModel
                {
                    Id = e.Id,
                    Title = e.Title,
                    PlotSummary = e.PlotSummary,
                    ImageURL = e.ImageUrl,
                    EpisodeAiredDate = e.EpisodeAiredDate,
                    TVShowId = e.TVShowId
                })
                .ToList();

            return View(all);
        }

        public IActionResult Details(int id)
        {
            var episode = data.Episodes
                .Where(e => e.Id == id)
                .Select(e => new EpisodeDetails
                {
                    Id = e.Id,
                    Title = e.Title,
                    Length = e.Length,
                    PlotSummary = e.PlotSummary,
                    ImageURL = e.ImageUrl,
                    EpisodeAiredDate = e.EpisodeAiredDate,
                    Storyline = e.Storyline
                })
                .FirstOrDefault();

            //I Should add episode rating table and ratings column

            return View(episode);
        }

        public IActionResult Delete(int id)
        {
            var episode = data.Episodes.Where(t => t.Id == id)
                .FirstOrDefault();

            data.Episodes.Remove(episode);
            data.SaveChanges();

            return View(episode);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var episode = data.Episodes.Where(t => t.Id == id).FirstOrDefault();

            return View(episode);
        }


        [HttpPost]
        public IActionResult Edit(int tvshowId,Episode preEditedEpisode)
        {
            var postEditedEpisode = new Episode
            {
                Title = preEditedEpisode.Title,
                PlotSummary = preEditedEpisode.PlotSummary,
                ImageUrl = preEditedEpisode.ImageUrl,
                Length = preEditedEpisode.Length,
                EpisodeAiredDate = preEditedEpisode.EpisodeAiredDate,
                Storyline = preEditedEpisode.Storyline
            };

            var tvshow = data.TVShows.Where(x => x.Id == tvshowId).FirstOrDefault();

            data.TVShows.Update(tvshow);
            data.Episodes.Update(postEditedEpisode);

            data.SaveChanges();

            return Redirect("/Episodes/All");
            
        }
    }
}
