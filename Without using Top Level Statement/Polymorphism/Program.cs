using System;

namespace Polymorphism
{
    //********Method Overloading
    // class Printdata
    // {
    //     void Print(int i)
    //     {
    //         Console.WriteLine($"Printing int: {i}");
    //     }

    //     void Print(double f)
    //     {
    //         Console.WriteLine($"Printing float: {f}");
    //     }

    //     void Print(string s)
    //     {
    //         Console.WriteLine($"Printing string: {s}");
    //     }

    //     static void Main(string[] args)
    //     {

    //         Printdata p = new();

    //         p.Print(5);
    //         p.Print(500.263);
    //         p.Print("Overloaded Method");
    //     }
    // }

//**** Operator Overloading
class Box
{
    private double length;   
    private double breadth;  
    private double height;  

    public double GetVolume()
    {
        return length * breadth * height;
    }
    public void SetLength(double len)
    {
        length = len;
    }
    public void SetBreadth(double bre)
    {
        breadth = bre;
    }
    public void SetHeight(double hei)
    {
        height = hei;
    }

    // Overload + operator to add two Box objects.
    public static Box operator +(Box b, Box c)
    {
            Box box = new()
            {
                length = b.length + c.length,
                breadth = b.breadth + c.breadth,
                height = b.height + c.height
            };
            return box;
    }
}
class Tester
{
    static void Main(string[] args)
    {
        Box Box1 = new();  
        Box Box2 = new();   
        Box Box3 = new();   
        double volume = 0.0;    


        Box1.SetLength(6.0);
        Box1.SetBreadth(7.0);
        Box1.SetHeight(5.0);


        Box2.SetLength(12.0);
        Box2.SetBreadth(13.0);
        Box2.SetHeight(10.0);

        volume = Box1.GetVolume();
        Console.WriteLine($"Volume of Box1 : {volume}");


        volume = Box2.GetVolume();
        Console.WriteLine($"Volume of Box1 : {volume}");

        // Adding the properties of two objects
        Box3 = Box1 + Box2;


        volume = Box3.GetVolume();
        Console.WriteLine($"Volume of Box1 : {volume}");

    }
}


}