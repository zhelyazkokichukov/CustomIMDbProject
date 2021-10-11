using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCustomIMDb.Data.Models
{
    using static DataConstants.Movie;

    public class Movie
    {
        public Movie()
        {
            MovieGenres = new HashSet<MovieGenre>();
            MovieCastAndCrew = new HashSet<MovieCastAndCrew>();
            MovieRating = new HashSet<MovieRating>();
            PhotoGallery = new HashSet<Photo>();
        }

        [Key]
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

        public ICollection<MovieGenre> MovieGenres { get; set; }

        public ICollection<MovieCastAndCrew> MovieCastAndCrew { get; set; }

        public ICollection<MovieRating> MovieRating { get; set; }

        public ICollection<Photo> PhotoGallery { get; set; }
    }
}