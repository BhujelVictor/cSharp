using System;

namespace ClassLibrary1
{
    public class Calculations1 : ICalc

    {
        public double FirstNum { get; set; }
        public double SecondNum { get; set; }


        public Calculations1(double x = 1, double y = 1)
        {
            FirstNum = x;
            SecondNum = y;

        }
        //Generic Method
        public static void GetSum<T>(ref T FirstNum, ref T SecondNum)
        {
            double dblX = Convert.ToDouble(FirstNum);
            double dblY = Convert.ToDouble(SecondNum);

            Console.WriteLine($"The sum is :{dblX + dblY}");

        }
        public void  Calculations(double FirstNum, double SecondNum)
        {
            double sum = FirstNum + SecondNum;
            Console.WriteLine($"The sum is :{sum}");
        }
    }

    public class Calculations2 : ICalc
    {
        public static void Swap<T>(ref T FirstNum, ref T SecondNum)
        {
            T temp = FirstNum;
            FirstNum = SecondNum;
            SecondNum = temp;
            Console.WriteLine($"The values after swapped are : q = {FirstNum} and w = {SecondNum}");
        }
        public void Calculations(double FirstNum, double SecondNum)
        {
            double diff = FirstNum - SecondNum;
            Console.WriteLine($"The difference is :{diff}");
        }
    }

    public class Calculations3 : ICalc
    {

        public void  Calculations(double FirstNum, double SecondNum)
        {
            double prod = FirstNum * SecondNum;
            Console.WriteLine($"The product is :{prod}");
        }
    }

    public interface ICalc
    {

        void Calculations(double FirstNum, double SecondNum);


    }



    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string? str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }
    }

}

