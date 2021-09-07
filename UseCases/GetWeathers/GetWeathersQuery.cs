using MediatR;
using System.Collections.Generic;

namespace MediatorDemo.UseCases.GetWeathers
{
    public class GetWeathersQuery : IRequest<IEnumerable<WeatherForecast>>
    {
    }
}
