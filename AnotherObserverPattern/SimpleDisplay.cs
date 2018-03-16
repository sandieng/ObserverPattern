using System;

namespace AnotherObserverPattern
{
    public class SimpleDisplay : IObserver, IDisplay
    {
        private float _humidity;
        private float _pressure;
        private float _temperature;

        public void Display()
        {
            Console.WriteLine($"Simple display information {_temperature} Celcius");
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