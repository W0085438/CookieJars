using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using CookieJars.Data;

namespace CookieJars.Models
{
    public class SeedData //Class used to insert initial test data into database
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CookieJarsContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<CookieJarsContext>>()))
            {
                // Look for Cookie Jars
                if (context.Jars.Any())
                {
                    return; //DB has been seeded
                }

                context.Jars.AddRange(
                    new Jars
                    {
                        ProductImage = "",
                        Name = "Who's TARDIS?",
                        Material = "Porcelin",
                        Coating = "Acrylic",
                        Rarity = "Very Rare",
                        Price = 1100,
                        Rating = 5
                    },

                    new Jars
                    {
                        ProductImage = "",
                        Name = "The Golden Ticket",
                        Material = "Porcelin",
                        Coating = "Glaze",
                        Rarity = "Rare",
                        Price = 220,
                        Rating = 4
                    },

                    new Jars
                    {
                        ProductImage = "",
                        Name = "Peanut-ty",
                        Material = "Ceramic",
                        Coating = "Acrylic",
                        Rarity = "Common",
                        Price = 48,
                        Rating = 4
                    },

                    new Jars
                    {
                        ProductImage = "",
                        Name = "The Boba",
                        Material = "Ceramic",
                        Coating = "Glaze",
                        Rarity = "Uncommon",
                        Price = 90,
                        Rating = 5
                    },

                    new Jars
                    {
                        ProductImage = "",
                        Name = "Cooookiieee!",
                        Material = "Porcelin",
                        Coating = "Acrylic",
                        Rarity = "Uncommon",
                        Price = 80,
                        Rating = 4
                    },

                    new Jars
                    {
                        ProductImage = "",
                        Name = "Ohana",
                        Material = "Porcelin",
                        Coating = "Acrylic",
                        Rarity = "Common",
                        Price = 75,
                        Rating = 3
                    },

                    new Jars
                    {
                        ProductImage = "",
                        Name = "Scooby Snacks",
                        Material = "Porcelin",
                        Coating = "Glaze",
                        Rarity = "Common",
                        Price = 79,
                        Rating = 4
                    },

                    new Jars
                    {
                        ProductImage = "",
                        Name = "Oscar's Trash",
                        Material = "Epoxy Resin",
                        Coating = "Acrylic",
                        Rarity = "Uncommon",
                        Price = 80,
                        Rating = 3
                    },

                    new Jars
                    {
                        ProductImage = "",
                        Name = "Baby Noms",
                        Material = "Porcelin",
                        Coating = "Acrylic",
                        Rarity = "Common",
                        Price = 67,
                        Rating = 4
                    },

                    new Jars
                    {
                        ProductImage = "",
                        Name = "Spidey Treats",
                        Material = "Ceramic",
                        Coating = "Acrylic",
                        Rarity = "Rare",
                        Price = 300,
                        Rating = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
