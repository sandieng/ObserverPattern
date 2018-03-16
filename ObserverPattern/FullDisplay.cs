using System;

namespace ObserverPattern
{
    public class FullDisplay : IObserver, IDisplay
    {
        private float _humidity;
        private float _pressure;
        private float _temperature;

//        public FullDisplay(ISubject weatherData)
//        {
//            weatherData.RegisterObserver(this);
//        }

        public void Display()
        {
            Console.WriteLine(
                $"Full display: {_temperature} Celcius, humidity {_humidity}, pressure {_pressure}");
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