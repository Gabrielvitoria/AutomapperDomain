using AutomapperServices;
using AutomapperServices.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IWeatherForecastService weatherForecastService, ILogger<WeatherForecastController> logger)
        {
            _weatherForecastService = weatherForecastService;
            _logger = logger;

        }

        [HttpPost(Name = "PostWeatherForecast")]
        public IActionResult PostWeatherForecast([FromBody] CreateWeatherForecastDto createWeatherForecastDto)
        {
            try
            {
                return Ok(_weatherForecastService.PostWeatherForecast(createWeatherForecastDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                
            }
        }
    }
}
