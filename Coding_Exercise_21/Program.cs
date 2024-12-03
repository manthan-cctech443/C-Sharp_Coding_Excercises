using System;

namespace Coding.Exercise
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    public class Exercise
    {
        public void DemonstrateOverriding()
        {
            Animal animal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.DemonstrateOverriding();
        }
    }
}
