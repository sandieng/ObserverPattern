namespace DotNetObserverPattern
{
    public class WeatherData
    {
        public WeatherData(float temp, float hum, float press)
        {
            Temperature = temp;
            Humidity = hum;
            Presssure = press;
        }

        public float Temperature { get; }

        public float Humidity { get; }

        public float Presssure { get; }
    }
}
