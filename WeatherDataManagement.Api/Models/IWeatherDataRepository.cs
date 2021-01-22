using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherDataManagement.Models;

namespace WeatherDataManagement.Api.Models
{
    public interface IWeatherDataRepository
    {
        Task<IEnumerable<WeatherData>> GetWeathers();

        Task<WeatherData> GetWeather(int wDataId);

    }
}
