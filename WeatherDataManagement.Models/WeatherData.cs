using System;

namespace WeatherDataManagement.Models
{
    public class WeatherData
    {
        public int Id { get; set; }
        public float Temp { get; set; }
        public float Humidity { get; set; }
        public DateTime  DateAndTime { get; set; }
        public string Location { get; set; }

    }
}
