using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Data.Models
{
    using static DataConstants.Movie;
    public class TVShow
    {
        public TVShow()
        {
            Episodes = new HashSet<Episode>();
            Ratings = new HashSet<MovieRating>();
            CastAndCrew = new HashSet<TVShowCastAndCrew>();
        }

        public int Id { get; init; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        public string PlotSummary { get; set; }

        [Required]
        public string ReleaseDate { get; set; }

        [Required]
        public string Length { get; set; }

        [Required]
        public string Storyline { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Episode> Episodes { get; set; }
              
        public ICollection<MovieRating> Ratings { get; set; }
              
        public ICollection<TVShowCastAndCrew> CastAndCrew { get; set; }

    }
}
