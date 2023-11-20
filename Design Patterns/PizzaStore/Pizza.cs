using System;

namespace PizzaStoreFactoryMethod
{
    public abstract class Pizza
    {
        public string? Name { get; protected set; }
        public string? Dough { get; protected set; }
        public string? Sauce { get; protected set; }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
        }
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 min at 350 degree Fareinheit");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cut the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Pack the pizza into the official PizzaStore box");
        }
    }
}