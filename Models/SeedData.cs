using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

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
                    Title = "The RM",
                    ReleaseDate = DateTime.Parse("2003-1-31"),
                    Genre = Genre.Comedy,
                    Rating = "PG",
                    Price = 7.99M,
                    ImageName = "the_rm",
                },
                new Movie
                {
                    Title = "The Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("2001-12-14"),
                    Genre = Genre.Drama,
                    Rating = "PG",
                    Price = 8.99M,
                    ImageName = "the_other_side_of_heaven",
                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-10-10"),
                    Genre = Genre.Documentary,
                    Rating = "PG",
                    Price = 9.99M,
                    ImageName = "meet_the_mormons",
                }
            );
            context.SaveChanges();
        }
    }
}