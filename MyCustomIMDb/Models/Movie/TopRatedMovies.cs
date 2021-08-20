using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Models.Movie
{
    public class TopRatedMovies
    {
        public TopRatedMovies()
        {
            Ratings = new List<double>();
        }

        public string Title { get; init; }

        public string ReleaseDate { get; init; }

        public string Url { get; init; }

        public List<double> Ratings { get; init; }
    }
}
