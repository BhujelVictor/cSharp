using System;
using System.Linq;

namespace part7
{
    class Animal
    {
        private string name;
        private string sound;
        public static int numOfAnimals = 0;
        public const string SHELTER = "Safe Home for Animals";
        public readonly int idNum;



        // Function Overloading
        public Animal() : this("No Name", "No Sound") { }

        public Animal(string name) : this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;
            Random rnd = new();
            idNum = rnd.Next(1, 600993478);

        }


        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

        public static int GetNumOfAnimal()
        {
            return numOfAnimals;
        }

        public void SetName(string name)// Setter
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name cannot contain numbers");

            }
        }

        public string GetName()
        {
            return name;
        }

        public string Sound // Alternative way to use setters and getters
        {
            get
            {
                return sound;
            }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");

                }
                else
                {
                    sound = value;
                }
            }
        }

        public string Owner { get; set; } = "No Owner";

        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }



    }
}