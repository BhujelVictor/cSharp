using System;

namespace StrategyPattern
{
    public interface QuackBehavior
    {
        void quack();
    }


    class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack!! Quack!!");
        }
    }

    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }

    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("No Sound");
        }
    }

    public interface FlyBehavior
    {
        public void fly();
    }

    class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Flap!Flap!Fly away.");
        }
    }

    class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Can't Fly.");
        }
    }
    class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Fly like a Rocket!!");
        }
    }

   
}