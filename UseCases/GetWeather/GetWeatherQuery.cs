using MediatR;

namespace MediatorDemo.UseCases.GetWeather
{
    public class GetWeatherQuery : IRequest<WeatherForecast>
    {
        public string Summary { get; }
        public GetWeatherQuery(string summary)
        {
            Summary = summary;
        }
    }
}
