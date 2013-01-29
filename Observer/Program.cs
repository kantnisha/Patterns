using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer.Code;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionasDisplay(weatherData);
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurement(80, 45,34);
            weatherData.SetMeasurement(56, 33, 23);
            weatherData.SetMeasurement(11, 45, 55);

            Console.ReadKey();
        }
    }
}
