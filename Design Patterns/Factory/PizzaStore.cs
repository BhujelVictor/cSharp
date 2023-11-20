using System;

namespace FactoryPattern
{
    public class PizzaStore
    {
        private readonly PizzaFactory factory;

        public PizzaStore(PizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }
    }
}