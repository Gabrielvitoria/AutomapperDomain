using AutoMapper;
using AutomapperDomain;
using AutomapperServices.Dto;

namespace AutomapperServices
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IMapper _mapper;

        public WeatherForecastService(IMapper mapper)
        {
            _mapper = mapper;     
        }

        public WeatherForecastDto PostWeatherForecast(CreateWeatherForecastDto createWeatherForecastDto)
        {
            var newEntityWeatherForecast = _mapper.Map<WeatherForecast>(createWeatherForecastDto);
                 

            return _mapper.Map<WeatherForecastDto>(newEntityWeatherForecast);
        }
    }
}
