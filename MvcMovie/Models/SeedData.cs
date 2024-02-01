using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
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
                        ReleaseDate = DateTime.ParseExact("15-04-2013", "dd-MM-yyyy", null),
                        Genre = "Horror Thriller",
                        Rating = "A",
                        Price = 6.85M
                    },
                    new Movie
                    {
                        Title = "Oppenheimer ",
                        ReleaseDate = DateTime.ParseExact("21-07-2023", "dd-MM-yyyy", null),
                        Genre = "Biopic Drama",
                        Rating = "R",
                        Price = 39.29M
                    },
                    new Movie
                    {
                        Title = "I saw the Devil",
                        ReleaseDate = DateTime.ParseExact("30-05-2010", "dd-MM-yyyy", null),
                        Genre = "Psycho thriller",
                        Rating = "A",
                        Price = 12.24M
                    },
                    new Movie
                    {
                        Title = "Dabbe the possession",
                        ReleaseDate = DateTime.ParseExact("15-04-2013", "dd-MM-yyyy", null),
                        Genre = "Horror Thriller",
                        Rating = "u/a",
                        Price = 6.85M
                    },
                    new Movie
                    {
                        Title = "Inglourious basterds",
                        ReleaseDate = DateTime.ParseExact("21-08-2009", "dd-MM-yyyy", null),
                        Genre = "Adventure Drama",
                        Rating = "A",
                        Price = 15.95M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
