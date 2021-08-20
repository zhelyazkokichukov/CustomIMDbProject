using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Data.Models
{
    using static DataConstants;
    public class CastAndCrew
    {
        public CastAndCrew()
        {
            Filmography = new HashSet<MovieCastAndCrew>();
            TvShows = new HashSet<TVShowCastAndCrew>();
        }

        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(ActorNameMaxLength)]
        public string FirstName { get; set; }

        [MaxLength(ActorNameMaxLength)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(ActorNameMaxLength)]
        public string LastName { get; set; }
              
        public string ImageUrl { get; set; }
       
        public int Age { get; set; }
        
        [Required]
        public string MiniBio { get; set; }

        [Required]
        public CrewRole CrewRole { get; set; }

        public ICollection<MovieCastAndCrew> Filmography { get; set; }

        public ICollection<TVShowCastAndCrew> TvShows { get; set; }
    }
}
