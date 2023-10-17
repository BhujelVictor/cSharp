using System;

namespace part9
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrrrr";

        public override void MakeSound()
        {
            // base.MakeSound();
            Console.WriteLine($"{Name} has sound {Sound2}");
        }

        public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound2"): base(name, sound) // calling base class contructor
        {
            Sound2 = sound2;
        }
    }

}