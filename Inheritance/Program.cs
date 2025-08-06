
using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Inheritance and Method Overriding Demo ---");
            
            Animal genericAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            Console.WriteLine("Animal says: ");
            genericAnimal.MakeSound();
            
            Console.WriteLine("Dog says: ");
            myDog.MakeSound();
            
            Console.WriteLine("Cat says: ");
            myCat.MakeSound();
        }
    }

    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}