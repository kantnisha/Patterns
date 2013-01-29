using System;
using Observer.Interface;

namespace Observer.Code
{
    public class CurrentConditionasDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionasDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity", _temperature, _humidity);
        }
    }
}