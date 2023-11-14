using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange(
                    new Movies
                    {
                        Title = "When Harry Met Sally",
                        ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRJe1KrV-dJmTCTJRwULmoXKXOENQYKuon-t1UFmHUUwLnjGOO7",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "G"
                        
                    },
                    new Movies
                    {
                        Title = "Ghostbusters ",
                        ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTPhes93YSmsg5bt_S5eOdxaWoMPDiZDJsv5LidaN50xv1wPgbQ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG",

                    },

                    new Movies
                    {
                        Title = "Ghostbusters 2",
                        ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcR13CoyScmJ7INyuF4FdSbD1O1gD6vNixAmyK4qDJXu-F27_zkT",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG"

                    },

                    new Movies
                    {
                        Title = "Rio Bravo",
                        ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRpEcFEab7tb3FHDXv4Ytn1SNtU4BpDLtQi3-3Baina1rqcQv5_",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "PG13"
                    }
                );
                context.SaveChanges();
            }
            
            
   
        }
    }
}
