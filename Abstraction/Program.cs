
using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Abstract Classes and Methods Demo ---");
            
            Circle myCircle = new Circle(5);
            Rectangle myRectangle = new Rectangle(4, 6);

            Console.WriteLine($"Area of circle with radius 5: {myCircle.GetArea()}");
            Console.WriteLine($"Area of rectangle 4x6: {myRectangle.GetArea()}");
        }
    }

    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class
    class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }
}