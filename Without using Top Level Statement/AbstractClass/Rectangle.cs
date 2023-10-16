using System;

namespace part10
{
    class Rectangle :Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rectangle(double length, double breadth)
        {
            Name = "Rectangle";
            Length = length;
            Breadth = breadth;
        }

        public override double Area()
        {
            return Length * Breadth;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a length of {Length} and breadth of {Breadth}.");
        }
    }
}