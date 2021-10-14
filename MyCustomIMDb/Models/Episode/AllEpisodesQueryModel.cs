using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Models.Episode
{
    public class AllEpisodesQueryModel
    {
        public int Id { get; init; }

        public string Title { get; init; }

        public string PlotSummary { get; init; }

        public string ImageURL { get; init; }

        public string EpisodeAiredDate { get; init; }

        public int TVShowId { get; init; }
    }
}
