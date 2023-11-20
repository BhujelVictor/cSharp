using System;
using PizzaStoreFactoryMethod;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        switch (type.ToLower())
        {
            case "cheese":
                return new NYStyleCheesePizza();
            case "pepperoni":
                return new NYStylePepperoniPizza();
            case "clam":
                return new NYStyleClamPizza();
            default:
                throw new ArgumentException("Sorry we don't have that type of pizza.");
        }
    }
}