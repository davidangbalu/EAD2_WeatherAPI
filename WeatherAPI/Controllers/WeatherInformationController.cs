using System.Collections.Generic;
using WeatherAPI.Models;
using WeatherAPI.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Hosting;



namespace WeatherAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherInformationController : ControllerBase
    {
        private readonly WeatherInformationContext _context;

        public WeatherInformationController(WeatherInformationContext context)
        {
            _context = context;

            if (!_context.WeatherInformation.Any())
            {
                var weather1 = new WeatherInformation
                {
                    Id = 1,
                    City = "Dublin",
                    Conditions = "Sunny",
                    MaxTemperature = 24,
                    MinTemperature = 16,
                    WindDirection = "North",
                    WindSpeed = 120,
                    Outlook = "Cloudy"
                };

                var weather2 = new WeatherInformation
                {
                    Id = 2,
                    City = "London",
                    Conditions = "Cloudy",
                    MaxTemperature = 20,
                    MinTemperature = 12,
                    WindDirection = "North",
                    WindSpeed = 140,
                    Outlook = "Sunny"
                };

                var weather3 = new WeatherInformation
                {
                    Id = 3,
                    City = "Spain",
                    Conditions = "Sunny",
                    MaxTemperature = 29,
                    MinTemperature = 20,
                    WindDirection = "South",
                    WindSpeed = 60,
                    Outlook = "Sunny"
                };

                var weather4 = new WeatherInformation
                {
                    Id = 4,
                    City = "Berlin",
                    Conditions = "Overcast",
                    MaxTemperature = 20,
                    MinTemperature = 12,
                    WindDirection = "South",
                    WindSpeed = 112,
                    Outlook = "Cloudy"
                };

                var weather5 = new WeatherInformation
                {
                    Id = 5,
                    City = "Amsterdam",
                    Conditions = "Rain",
                    MaxTemperature = 21,
                    MinTemperature = 14,
                    WindDirection = "East",
                    WindSpeed = 120,
                    Outlook = "Drizzle"
                };

                var weather6 = new WeatherInformation
                {
                    Id = 6,
                    City = "Tokyo",
                    Conditions = "Drizzle",
                    MaxTemperature = 19,
                    MinTemperature = 11,
                    WindDirection = "East",
                    WindSpeed = 120,
                    Outlook = "Rain"
                };

                var weather7 = new WeatherInformation
                {
                    Id = 7,
                    City = "Vancouver",
                    Conditions = "Snow",
                    MaxTemperature = -10,
                    MinTemperature = -14,
                    WindDirection = "West",
                    WindSpeed = 12,
                    Outlook = "Fog"
                };

                var weather8 = new WeatherInformation
                {
                    Id = 8,
                    City = "Toronto",
                    Conditions = "Fog",
                    MaxTemperature = 10,
                    MinTemperature = 0,
                    WindDirection = "West",
                    WindSpeed = 30,
                    Outlook = "Overcast"
                };

                _context.WeatherInformation.Add(
                    weather1
                );
                _context.WeatherInformation.Add(
                    weather2
                );
                _context.WeatherInformation.Add(
                    weather3
                );
                _context.WeatherInformation.Add(
                    weather4
                );
                _context.WeatherInformation.Add(
                    weather5
                );
                _context.WeatherInformation.Add(
                    weather6
                );
                _context.WeatherInformation.Add(
                    weather7
                );
                _context.WeatherInformation.Add(
                    weather8
                );
                _context.SaveChanges();
            }
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<WeatherInformation>>> GetAllWeather()
        {
            return await _context.WeatherInformation.ToListAsync();
        }

        [HttpGet("{searchString}")]
        public async Task<ActionResult<IEnumerable<WeatherInformation>>> GetWeatherFromCity(string searchString)
        {
            var city = await _context.WeatherInformation.Where(c => c.City.ToUpper().Contains(searchString.ToUpper())).ToListAsync();

            if (city.Count.Equals(0))
            {
                return NotFound();
            }
            else if (searchString == null)
            {
                city = await _context.WeatherInformation.ToListAsync();
            }
            return city;
        }
    }



}
