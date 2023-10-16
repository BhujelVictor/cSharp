using System;

namespace part5
{
    public class Program
    {
        // ***Test function
        // static double GetSum(double x = 1, double y = 1)
        // {
        //     double temp = x;
        //     x = y;
        //     y = temp;
        //     return x + y;
        // }

        // static void Main(string[] args)
        // {
        //     double x = 5;
        //     double y = 4;
        //     Console.WriteLine($"5 + 4 = {GetSum(x, y)}");
        //     Console.WriteLine($"x = {x} and y = {y}");

        // }

        // *****out parameter allows to assign param value 'y' inside the function

        // static void DoubleIt(int x, out int y)
        // {

        //     y = x * 2;
        // }

        // static void Main(string[] args)
        // {
        //     DoubleIt(12, out int y);
        //     Console.WriteLine($"12 * 2 = {y}");


        // }

        //  static void DoubleIt(int x, out int y)
        // {

        //     y = x * 2;
        // }


        // // pass by reference changes the value outside the funtion
        // // passes the address of the value rather than the value 

        // public static void Swap(ref int num3, ref int num4)
        // {
        //     int temp = num3;
        //     num3 = num4;
        //     num4 = temp;
        // }


        // static void Main(string[] args)
        // {
        //     int num3 = 12;
        //     int num4 = 14;
        //     Console.WriteLine($"Before Swap num1 : {num3} and num2 : {num4}");
        //     Swap(ref num3, ref num4);
        //     Console.WriteLine($"After swap num1 : {num3} and num2 : {num4}");


        // }

        // // Varaible parameter to accept unknown no. of variable

        // static double GetSumMore(params double[] nums)
        // {
        //     double sum = 0;
        //     foreach (double i in nums)
        //     {
        //         sum += i;
        //     }
        //     return sum;
        // }

        // static void Main(string[] args)
        // {


        //     Console.WriteLine($"Sum = {GetSumMore(8,9,0.9)}");


        // }



        // // Named parameters

        // static void PrintInfo(string name, int zipCode)
        // {
        //     Console.WriteLine($"{name} lives in the zip code area : {zipCode}");
        // }

        // static void Main(string[] args)
        // {

        //     PrintInfo(zipCode : 1234556, name : "Harry"); 
        //     // passing by name so order doesnt matter
        // }

        // Method overloading 
        //to accept both double and string args

        static double GetSum1(double x, double y)
        {
            return x + y;
        }

        static double GetSum1(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($" Sum of 2.5 & 3.5 : {GetSum1(2.5, 3.5)}");
            Console.WriteLine($" Sum of string : {GetSum1("2.5", "3.5")}");

        }

    }
}