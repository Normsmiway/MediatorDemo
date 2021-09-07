using MediatorDemo.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorDemo.UseCases.GetWeathers
{
    internal sealed class GetWeathersQueryHandler : IRequestHandler<GetWeathersQuery, IEnumerable<WeatherForecast>>
    {
        private readonly IWeatherService _service;
        public GetWeathersQueryHandler(IWeatherService service)
        {
            _service = service;
        }
        public async Task<IEnumerable<WeatherForecast>> Handle(GetWeathersQuery request, CancellationToken cancellationToken)
        {
            return await Task.Run(() => { return _service.Get(); });
        }
    }
}
