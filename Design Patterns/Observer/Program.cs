using System;
using System.Collections;
using System.Collections.Generic;

namespace WeatherORama
{
    
    public class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new();

            // Registering observer
            
            CurrentConditionDisplay currentDisplay = new(weatherData); 

            ForecastDisplay forecastDisplay = new(weatherData);

            StatisticsDisplay statisticsDisplay = new(weatherData);

            //Setting object data
            weatherData.SetMeasurement(34.23f,67.34f,89.12f);

        }
    }
}