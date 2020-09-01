using System;

namespace WeatherAPIClient
{
    
    public class WeatherInformation
    {
        
        public int Id
        {
            get;
            set;
        }
        
        public String City
        {
            get;
            set;
        }

        public String Conditions
        {
            get;
            set;
        }

        public double MaxTemperature
        {
            get;
            set;
        }

        public double MinTemperature
        {
            get;
            set;
        }

        public String WindDirection
        {
            get;
            set;
        }

        public int WindSpeed
        {
            get;
            set;
        }

       public String Outlook
        {
            get;
            set;
        }

    }
}
