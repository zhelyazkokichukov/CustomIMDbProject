using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Models.Movie
{
    public class MovieDetails
    {
        public MovieDetails()
        {
            Ratings = new List<double>();
        }
        public int Id { get; init; }

        public string Title { get; init; }

        public string PlotSummary { get; init; }

        public string Storyline { get; init; }

        public string Length { get; init; }

        public string ImageURL { get; init; }

        public string ReleaseDate { get; init; }

        public int Rate { get; init; }

        public List<double> Ratings { get; init; }
    }
}
