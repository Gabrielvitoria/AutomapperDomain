using AutoMapper;
using AutomapperDomain;
using AutomapperServices.Dto;

namespace AutomapperServices
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<WeatherForecastDto, WeatherForecast>();

            CreateMap<WeatherForecast, WeatherForecastDto>();


            CreateMap<CreateWeatherForecastDto, WeatherForecast>()
                    .ConstructUsing(x=> new WeatherForecast(x.Date, x.TemperatureC, x.Summary))
                    .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
