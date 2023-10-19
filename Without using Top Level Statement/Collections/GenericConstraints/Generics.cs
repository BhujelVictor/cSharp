using System;
using System.Collections;
using ClassLibrary1;


namespace Test
{
    // Generic Class woth multiple generic constraints
    public class Generics< U, V>
    where U : Generics2
    where V : Generics3
    {
        public string Name { get; set; }
        public Generics(string name = "No Name") => Name = name;


        //Generic Method
        public void GetSum<T>(ref T num1, ref T num2)
        {
            double dblX = Convert.ToDouble(num1);
            double dblY = Convert.ToDouble(num2);
            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");

        }

    }
    public class Generics2
    {
        public double? Value { get; set; }

        public Generics2(double value = 1) => Value = value;

        public static void Swap<U>(ref U num1, ref U num2)
        {
            U temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"The values after swapped are : q = {num1} and w = {num2}");
        }
    }

    public class Generics3
    {
        public int Num { get; set; }
        int fact;

        public Generics3(int num = 1) => Num = num;

        public void Factorial(ref int number)
        {
            for (int i = number; i > 0; i--)
            {
                fact *= i;

            }
            Console.WriteLine($"The factorial of {number} is {fact}");
        }
    }
    public class DataStore<X> where X : class
        {
            public X? Data { get; set; }
        }

    public class DataStore1<X> where X : IEnumerable
        {
            public X? Data { get; set; }
        }

    public class DataStore2<X> where X : ArrayList
    {
        public X? Data { get; set; }
    }

    public class DataStore3<X> where X : ICalc
    {
        public X? Data { get; set; }
    }
}