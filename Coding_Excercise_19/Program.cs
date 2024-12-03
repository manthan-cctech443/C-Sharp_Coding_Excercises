using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public class Animal
        {
            // TODO: Declare a virtual method MakeSound
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal sound");
            }
        }

        public class Dog : Animal
        {
            // TODO: Override the MakeSound method
            public override void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("Dog barks");
            }
        }

        
        public static void PrintSounds()
        {
            // TODO: Create an instance of Dog and call the MakeSound method
            Animal myDog = new Dog();
            myDog.MakeSound();
        }
        

        public static void Main(string[] args)
        {
            PrintSounds();
        }
    }
}