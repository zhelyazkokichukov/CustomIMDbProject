using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Data.Models
{
    public class MovieRating
    {
        public int Id { get; init; }

        public double Rating { get; set; }
    }
}
