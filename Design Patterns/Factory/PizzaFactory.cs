using System;
using FactoryPattern;

public class PizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        switch (type.ToLower())
        {
            case "cheese":
                return new CheesePizza();
            case "pepperoni":
                return new PepperoniPizza();
            case "clam":
                return new ClamPizza();
            default:
                throw new ArgumentException("Sorry we don't sell that type of pizza.");
        }
    }
}