using System;

namespace Singleton
{
    // Simple implementation of Singleton
    // public class Singleton
    // {
    //     private static Singleton? UniqueInstance;

    //     private Singleton() {}

    //     public static Singleton GetInstance()
    //     {
    //         if (UniqueInstance == null)
    //         {
    //             UniqueInstance = new Singleton();
    //         }
    //         return UniqueInstance;
    //     }
    // }

    // ChocolateBoiler controller class using singleton
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        
        private static ChocolateBoiler? UniqueInstance;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        public static ChocolateBoiler GetInstance()
        {
            if (UniqueInstance == null)
            {
                UniqueInstance = new ChocolateBoiler();
            }
            return UniqueInstance;
        }
        
        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
                Console.WriteLine("filling the boiler with a milk/chocolate mixture");
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
               empty = true;
               Console.WriteLine("drain the boiled milk and chocolate");
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                boiled = true;
                Console.WriteLine("Boiling the contents");
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }
        public bool IsBoiled()
        {
            return boiled;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();

            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance(); // Gets the existing instance of the class

        }
    }
}