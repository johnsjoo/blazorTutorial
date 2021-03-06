﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherDataManagement.Api.Models;
using WeatherDataManagement.Models;

namespace WeatherDataManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherDataController : ControllerBase
    {
        private readonly IWeatherDataRepository weatherDataRepository;

        public WeatherDataController(IWeatherDataRepository weatherDataRepository) 
        {
            this.weatherDataRepository = weatherDataRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetWeatherData()
        {
            try
            {
                return Ok(await weatherDataRepository.GetWeathers());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<WeatherData>> GetWeather(int id) 
        {
            try
            {
                var result = await weatherDataRepository.GetWeather(id);
                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from database");
            }
        }
            
    }
}
