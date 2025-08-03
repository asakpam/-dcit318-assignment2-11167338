using System;

namespace InterfaceDemo
{
    // Interface definition
    public interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable interface
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable interface
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Call Move() method on each instance
            car.Move();
            bicycle.Move();
        }
    }
} 