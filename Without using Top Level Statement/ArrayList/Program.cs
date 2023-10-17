using System;
using System.Collections;
using System.Collections.Generic;


namespace space
{
    public class Program
    {


        static void Main(string[] args)
        {
            // ArrrayList can hold different types of data 
            //Can be modified using index unlike array
            // Allows dynamic allocation of memory
            #region  ArrayList Code 
            ArrayList aList = new();

            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine($"Count : {aList.Count}");
            Console.WriteLine($"Capacity : {aList.Capacity}");

            ArrayList aList2 = new();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            aList.AddRange(aList2);

            aList2.Sort();
            aList2.Reverse();

            aList2.Insert(0, "Hydra");

            // aList.RemoveAt(0);
            // aList.RemoveRange(0, 2);

            Console.WriteLine($"Hydra at Index : {aList2.IndexOf("Hydra")}");

            foreach (object o in aList2)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\n");

            // Casting arraylist into string array
            string[] myArray = (string[])aList2.ToArray(typeof(string));
            foreach (string o in aList2)
            {
                
                Console.WriteLine($"{o}");
            }

            Console.WriteLine("\n");

            string[] customers = { "Harry", "Selena", "Patrick" };

            ArrayList custArrayList = new();
            custArrayList.AddRange(customers);

            foreach (string o in custArrayList)
            {
                
                Console.WriteLine($"{o}");
            }




            #endregion
        }
    }
}
