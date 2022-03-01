using Microsoft.EntityFrameworkCore;



namespace CelestesFavouriteMusicians.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CelestesFavouriteMusiciansContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CelestesFavouriteMusiciansContext>>()))
            {
                if (context == null || context.Musicians == null)
                {
                    throw new ArgumentNullException("Null CelestesFavouriteMusiciansContext");
                }

                // Look for any movies.
                if (context.Musicians.Any())
                {
                    return;   // DB has been seeded
                }

                context.Musicians.AddRange(
                    new Musicians
                    {
                        Name = "Taylor Swift",
                        Birthday = DateTime.Parse("1989-12-13"),
                        NumberOfAlbums = 9,
                        NumberOfAwards = 324
                    },

                    new Musicians
                    {
                        Name = "Ariana Grande",
                        Birthday = DateTime.Parse("1993-6-26"),
                        NumberOfAlbums = 6,
                        NumberOfAwards = 186
                    },

                    new Musicians
                    {
                        Name = "Selena Gomez",
                        Birthday = DateTime.Parse("1992-7-22"),
                        NumberOfAlbums = 3,
                        NumberOfAwards = 131
                    },

                    new Musicians
                    {
                        Name = "Katy Perry",
                        Birthday = DateTime.Parse("1984-10-25"),
                        NumberOfAlbums = 6,
                        NumberOfAwards = 106
                    },

                    new Musicians
                    {
                        Name = "Miley Cyrus",
                        Birthday = DateTime.Parse("1992-11-23"),
                        NumberOfAlbums = 7,
                        NumberOfAwards = 63
                    },

                    new Musicians
                    {
                        Name = "Christina Aguilera",
                        Birthday = DateTime.Parse("1980-12-18"),
                        NumberOfAlbums = 8,
                        NumberOfAwards = 227
                    }
                );
                context.SaveChanges();
            }
        }
    }
}