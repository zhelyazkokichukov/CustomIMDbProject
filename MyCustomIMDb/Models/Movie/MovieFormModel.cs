using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Models.Movie
{
    using static Data.DataConstants.Movie;
    public class MovieFormModel
    { 
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; init; }

        [Required]
        [StringLength(PlotSummaryMaxLength, MinimumLength = PlotSummaryMinLength)]
        public string PlotSummary { get; init; }

        [Required]
        public string ImageUrl { get; init; }

        [Required]
        public string ReleaseDate { get; init; }

        [Required]
        public string Length { get; init; }

        [Required]
        public string Storyline { get; init; }
    }
}
