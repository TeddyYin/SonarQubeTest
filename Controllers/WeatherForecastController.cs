using Microsoft.AspNetCore.Mvc;

namespace SonarQubeTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            int[] numbers = { 10, 5, 0, 8 };

            // �o�Ӱj��|�b�J�� 0 �ɲ��Ϳ��~
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var calculationResult = DivideNumbers(numbers[i], numbers[i + 1]);
            }

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// Divide Numbers
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public double DivideNumbers(int numerator, int denominator)
        {
            // �o�̨S���ˬd���ƬO�_���s�A�|�ɭP�B��ɿ��~
            double result = numerator / denominator;
            return result;
        }
    }
}
