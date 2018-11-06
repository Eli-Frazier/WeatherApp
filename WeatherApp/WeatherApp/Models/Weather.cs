using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Models
{
    class Weather
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string CurrentWeather { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string WeatherDetails { get; set; }
        public string Icon { get; set; }

        public Weather()
        {
            //Because labels bind to these values, set them to an empty string to               
            //ensure that the label appears on all platforms by default.               
            Title = " ";
            Temperature = " ";
            Wind = " ";
            Humidity = " ";
            CurrentWeather = " ";
            Sunrise = " ";
            Sunset = " ";
            WeatherDetails = " ";
            Icon = " ";
        }

    }
}
