using System;

namespace StrategyPattern
{
    //Composition
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new Quack(),new FlyWithWings())
        {
        }

        public override void Display()
        {
            Console.WriteLine("It's a Mallard duck");
        }
    }
    public class ModelDuck : Duck
    {
        public ModelDuck() : base(new Quack(), new FlyNoWay())
        {

        }

        public override void Display()
        {
            Console.WriteLine("Its a test model duck.");
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck() :base(new Squeak(), new FlyNoWay())
        {

        }

        public override void Display()
        {
            Console.WriteLine("It's a Rubber ducky.");
        }
    }


}