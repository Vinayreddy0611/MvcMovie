using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Raktacharithra",
                    ReleaseDate = DateTime.Parse("15-04-2013"),
                    Genre = "Horror Thriller",
                    Price = 6.85M
                },
                new Movie
                {
                    Title = "Oppenheimer ",
                    ReleaseDate = DateTime.Parse("21-07-2023"),
                    Genre = "Biopic Drama",
                    Price = 39.29M
                },
                new Movie
                {
                    Title = "I saw the Devil",
                    ReleaseDate = DateTime.Parse("30-05-2010"),
                    Genre = "Psycho thriller",
                    Price = 12.24M
                },
                new Movie
                {
                    Title = "Dabbe the possession",
                    ReleaseDate = DateTime.Parse("15-04-2013"),
                    Genre = "Horror Thriller",
                    Price = 6.85M
                },
                 new Movie
                 {
                     Title = "Inglourious basterds",
                     ReleaseDate = DateTime.Parse("21-08-2009"),
                     Genre = "Adventure Drama",
                     Price = 15.95M
                 }
            ); ;
            context.SaveChanges();
        }
    }
}