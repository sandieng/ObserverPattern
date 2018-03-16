using System;
using ObserverPattern;

namespace WeatherStation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var simple = new SimpleDisplay();
            var full = new FullDisplay();

            // Register some observers
            weatherData.RegisterObserver(simple);
            weatherData.RegisterObserver(full);

            // Change the weather and get notified
            weatherData.SetMeasurements(25, 65.5f, 30.4f);

            // Deregister one observer
            weatherData.DeregisterObserver(simple);

            // Change the weather and notify the remaining observer
            weatherData.SetMeasurements(-1, 1f, 2f);
            
            // Deregister the last observer and change the weather
            weatherData.DeregisterObserver(full);
            weatherData.SetMeasurements(100, 100f, 100f);

            Console.ReadKey();
        }
    }
}