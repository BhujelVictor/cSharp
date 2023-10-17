using System;
using System.Collections.Generic;

namespace qwe
{
    class Dictionaries
    {


        static void Main(string[] args)
        {
            Dictionary<string, string> superheroes = new()
            {
                { "Clark Kent", "Superman" },
                { "Bruce Wayne", "Batman" },
                { "Barry Allen", "The Flash" }
            };


            superheroes.Remove("Barry Allen");

            Console.WriteLine($"Count : {superheroes.Count}");

            Console.WriteLine($"Clark Kent : {superheroes.ContainsKey("Clark kent")}");
            Console.WriteLine($"Clark Kent : {superheroes.ContainsValue("Superman")}");

            superheroes.TryGetValue("Clark Kent", out string? test);
            Console.WriteLine($"Clark kent : {test}");

            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            superheroes.Clear();
            Console.WriteLine($"Count : {superheroes.Count}");

        }
    }
}