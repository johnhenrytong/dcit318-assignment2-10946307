using System;

namespace Interfaces
{
    // Interface definition
    interface IMovable
    {
        void Move();
    }

    // Class implementing the interface
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Another class implementing the interface
    class Bicycle : IMovable
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
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            // Call the Move method on each instance
            car.Move();       // Output: Car is moving
            bicycle.Move();   // Output: Bicycle is moving
        }
    }
}
