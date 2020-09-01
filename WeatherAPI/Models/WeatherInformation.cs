using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    [Table("Weather")]
    public class WeatherInformation
    {
        [Key]
        [Required]
        public int Id
        {
            get;
            set;
        }
        
        [Required]
        public String City
        {
            get;
            set;
        }

        [Required]
        public String Conditions
        {
            get;
            set;
        }

        [Range(-40,40)]
        public double MaxTemperature
        {
            get;
            set;
        }

        [Range(-40, 40)]
        public double MinTemperature
        {
            get;
            set;
        }

        [Required]
        public String WindDirection
        {
            get;
            set;
        }

        [Range(0,200)]
        public int WindSpeed
        {
            get;
            set;
        }

        [Required]
        public String Outlook
        {
            get;
            set;
        }

    }
}
