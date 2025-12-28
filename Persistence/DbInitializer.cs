using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
namespace Persistence;
public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (!context.Activities.Any())
        {
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Description = "Activity 1 months ago",
                    Category = "drinks",
                    Date = DateTime.Now.AddMonths(-2),
                    City = "London",
                    Venue = "Pub",
                    Latitude = "51.5074 N",
                    Longitude = "0.1278 W"
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Description = "Activity 1 month in future",
                    Category = "culture",
                    Date = DateTime.Now.AddMonths(1),
                    City = "Paris",
                    Venue = "Louvre",
                    Latitude = "48.8566 N",
                    Longitude = "2.3522 E"
                }
            };

            context.Activities.AddRange(activities);
            await context.SaveChangesAsync();
        }
    }
}