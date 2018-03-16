using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private float _humidity;
        private readonly List<IObserver> _observers;
        private float _pressure;
        private float _temperature;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void DeregisterObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(x => x.Update(_temperature, _humidity, _pressure));
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}