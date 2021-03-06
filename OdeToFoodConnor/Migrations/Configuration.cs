
using OdeToFoodConnor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFoodConnor.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFoodConnor.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
               new Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
               new Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
               new Restaurant
               {
                   Name = "Smaka",
                   City = "Gothenburg",
                   Country = "Sweden",
                   Reviews =
                       new List<RestaurantReview> { 
                       new RestaurantReview { Rating = 9, Body="Great food!", ReviewerName="Connor"}
                   }
               });
        }
    }
