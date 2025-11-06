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
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Check if the DB already has movies
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "NR"
                    },
                    new Movie
                    {
                        Title = "FROM",
                        ReleaseDate = DateTime.Parse("2022-2-20"),
                        Genre = "Horror/Mystery",
                        Price = 8.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "King of Boys",
                        ReleaseDate = DateTime.Parse("2018-8-26"),
                        Genre = "Thriller/Crime",
                        Price = 12.99M,
                        Rating = "PG 18"
                    },
                    new Movie
                    {
                        Title = "Squid Game",
                        ReleaseDate = DateTime.Parse("2021-9-17"),
                        Genre = "Thriller/Horror",
                        Price = 7.99M,
                        Rating = "PG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
