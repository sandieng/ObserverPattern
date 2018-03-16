using System;

namespace DotNetObserverPattern
{
    public class WeatherProvider : IObserver<WeatherData>
    {
        private IDisposable _unsubscriber;
        private readonly string _tvChannel;

        public WeatherProvider(string tvChannel)
        {
            _tvChannel = tvChannel;
        }

        public void OnNext(WeatherData value)
        {
            Console.WriteLine($"{_tvChannel} weather: Temperature {value.Temperature}, Pressure {value.Presssure}, Humidty {value.Humidity}");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"Received an error {error.Message}");
            
        }

        public void OnCompleted()
        {
            Console.WriteLine("Additional temperature data will not be transmitted.");
        }

        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
                _unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}
