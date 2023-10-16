using System;

namespace part10
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Shape[] shapes = {(new Circle(7)), (new Rectangle(4, 6))};

            foreach (Shape s in shapes)
            {
                s.GetInfo();

                Console.WriteLine($"Area of {s.Name} : {s.Area():f}");

                Circle testCirc = s as Circle;

                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle.");
                }

                if (s is Circle)
                {
                    Console.WriteLine("This is'nt a Rectangle");
                }
            }
            
            object circ1 = new Circle(4);

            Circle circ2 = (Circle)circ1;
            Console.WriteLine($"Area of {circ2.Name} is {circ2.Area()}");

             

            // Circle A = new(7);
            // Console.WriteLine($"It has an area of {A.Area()}");
            // A.GetInfo();
        }
    }
}