using System;

namespace FactoryPattern
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "Cheese Pizza";
            dough = "Regular Crust";
            sauce = "Marinara Pizza Sauce";
        }
    }
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "Pepperoni Pizza";
            dough = "Crust";
            sauce = "Marinara sauce";
        }
    }
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            name = "Clam Pizza";
            dough = "Thin crust";
            sauce = "White garlic sauce";
        }
    }
}