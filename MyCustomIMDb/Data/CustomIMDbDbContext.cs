using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCustomIMDb.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomIMDb.Data
{
    public class CustomIMDbDbContext : IdentityDbContext
    {
        public CustomIMDbDbContext(DbContextOptions<CustomIMDbDbContext> options)
            : base(options)
        {
        }

        public DbSet<Genre> Genres { get; init; }

        public DbSet<Movie> Movies { get; init; }

        public DbSet<CastAndCrew> CastAndCrew { get; init; }

        public DbSet<MovieCastAndCrew> MovieCastAndCrew { get; init; }

        public DbSet<MovieGenre> MovieGenres { get; init; }

        public DbSet<MovieRating> MovieRatings { get; init; }

        public DbSet<TVShow> TVShows { get; init; }

        public DbSet<Episode> Episodes { get; init; }

        public DbSet<TVShowCastAndCrew> TVShowCastAndCrew { get; init; }

        public DbSet<Photo> PhotoGallery { get; init; }
    }
}
