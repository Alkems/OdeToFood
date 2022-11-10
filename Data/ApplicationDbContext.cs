using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public class ApplicationDbContext : IdentityDbContext<OdeToFoodUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<OdeToFood.Models.RestaurantReview> RestaurantReviews { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<OdeToFoodUser> OdeToFoodUsers { get; set; }
        public DbSet<OdeToFoodRole> OdeToFoodRoles { get; set; }
    }
}
