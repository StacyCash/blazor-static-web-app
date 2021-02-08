using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace BlazorTestApi
{
    public static class WeatherForcast
    {
        [FunctionName("WeatherFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "weather-forecast")] HttpRequest req,
            ILogger log)
        {
            return new OkObjectResult(GetWeather());
        }

        private static WeatherReading[] GetWeather()
        {
            return new WeatherReading[]
            {
                new WeatherReading
                {
                    Date = new DateTime(2018, 05, 06),
                    Summary = "Freezing",
                    TemperatureC = 1
                },
                new WeatherReading
                {
                    Date = new DateTime(2018, 05, 07),
                    Summary = "Bracing",
                    TemperatureC = 14
                },
                new WeatherReading
                {
                    Date = new DateTime(2018, 05, 08),
                    Summary = "Freezing",
                    TemperatureC = -13
                },
                new WeatherReading
                {
                    Date = new DateTime(2018, 05, 09),
                    Summary = "Balmy",
                    TemperatureC = -16
                },
                new WeatherReading
                {
                    Date = new DateTime(2018, 05, 10),
                    Summary = "Chilly",
                    TemperatureC = 1
                },
            };


        }
    }
}

struct WeatherReading
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }
}