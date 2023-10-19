using System;
using System.Collections.Generic;
using System.Collections;
using ClassLibrary1;





namespace Test
{
    class Program
    {


        static void Main(string[] args)
        {
            // when generic constraint class is used
            DataStore<string> store = new();
            DataStore<IEnumerable> storex1 = new();
            DataStore<ArrayList> store2 = new();
            DataStore<Generics2> store3 = new();
            // DataStore<int> store5 = new(); // only reference type can be passed

            // when generic constraint interface : IEnumerable is used

            DataStore1<string> store4 = new();
            DataStore1<IEnumerable> store5 = new();
            DataStore1<ArrayList> store6 = new();
            // DataStore1<Generics2> store7 = new(); // must be derived form the base class used
            // DataStore<int> store8 = new(); // must be derived form the base class used


            // when generic constraint base class that implements IEnumerable interface: ArrayList is used

            DataStore2<ArrayList> store11 = new();
            // // must be derived form the base class used
            // DataStore2<string> store9 = new();
            // DataStore2<IEnumerable> store10 = new();
            // DataStore2<Generics2> store12 = new(); 
            // DataStore2<int> store13 = new(); 


            // Generic constraint base class : Generics
            Generics<Generics2, Generics3> testGen = new();
            List<Generics<Generics2, Generics3>> qwe = new()
            {
                new Generics<Generics2, Generics3>() {Name = "Apple"},
                new Generics<Generics2, Generics3>() {Name = "Peach"}
            };

            Console.WriteLine($"{qwe.GetType()}");


            // Generic Methods
            int i = 23;
            int j = 24;
            testGen.GetSum<int>(ref i, ref j);

            double q = 12.89;
            double w = 12.11;
            Generics2.Swap<double>(ref q, ref w);

            List<Generics2> nValues = new()
            {
                new Generics2() { Value = 1 },
                new Generics2() { Value = 2 },
                new Generics2() { Value = 3 }
            };

            foreach (Generics2 z in nValues)
            {
                Console.WriteLine(z.Value);
            }


            // Generic constraint using custom  class library and using ICalc as a base interface for multiple class
            DataStore3<Calculations1> dummyVar = new();
            DataStore3<Calculations2> dummyVar1 = new();
            DataStore3<Calculations3> dummyVar2 = new();
            //Type argument must be from the derived Class in class library
            // DataStore3<ArrayList> dummyVar3 = new();
            // DataStore3<string> dummyVar4 = new();
            // DataStore3<IEnumerable> dummyVar5= new();
            // DataStore3<Generics2> dummyVar6= new(); 
            // DataStore3<int> dummyVar7 = new();
          
            int x = 5, y = 6;
            Calculations1.GetSum<int>(ref x, ref y);

            double a = 5.00, b = 6.00;
            Calculations1.GetSum<double>(ref a, ref b);
            
            Calculations2.Swap<double>(ref a, ref b);



            // Checking String using class library
            Console.WriteLine($"String check......Enter a string : ");
            string? input = Console.ReadLine();
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Begins with uppercase? {(input.StartsWithUpper() ? "Yes" : "No")}");
       

            
        }

    }
}