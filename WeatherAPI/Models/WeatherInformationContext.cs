using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WeatherAPI.Models
{
    public class WeatherInformationContext : DbContext
    {
        public WeatherInformationContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<WeatherInformation> WeatherInformation { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<WeatherInformation>().HasData(
        //        new WeatherInformation
        //        {
        //            Id = 1,
        //            City = "Dublin",
        //            Conditions = "Sunny",
        //            MaxTemperature = 24,
        //            MinTemperature = 16,
        //            WindDirection = "North",
        //            WindSpeed = 120,
        //            Outlook = "Cloudy"
        //        },

        //        new WeatherInformation
        //        {
        //            Id = 2,
        //            City = "London",
        //            Conditions = "Cloudy",
        //            MaxTemperature = 20,
        //            MinTemperature = 12,
        //            WindDirection = "North",
        //            WindSpeed = 140,
        //            Outlook = "Sunny"
        //        },

        //        new WeatherInformation
        //        {
        //            Id = 3,
        //            City = "Spain",
        //            Conditions = "Sunny",
        //            MaxTemperature = 29,
        //            MinTemperature = 20,
        //            WindDirection = "South",
        //            WindSpeed = 60,
        //            Outlook = "Sunny"
        //        },

        //        new WeatherInformation
        //        {
        //            Id = 4,
        //            City = "Berlin",
        //            Conditions = "Overcast",
        //            MaxTemperature = 20,
        //            MinTemperature = 12,
        //            WindDirection = "South",
        //            WindSpeed = 112,
        //            Outlook = "Cloudy"
        //        },

        //        new WeatherInformation
        //        {
        //            Id = 5,
        //            City = "Amsterdam",
        //            Conditions = "Rain",
        //            MaxTemperature = 21,
        //            MinTemperature = 14,
        //            WindDirection = "East",
        //            WindSpeed = 120,
        //            Outlook = "Drizzle"
        //        },

        //        new WeatherInformation
        //        {
        //            Id = 6,
        //            City = "Tokyo",
        //            Conditions = "Drizzle",
        //            MaxTemperature = 19,
        //            MinTemperature = 11,
        //            WindDirection = "East",
        //            WindSpeed = 120,
        //            Outlook = "Rain"
        //        },

        //        new WeatherInformation
        //        {
        //            Id = 7,
        //            City = "Vancouver",
        //            Conditions = "Snow",
        //            MaxTemperature = -10,
        //            MinTemperature = -14,
        //            WindDirection = "West",
        //            WindSpeed = 12,
        //            Outlook = "Fog"
        //        },

        //        new WeatherInformation
        //        {
        //            Id = 8,
        //            City = "Toronto",
        //            Conditions = "Fog",
        //            MaxTemperature = 10,
        //            MinTemperature = 0,
        //            WindDirection = "West",
        //            WindSpeed = 30,
        //            Outlook = "Overcast"
        //        });
        //}
    }
}
