using MediatorDemo.Services;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorDemo.UseCases.GetWeather
{
    internal sealed class GetWeatherQueryHandler : IRequestHandler<GetWeatherQuery, WeatherForecast>
    {
        private readonly IWeatherService _service;
        public GetWeatherQueryHandler(IWeatherService service)
        {
            _service = service;
        }
        public async Task<WeatherForecast> Handle(GetWeatherQuery query, CancellationToken cancellationToken)
        {
            return _service.Get().FirstOrDefault(w => w.Summary.Equals(query.Summary));
        }
    }
}
