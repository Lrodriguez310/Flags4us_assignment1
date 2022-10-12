using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Flags4us_assignment1.Data;

namespace Flags4us_assignment1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFlagsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFlagsContext>>()))
            {
                // Look for any movies.
                if (context.Flags.Any())
                {
                    return;   // DB has been seeded
                }

                context.Flags.AddRange(
                    new Flags
                    {
                        ProductName = "New Orleans Flag",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Size = "Big",
                        Edible = "yes",
                        Review = "Excellent",
                        Color = "Purple",
                        Price = 200.00M
                    },

                    new Flags
                    {
                        ProductName = "Gumbo Flag",
                        ReleaseDate = DateTime.Parse("2004-5-17"),
                        Size = "Medium",
                        Edible = "yes",
                        Review = "Average",
                        Color = "Brown and White",
                        Price = 700.00M
                    },


                    new Flags
                    {
                        ProductName = "Conquer Flag",
                        ReleaseDate = DateTime.Parse("1995-6-10"),
                        Size = "small",
                        Edible = "No",
                        Review = "poor",
                        Color = "black and red",
                        Price = 90.50M
                    },


                    new Flags
                    {
                        ProductName = "Dominican Flag",
                        ReleaseDate = DateTime.Parse("1988-4-28"),
                        Size = "Enormous",
                        Edible = "NO",
                        Review = "Excellent",
                        Color = "White and Blue",
                        Price = 5000.99M
                    },

                    new Flags
                    {
                        ProductName = "Sandwich Flag",
                        ReleaseDate = DateTime.Parse("1949-2-22"),
                        Size = "Big",
                        Edible = "yes",
                        Review = "Excellent",
                        Color = "Brown",
                        Price = 20.00M
                    },

                    new Flags
                    {
                        ProductName = "Stone Flag",
                        ReleaseDate = DateTime.Parse("1789-9-13"),
                        Size = "Big",
                        Edible = "Maybe",
                        Review = "Excellent",
                        Color = "Grey",
                        Price = 6700.50M
                    },

                    new Flags
                    {
                        ProductName = "Lion Flag",
                        ReleaseDate = DateTime.Parse("1987-10-14"),
                        Size = "Big",
                        Edible = "No",
                        Review = "Excellent",
                        Color = "Yellow and Green",
                        Price = 2000.00M
                    },

                    new Flags
                    {
                        ProductName = "Tiger Flag",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Size = "Big",
                        Edible = "No",
                        Review = "Poor",
                        Color = "Orange",
                        Price = 1200.00M
                    },




                    new Flags
                    {
                        ProductName = "Pig Flag",
                        ReleaseDate = DateTime.Parse("2000-10-10"),
                        Size = "Medium",
                        Edible = "No",
                        Review = "Excellent",
                        Color = "Pink",
                        Price = 1500.00M
                    },

                    new Flags
                    {
                        ProductName = "Human Flag",
                        ReleaseDate = DateTime.Parse("1994-11-30"),
                        Size = "Big",
                        Edible = "yes",
                        Review = "poor",
                        Color = "Beige",
                        Price = 5200.00M
                    },

                    new Flags
                    {
                        ProductName = "Mexican Flag",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Size = "Big",
                        Edible = "No",
                        Review = "Excellent",
                        Color = "Grass Green",
                        Price = 1900.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}









//public class SeedData
// {


// }
//}
