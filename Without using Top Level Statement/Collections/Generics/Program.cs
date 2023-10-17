using System;
using System.Collections.Generic;


namespace Gen
{
    public class Program
    {
        public struct Rectangle<T>
        {
            private T width;
            private T length;

            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public T Width
            {
                get { return width; }
                set { width = value; }
            }

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }
            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);
                return string.Format($"{Width} * {Length} = {dblLength * dblWidth}");

            }
        }

        public delegate void Arithmetic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public static void Substract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }



        static void Main(string[] args)
        {
            List<Generics> animalList = new List<Generics>();
            animalList.Add(new Generics() { Name = "Dawg" });
            animalList.Add(new Generics() { Name = "Paul" });
            animalList.Add(new Generics() { Name = "Jacky" });

            // Standard List
            List<int> numList = new();
            numList.Add(24);


            // Insert at specific index
            animalList.Insert(1, new Generics() { Name = "Hannibal" });

            // Remove at specific index
            animalList.RemoveAt(1);

            Console.WriteLine($"Num of Animals : {animalList.Count}");

            foreach (Generics z in animalList)
            {
                Console.WriteLine(z.Name);
            }

            int x = 5, y = 6;
            Generics.GetSum<int>(ref x, ref y);

            string string1 = "8", string2 = "9";
            Generics.GetSum<string>(ref string1, ref string2);

            double a = 5.00, b = 6.00;
            Generics.GetSum<double>(ref a, ref b);

            // Using struc
            Rectangle<int> rect1 = new(14, 12);
            Console.WriteLine(rect1.GetArea());

            Rectangle<string> rect2 = new("14", "12");
            Console.WriteLine(rect2.GetArea());

            // using delegate

            Arithmetic add, sub, addSub;

            // passing by ref method into objects
            add = new Arithmetic(Add);
            sub = new Arithmetic(Substract);
            addSub = add + sub;

            Console.WriteLine("Add 7 and 8 :");
            add(7, 8);
            Console.WriteLine("Add and then sub 12 and 8 :");
            addSub(12, 8);

        }

    }
}