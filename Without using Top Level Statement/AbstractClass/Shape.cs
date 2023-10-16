using System;

namespace part10
{
    abstract class Shape // cannot instanciate abstract class
    {
        public string Name { get; set; }
        
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        public abstract double Area();


    }
}