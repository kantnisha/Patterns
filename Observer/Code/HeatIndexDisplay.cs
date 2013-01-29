using System;
using Observer.Interface;

namespace Observer.Code
{
    public class HeatIndexDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private float _humidity;
        private float _heatIndex;
        private ISubject _weatherData;

        public HeatIndexDisplay(ISubject wearherData)
        {
            _weatherData = wearherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _heatIndex = _temperature*humidity;
            Display();

        }

        public void Display()
        {
            Console.WriteLine("Heat index is {0}", _heatIndex);
        }
    }
}