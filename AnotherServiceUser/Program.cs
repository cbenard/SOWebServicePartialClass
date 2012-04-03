using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceProject.WeatherService;

namespace AnotherServiceUser
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new WeatherSoapClient();
            var weatherReturn = service.GetCityWeatherByZIP("75074");

            Console.WriteLine("City length from partial: " + weatherReturn.CityLength);

            Console.ReadLine();
        }
    }
}
