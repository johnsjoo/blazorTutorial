using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherDataManagement.Models;

namespace WeatherDataManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WeatherData>().HasData(new WeatherData
            {
                Id = 1,
                Temp = 24.5F,
                Humidity = 48,
                DateAndTime = new DateTime(2020, 01, 01),
                Location = "Inne"
            });
            modelBuilder.Entity<WeatherData>().HasData(new WeatherData
            {
                Id = 2,
                Temp = 25.5F,
                Humidity = 12,
                DateAndTime = new DateTime(2020, 02, 01),
                Location = "Inne"
            });
            modelBuilder.Entity<WeatherData>().HasData(new WeatherData
            {
                Id = 3,
                Temp = 14.5F,
                Humidity = 34,
                DateAndTime = new DateTime(2020, 03, 01),
                Location = "Inne"
            });
            
        }
        public DbSet<WeatherData> WeatherData { get; set; }

    }
}
