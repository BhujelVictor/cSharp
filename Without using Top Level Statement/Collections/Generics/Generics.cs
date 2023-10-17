using System;
using System.Collections;

namespace Gen
{
    class Generics
    {
        public string Name { get; set; }
        public Generics(string name = "No Name") => Name = name;

        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double dblX = Convert.ToDouble(num1);
            double dblY = Convert.ToDouble(num2);
            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
            
        }

    }
}