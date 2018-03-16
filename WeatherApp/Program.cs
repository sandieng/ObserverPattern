using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnotherObserverPattern;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var simpleDisplay = new SimpleDisplay();
            var fullDisplay = new FullDisplay(weatherData);

            weatherData.SetMeasurements(25, 65.5f, 30.4f);

            Console.ReadKey();
        }
    }
}
