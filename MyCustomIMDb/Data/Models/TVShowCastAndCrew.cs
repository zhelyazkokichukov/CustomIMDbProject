using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Data.Models
{
    public class TVShowCastAndCrew
    {
        public int Id { get; init; }

        public int TVShowId { get; set; }

        public TVShow TVShow { get; set; }

        public int CastAndCrewId { get; set; }

        public CastAndCrew CastAndCrew { get; set; }
    }
}
