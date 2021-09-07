using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorDemo.UseCases.CreateWeather
{
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

