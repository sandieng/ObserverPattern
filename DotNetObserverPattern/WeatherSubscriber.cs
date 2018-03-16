using System;
using System.Collections.Generic;

namespace DotNetObserverPattern
{
    public class WeatherSubscriber : IObservable<WeatherData>
    {
        private readonly List<IObserver<WeatherData>> _observers;
        public WeatherSubscriber()
        {
            _observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            return new Unsubscriber(_observers, observer);
        }

        public void SetMeasurements(WeatherData weather)
        {
            foreach (var observer in _observers)
            {
                if (weather == null)
                    observer.OnError(new ApplicationException());
                else
                    observer.OnNext(weather);
            }
        }
    }

    public class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<WeatherData>> _observers;
        private readonly IObserver<WeatherData> _observer;

        public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
