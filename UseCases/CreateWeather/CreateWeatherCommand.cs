using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

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


    internal sealed class CreateWeatherCommandHandler : IRequestHandler<CreateWeatherCommand, WeatherForecast>
    {

        public async Task<WeatherForecast> Handle(CreateWeatherCommand request, CancellationToken cancellationToken)
        {
            return new WeatherForecast()
            {
                Date = request.Date,
                Summary = request.Summary,
                TemperatureC = request.TemperatureC
            };
        }
    }
}

