using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Models.TVShow
{
    using static Data.DataConstants.Movie;

    public class EpisodeFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; init; }

        [Required]
        [StringLength(PlotSummaryMaxLength, MinimumLength = PlotSummaryMinLength)]
        public string PlotSummary { get; init; }

        [Required]
        [Url(ErrorMessage = "Please enter a valid url")]
        public string ImageUrl { get; init; }

        [Required]
        [RegularExpression("Episode aired [A-Z]{1}[a-z]{2} [0-9]+[0-9]*, [0-9]{4}", ErrorMessage = "Episode aired date must be in format Episode aired May 2, 2011")]
        public string EpisodeAiredDate { get; init; }

        [Required]
        [RegularExpression("[1-9][1-9]*h [0-9][0-9]*min", ErrorMessage = "Lenght should be in format 1h 21min")]
        public string Length { get; init; }

        [Required]
        [StringLength(StorylineMaxLength, MinimumLength = StorylineMinLength, ErrorMessage = "Storyline must be between 50 and 1500 characters")]
        public string Storyline { get; init; }

        public int TVShowId { get; init; }
    }
}
