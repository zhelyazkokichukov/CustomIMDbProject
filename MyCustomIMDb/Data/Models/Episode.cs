using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Data.Models
{
    using static DataConstants.Movie;
    public class Episode
    {
        public Episode()
        {
            Ratings = new HashSet<MovieRating>();
            CastAndCrew = new HashSet<CastAndCrew>();
        }

        public int Id { get; init; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        public string PlotSummary { get; set; }

        [Required]
        public string EpisodeAiredDate { get; set; }

        [Required]
        public string Length { get; set; }

        [Required]
        public string Storyline { get; set; }

        public string ImageUrl { get; set; }

        public int TVShowId { get; set; }

        public TVShow TVShow { get; set; }

        public ICollection<CastAndCrew> CastAndCrew { get; set; }

        public ICollection<MovieRating> Ratings { get; set; }
    }
}
