using System;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string? name;
        public string? dough;
        public string? sauce;
        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
        }
        public void Bake()
        {
            Console.WriteLine("Bake for 25 min at 350 degree Fareinheit");
        }
        public void Cut()
        {
            Console.WriteLine("Cut the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Pack the pizza into the official PizzaStore box \n");
        }
    }
    
    
}