using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using WeatherAPI.Models.Repository;


namespace WeatherAPI.Models.DataManager
{
    public class WeatherManager : IDataRepository<WeatherInformation>
    {
        readonly WeatherInformationContext _weatherContext;

        public WeatherManager(WeatherInformationContext context)
        {
            _weatherContext = context;
        }

        public IEnumerable<WeatherInformation> GetAll()
        {
            return _weatherContext.WeatherInformation.ToList();

        }

        //public WeatherInformation Get(int id)
        //{
        //    return _weatherContext.WeatherInformation.FirstOrDefault(w => w.Id == id);
        //}

        public WeatherInformation GetWeatherCity(String city)
        {
            return _weatherContext.WeatherInformation.FirstOrDefault(w => w.City.ToUpper() == city.ToUpper());
            
        }

        
    }
}
