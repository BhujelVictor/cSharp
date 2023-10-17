using System;

namespace part9
{
    class Program
    {

        static void Main(string[] args)
        {
            Animal mira = new()
            {
                Name = "Mira",
                Sound = "Meow"
            };

            Dog garry = new()
            {
                Name = "Garry",
                Sound = "Woof",
                Sound2 = "Grrrrr"
            };

            Animal lion = new()
            {
                Name = "Lion",
                Sound = "Roar"
            };

            Animal strider = new Dog()
            {
                Name = "Strider",
                Sound = "Garrrr",
                // Sound2 = "Gerrrrr"
            };

            garry.Sound = "Woof Woof";

            mira.MakeSound();
            garry.MakeSound();

            lion.MakeSound();
            strider.MakeSound();

            mira.SetAnimalIDInfo(1, "Saugat");
            garry.SetAnimalIDInfo(2, "Dela");

            mira.GetAnimalIDInfo();
            garry.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new();
            Console.WriteLine($"Is the animal healty : {getHealth.HealthyWeight(12, 50)}");



        }

    }

}
