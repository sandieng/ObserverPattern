using System;

namespace ObserverPattern
{
    public class SimpleDisplay : IObserver, IDisplay
    {
        private float _humidity;
        private float _pressure;
        private float _temperature;

//        public SimpleDisplay(ISubject weatherData)
//        {
//            weatherData.RegisterObserver(this);
//        }

        public void Display()
        {
            Console.WriteLine($"Simple display: {_temperature} Celcius");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}