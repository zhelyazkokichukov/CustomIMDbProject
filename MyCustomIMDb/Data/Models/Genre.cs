using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Data.Models
{
    using static DataConstants;
    public class Genre
    {
        public Genre()
        {
            MovieGenres = new HashSet<MovieGenre>();
        }

        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(GenreNameMaxLength)]
        public string Name { get; set; }

        public ICollection<MovieGenre> MovieGenres {get; set;}
    }
}
