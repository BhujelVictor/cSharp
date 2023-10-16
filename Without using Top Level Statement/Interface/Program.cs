using System;

namespace part11
{
    class Program
   {
     



     static void Main(string[] args)
     {
        Vehicle audi = new("Audi", 4, 350);
        if (audi is IDrivable)
        {
            audi.Move();
            audi.Stop();
            Console.WriteLine($"Speed : {audi.Speed}");
        }
        else Console.WriteLine($"The {audi.Brand} cannot be driven.");
     }
   } 
}