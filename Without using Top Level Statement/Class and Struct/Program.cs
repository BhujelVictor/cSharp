using System;

namespace part7
{
    class Program
    {


        struct Rectangle 
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1) { length = l; width = w; }
            public double Area()
            {
                return length * width;
            }



        }
        static void Main(string[] args)
        {
            // // using struct
            Rectangle rect1;
            rect1.length = 150;
            rect1.width = 30;
            Console.WriteLine($"Area of rect1 : {rect1.Area()}");
            Rectangle rect2 = new(200, 20);
            rect2 = rect1;
            rect1.length = 23;
            Console.WriteLine($"Rect2.length : {rect2.length}");
            Console.WriteLine($"Rect1.length : {rect1.length}");

            // using custom class
            Animal fox = new()
            {
                name = "Purple",
                sound = "Krrr"
            };

            Animal dog = new()
            {
                name = "Jacky",
                sound = "Woof!!Woof!!"
            };


            Console.WriteLine($"No. of Animals : {Animal.GetNumOfAnimal()}");

            Console.WriteLine($"Area of Rectangle : {ShapeMath.GetArea("Rectangle", 3, 4)}");
            Console.WriteLine($"Area of Triangle : {ShapeMath.GetArea("Triangle", 3, 4)}");
            Console.WriteLine($"Area of Circle : {ShapeMath.GetArea("Circle", 3, 4)}");
            dog.MakeSound();

            int? randNum = null;
            if (randNum == null)
            {
                Console.WriteLine("randNUm is null");
            }

            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum");
            }

        }

    }

}
