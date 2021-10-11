using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Data.Models
{
    public class Photo
    {
        public int Id { get; init; }

        public string ImageUrl { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
