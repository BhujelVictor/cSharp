using System;
namespace StrategyPattern
{
    public abstract class Duck
    {
        
   
        QuackBehavior quackBehavior;
        FlyBehavior flyBehavior;

        protected Duck(QuackBehavior quackBehavior, FlyBehavior flyBehavior)
        {
            this.quackBehavior = quackBehavior;
            this.flyBehavior = flyBehavior;
        }

       
        public abstract void Display();

        public void PerformFlight()
        {
            flyBehavior.fly();
        }

        public void PerformQuack()
        {
            quackBehavior.quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        
        public void QuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    
    }

    public class MiniDuckSimulator
    {
        public static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFlight();

            Duck model = new ModelDuck();
            model.Display();
            model.PerformQuack();
            model.PerformFlight();

            model.SetFlyBehavior(new FlyRocketPowered());// changing behavior at runtime
            model.PerformFlight();

            Duck TestRubberDuck = new RubberDuck();
            TestRubberDuck.Display();
            TestRubberDuck.PerformQuack();
            TestRubberDuck.PerformFlight();

        }
    }
}