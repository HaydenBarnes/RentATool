using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RentATool1.Data;
using System;
using System.Linq;

namespace RentATool1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RentAToolContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RentAToolContext>>()))
            {
                // Look for any movies.
                if (context.Tool.Any())
                {
                    return;   // DB has been seeded
                }

                context.Tool.AddRange(
                    new Tool
                    {
                        Name = "Air Compressor",
                        Category = "General",
                        Brand = "Dewalt",
                        Price = 7.99M
                    },

                    new Tool
                    {
                        Name = "Table Saw",
                        Category = "Woodworking",
                        Brand = "Saw Stop",
                        Price = 7.99M
                    },

                    new Tool
                    {
                        Name = "Lawn Mower",
                        Category = "Garden",
                        Brand = "Toro",
                        Price = 7.99M
                    },

                    new Tool
                    {
                        Name = "Engine Lift",
                        Category = "Auto",
                        Brand = "Unknown",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}