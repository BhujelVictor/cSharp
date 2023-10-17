using System;
using System.Linq;

namespace part9
{
    class Animal
    {
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIDInfo = new();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound()// virtual so that it can be overwritted in the derived class
        {
            Console.WriteLine($"{Name} has sound {Sound}.");
        }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public Animal() : this("No Name", "No Sound") { }

        public Animal(string name) : this(name, "No Sound") { }


        

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Any(Char.IsDigit))
                {
                    name = "No Name";
                    Console.WriteLine("Name must not contain digits.");

                }   

                else name = value;

            }
        }



        public string Sound
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

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc >= .18) && calc <= .27)
                {
                    return true;
                }
                else return false;
            }
        }




    }
}