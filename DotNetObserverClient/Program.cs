using DotNetObserverPattern;
using System;

namespace DotNetObserverClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherSubscriber subscriber = new WeatherSubscriber();
            WeatherProvider channel7 = new WeatherProvider("Channel 7");
            channel7.Subscribe(subscriber);
            WeatherProvider cnn = new WeatherProvider("CNN");
            cnn.Subscribe(subscriber);
            WeatherProvider mouseTv = new WeatherProvider("Mouse TV");
            mouseTv.Subscribe(subscriber);
            subscriber.SetMeasurements(new WeatherData(10, 7, 14));
            mouseTv.Unsubscribe();
            subscriber.SetMeasurements(new WeatherData(28, 26, 14));
            subscriber.SetMeasurements(null);

            Console.Read();
        }
    }
}
