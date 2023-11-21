using System;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";

        }
        public override double Cost()
        {
            return 1.99;
        }
    }
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";

        }
        public override double Cost()
        {
            return 1.98;
        }
    }
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";

        }
        public override double Cost()
        {
            return 2.13;
        }
    }
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";

        }
        public override double Cost()
        {
            return 1.78;
        }
    }

    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
        public override double Cost()
        {
            return beverage.Cost() + .20;
        }
    }
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
        public override double Cost()
        {
            return beverage.Cost() + .15;
        }
    }

    public class StarBuzzCafe
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");


        }
    }
}