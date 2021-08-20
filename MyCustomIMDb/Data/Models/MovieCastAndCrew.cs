using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Data.Models
{
    public class MovieCastAndCrew
    {
        public int Id { get; init; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int CastAndCrewId { get; set; }

        public CastAndCrew CastAndCrew { get; set; }
    }
}
