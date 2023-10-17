using System;

namespace part11
{
    class Vehicle : IDrivable
   {
     public string Brand { get; set; }

     public Vehicle(string brand = "No Brand", int wheels = 0, double speed = 0)
     {
        Brand = brand;
        Wheels = wheels;
        Speed = speed;
     }

    public double Speed { get; set; }
    
    public int Wheels { get; set;}

    public void Move()
    {
        Console.WriteLine($"The {Brand} moves at the speed of {Speed}Km/Hr.");
    }  
    public void Stop()
    {
        Console.WriteLine($"The {Brand} stops");
        Speed = 0;
    }  


   } 
}