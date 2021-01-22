using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherDataManagement.Models;



namespace WeatherDataManagement.Api.Models
{
    public class WeatherDataRepository : IWeatherDataRepository
    {
        private readonly AppDbContext appDbContext;

        public WeatherDataRepository(AppDbContext appDbContext) 
        {
            this.appDbContext = appDbContext;
        }
        public async Task<WeatherData> GetWeather(int wDataId)
        {
            return await appDbContext.WeatherData.FirstOrDefaultAsync(w => w.Id == wDataId);
        }

        public async Task<IEnumerable<WeatherData>> GetWeathers()
        {
            return await appDbContext.WeatherData.ToListAsync();
        }
    }
}
