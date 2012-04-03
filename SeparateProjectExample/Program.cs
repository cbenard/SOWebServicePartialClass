using System;
using ServiceProject.WeatherService;

namespace SeparateProjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new WeatherSoapClient();
            var weatherReturn = service.GetCityWeatherByZIP("75074");

            Console.WriteLine("City length from partial: " + weatherReturn.CityLength);
        }
    }
}
