using System;

namespace part7
{
    class Animal
    {
        public string name;
        public string sound;
        static int numOfAnimals = 0;

        public Animal()// defautl constructor
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name")// only name is passed as args
        {

            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")// only sound is passed as args
        {
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

        public static int GetNumOfAnimal()
        {
            return numOfAnimals;
        }

    }
}