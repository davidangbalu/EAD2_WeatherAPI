using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using WeatherAPIClient.Annotations;

namespace WeatherAPIClient.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        private List<WeatherInformation> _WeatherInformation;

        public List<WeatherInformation> WeatherInformation
        {
            get { return _WeatherInformation;}
            set
            {
                _WeatherInformation = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            GetWeatherInformation();
        }
        private void GetWeatherInformation()
        {
            var weatherInfo = new List<WeatherInformation>
            {
                new WeatherInformation
                {
                    Id = 1, City = "Dublin", Conditions = "Sunny", MaxTemperature = 25, MinTemperature = 15, Outlook = "Cloudy", WindDirection = "East", WindSpeed = 140
                }
            };
            WeatherInformation = weatherInfo;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
