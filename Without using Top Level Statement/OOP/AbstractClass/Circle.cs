using System;

namespace part10
{
    class Circle :Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a radius of {Radius}.");
        }
    }
}