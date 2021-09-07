using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MediatorDemo.UseCases.GetWeather;
using MediatorDemo.UseCases.GetWeathers;
using MediatorDemo.UseCases.CreateWeather;

namespace MediatorDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IMediator _mediator;
        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _mediator.Send(new GetWeathersQuery());
        }

        [HttpGet("single")]
        public async Task<WeatherForecast> Get([FromQuery] string summary)
        {
            return await _mediator.Send(new GetWeatherQuery(summary));
        }

        [HttpPost]
        public async Task<WeatherForecast> CreateNew(CreateWeatherRequest request)
        {
            if (request.Temperature > 9)
                return null;
        
            return await _mediator.Send(new CreateWeatherCommand(request.Temperature));
        }



    }
    public class CreateWeatherRequest
    {
        public int Temperature { get; set; }
    }
}
