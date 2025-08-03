using System;

namespace ShapeAreaCalculator
{
    // Abstract base class Shape
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        public override double GetArea()
        {
            return Math.PI * 5 * 5; // Using fixed radius of 5
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public override double GetArea()
        {
            return 4 * 6; // Using fixed length 4 and width 6
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            // Display their areas
            Console.WriteLine($"Circle area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");
        }
    }
} 