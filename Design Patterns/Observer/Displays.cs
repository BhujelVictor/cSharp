using System;

namespace WeatherORama
{
    public interface IDisplayElement
    {
        public void Display();
    }

    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
        
        public void Display()
        {
            Console.WriteLine($"Current Conditions : Temp = {temperature} degree celcius and  Humidity = {humidity}%");
        }
    }

    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperature;

        public ForecastDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            Display();
        }

        public void Display()
        {
            if (temperature > 36)
            {
                Console.WriteLine($"Temperature is: {temperature}degree Celcius.And it's quite hot today");
            }
            else if( temperature <= 36 && temperature > 20)
            {
                Console.WriteLine($"Temperature is: {temperature}degree Celcius.And it's the perfect weather");
            }
            else
            {
                Console.WriteLine($"Temperature is: {temperature}degree Celcius.And it's quite cold today");
            }
            
        }
    }

    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;

        public StatisticsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Average temperature: {temperature}degree Celcius.");
        }
    }
}