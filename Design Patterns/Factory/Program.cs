using System;

namespace FactoryPattern{
public class Program
{
    static void Main(string[] args)
    {
        PizzaFactory factory = new PizzaFactory();
        PizzaStore store = new PizzaStore(factory);

        Pizza pizza = store.OrderPizza("Cheese");
        Console.WriteLine("Here's an order of " + pizza.name + "\n");

        pizza = store.OrderPizza("Pepperoni");
        Console.WriteLine("Here's an order of " + pizza.name + "\n");
    }
}
}
