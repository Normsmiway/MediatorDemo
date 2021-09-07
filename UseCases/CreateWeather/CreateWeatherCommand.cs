using MediatR;
using System;

namespace MediatorDemo.UseCases.CreateWeather
{
    public class CreateWeatherCommand : IRequest<WeatherForecast>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public DateTime Date { get; }

        public int TemperatureC { get; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; }

        public CreateWeatherCommand(int tempC)
        {
            Date = DateTime.UtcNow;
            TemperatureC = tempC;
            Summary = Summaries[tempC];
        }
    }
}

