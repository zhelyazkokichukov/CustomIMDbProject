using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Models
{
    using static Data.DataConstants.Movie;
    public class TVShowFormModel
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
        [Range(MinYearReleaseDate, MaxYearReleaseDate)]

        public string ReleaseDate { get; init; }

        [Required]
        [RegularExpression("[1-9][1-9]*h [0-9][0-9]*min", ErrorMessage = "Lenght should be in format 1h 21min")]
        public string Length { get; init; }

        [Required]
        [StringLength(StorylineMaxLength, MinimumLength = StorylineMinLength, ErrorMessage = "Storyline must be between 50 and 1500 characters")]
        public string Storyline { get; init; }
    }
}
