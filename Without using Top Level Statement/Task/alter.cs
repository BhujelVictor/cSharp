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

        List<ICalculable> shapes = new();

        public void AddShape(ICalculable shape)
        {
            shapes.Add(shape);
        }

        public double SumArea()
        {
            double sum = 0;
            foreach (ICalculable shape in shapes)
            {
                sum += shape.GetArea();
            }
            return sum;
        }
        
        public double SumVolume()
        {
            double sum = 0;
            foreach (ICalculable shape in shapes)
            {
                sum += shape.GetVolume();
            }
            return sum;
        }
        
        
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Calculator<ICalculable> calculator = new();

            calculator.AddShape(new Rectangle() { Length = 34, Breadth = 27 });
            calculator.AddShape(new Triangle() { Base  = 34, Height = 29 });
            calculator.AddShape(new Pyramid() { Perimeter = 34, SlantHeight = 23 , BaseArea = 64});

            Console.WriteLine($"Total Area = {calculator.SumArea()}");
            Console.WriteLine($"Total Volume = {calculator.SumVolume()}");
            
        }
    }
}