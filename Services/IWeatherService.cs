using System.Collections.Generic;

namespace MediatorDemo.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> Get();
    }

}
