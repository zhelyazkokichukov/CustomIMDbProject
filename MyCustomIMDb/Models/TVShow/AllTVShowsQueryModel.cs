using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Models.TVShow
{
    public class AllTVShowsQueryModel
    {
        public int Id { get; init; }

        public string Title { get; init; }

        public string PlotSummary { get; init; }

        public string ImageURL { get; init; }

        public string ReleaseDate { get; init; }
    }
}
