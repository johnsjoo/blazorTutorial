using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WeatherDataManagement.Models;

namespace WeatherDataManagement.Web.Pages
{
    public class BaseWeatherDataList : ComponentBase
    {
        public IEnumerable<WeatherData> Weatherdatas { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadWeatherData();
            return base.OnInitializedAsync();
        }
        private void LoadWeatherData()
        {
            WeatherData w1 = new WeatherData
            {
                Id = 1,
                Temp = 24.5F,
                Humidity = 48,
                DateAndTime = new DateTime(2020, 01,01),
                Location = "Inne"
            };
            WeatherData w2 = new WeatherData
            {
                Id = 2,
                Temp = 25.5F,
                Humidity = 12,
                DateAndTime = new DateTime(2020, 02, 01),
                Location = "Inne"

            };
            WeatherData w3 = new WeatherData
            {
                Id = 3,
                Temp = 14.5F,
                Humidity = 34,
                DateAndTime = new DateTime(2020, 03, 01),
                Location = "Inne"

            };

            Weatherdatas = new List<WeatherData> { w1, w2, w3 };
        }
    }
}
