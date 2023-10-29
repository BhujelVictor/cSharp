using System;
using System.Collections.Generic;


namespace Calc
{
    interface ICalculable
    {
        double GetArea();
        double GetVolume();

    }

    public class Rectangle : ICalculable
    {
        public double Length { get; set; }
        public double Breadth { get; set; }


        public double GetArea()
        {
            return Length * Breadth;
        }
        public double GetVolume()
        {
            return 0; // Volume for Rectangle does not exist
        }

    }
    public class Triangle : ICalculable
    {
        public double Base { get; set; }
        public double Height { get; set; }


        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
        public double GetVolume()
        {
            return 0; // Volume for Triangle does not exist
        }

    }

    public class Pyramid : ICalculable
    {
        public double Perimeter { get; set; }
        public double SlantHeight { get; set; }
        public double BaseArea { get; set; }


        public double GetArea()
        {
            return 0.5 * Perimeter * SlantHeight + BaseArea;
        }
        public double GetVolume()
        {
            return (BaseArea * SlantHeight) / 3;
        }

    }

    public class MyClass
    {}

    class Calculator<T> where T : ICalculable
    {
        static List<ICalculable> sumList = new()
        {
                new Rectangle() { Length = 34, Breadth = 27 },
                new Triangle() { Base  = 34, Height = 29 },
                new Pyramid() { Perimeter = 34, SlantHeight = 23 , BaseArea = 64}
                
        };
        

        public static double SumArea()
        {
            double sumA = 0;
            foreach(ICalculable o in sumList)
            {
                sumA += o.GetArea();
            }
            return sumA;
        }

        public static double SumVolume()
        {
            double sumB = 0;
            foreach(ICalculable o in sumList)
            {
                sumB += o.GetVolume();
            }
            return sumB;
        }
        
    }

    class Program
    {
        public static void Main(string[] args)
        {
            double SumOfArea =Calculator<ICalculable>.SumArea();
            
            Console.WriteLine($"SumOfArea : {SumOfArea}");

            double VolumeofArea = Calculator<ICalculable>.SumVolume();
            
            Console.WriteLine($"VolumeofArea : {VolumeofArea}");
        }
    }
}
