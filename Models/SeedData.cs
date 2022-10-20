﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.RestaurantReviews.Any())
                {
                    return;   // DB has been seeded
                }

                context.Restaurants.AddRange(
                    new Restaurant
                    {
                        Name = "Quandale Dingle",
                        Country = "USA",
                        City = "Florida"
                    },

                    new Restaurant
                    {
                        Name = "THK Söökla",
                        Country = "Eesti",
                        City = "Tallinn"
                    },

                    new Restaurant
                    {
                        Name = "Hesburger",
                        Country = "Mars",
                        City = "Mars crevise",
                        Reviews =
                            new List<RestaurantReview> {
                            new RestaurantReview { Rating = 9, Body="Great bulking food!"}
                    }
                });
                for (int i = 0; i < 1000; i++)
                {
                    context.Restaurants.AddRange(
                    new Restaurant
                    {
                        Name = $"{i}. eatery",
                        City = "Nowhere",
                        Country = "USA"
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
