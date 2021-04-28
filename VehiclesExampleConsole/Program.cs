using System;
using Vehicles;

namespace VehiclesExampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car hyundai = new Car();

            hyundai.DriveFaster(10);
            Console.WriteLine(hyundai.Speed);
        }
    }
}
