using System;
using PizzaStoreFactoryMethod;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        switch (type.ToLower())
        {
            case "cheese":
                return new ChicagoStyleCheesePizza();
            case "pepperoni":
                return new ChicagoStylePepperoniPizza();
            case "clam":
                return new ChicagoStyleClamPizza();
            default:
                throw new ArgumentException("Sorry we don't have that type of pizza.");
        }
    }
}