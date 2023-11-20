using System;
using PizzaStoreFactoryMethod;

public class Program
{
    static void Main(string[] args)
    {
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine("You ordered a " + pizza.Name + "\n");

        pizza = chicagoStore.OrderPizza("cheese");
        Console.WriteLine("You ordered a " + pizza.Name + "\n");
    }
}