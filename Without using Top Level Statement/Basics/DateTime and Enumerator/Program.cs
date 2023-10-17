using System;

namespace part6
{
    public class Program
    {


        // DateTime manipulation

        // static void Main(string[] args)
        // {
        //     DateTime awesomeDate = new(1980,12,20);
        //     Console.WriteLine($"Day of the week is {awesomeDate.DayOfWeek}.");
            
        //     awesomeDate = awesomeDate.AddDays(2);
        //     awesomeDate = awesomeDate.AddMonths(1);
        //     awesomeDate = awesomeDate.AddYears(1);
        //     Console.WriteLine($"New Date : {awesomeDate.Date}");

        //     TimeSpan lunchTime = new(12, 30, 0);
        //     lunchTime = lunchTime.Subtract(new TimeSpan(0, 20, 0));
        //     Console.WriteLine($"New Time : {lunchTime}");

        // }


        // Using enumerator to initialize value in key value pair
        static void PaintCar(CarColor cc)
        {
            Console.WriteLine($"The car was painted {cc} with code {(int)cc}");
        }


        enum CarColor : byte
        {
            Orange,
            Red,
            Blue,
            Violet
        }

        static void Main(string[] args)
        {
            CarColor car = CarColor.Violet;
            PaintCar(car);
        }

    }
}