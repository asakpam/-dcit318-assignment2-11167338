using System;

namespace ShapeAreaCalculator
{
    // Abstract base class Shape
    public abstract class Shape
    {
        public abstract double GetArea();
        
        // Non-abstract method that can be inherited
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Area: {GetArea():F2}");
        }
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {radius}:");
            base.DisplayInfo();
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with length {length} and width {width}:");
            base.DisplayInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Classes and Methods Demo - Shape Area Calculator");
            Console.WriteLine("========================================================");
            Console.WriteLine();

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display areas using the abstract method
            Console.WriteLine("Calculating areas using abstract methods:");
            Console.WriteLine("----------------------------------------");
            
            circle.DisplayInfo();
            Console.WriteLine();
            
            rectangle.DisplayInfo();
            Console.WriteLine();

            // Demonstrate polymorphism with an array of shapes
            Console.WriteLine("Demonstrating Polymorphism with Shape Array:");
            Console.WriteLine("============================================");
            
            Shape[] shapes = { circle, rectangle };
            
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.Write($"Shape {i + 1}: ");
                shapes[i].DisplayInfo();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
} 