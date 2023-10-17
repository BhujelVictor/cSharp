using System;

namespace part7
{
    class Program
    {


    
    static void Main(string[] args)
    {
        Animal cat = new();
        cat.SetName("Mira");
        cat.Sound = "Meow";
        Console.WriteLine($"The cat is named {cat.GetName()} and says {cat.Sound}");
        cat.Owner = "Victor";
        Console.WriteLine($"{cat.GetName()}'s owner is {cat.Owner}.");
        Console.WriteLine($"{cat.GetName()}'s shelter id is {cat.idNum}.");
        Console.WriteLine($"Number of Animals is {Animal.NumOfAnimals}.");


    }

}

}
