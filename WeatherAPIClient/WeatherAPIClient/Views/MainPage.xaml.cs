using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherAPIClient
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    var WeatherInformation = new List<WeatherInformation>
        //    {
        //        new WeatherInformation
        //        {
        //            Id = 1, City = "Dublin", Conditions = "Sunny", MaxTemperature = 25, MinTemperature = 15, Outlook = "Cloudy", WindDirection = "East", WindSpeed = 140 
        //        }
        //    };

        //    WeatherInformationView.ItemsSource = WeatherInformation;
        //}
    }
}
