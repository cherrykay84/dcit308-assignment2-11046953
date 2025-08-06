
using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Interface Demo ---");
            
            Car myCar = new Car();
            Bicycle myBike = new Bicycle();

            Console.WriteLine("Car action: ");
            myCar.Move();
            
            Console.WriteLine("Bicycle action: ");
            myBike.Move();
        }
    }

    // Interface definition
    interface IMovable
    {
        void Move();
    }

    // Implementing class
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Implementing class
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}