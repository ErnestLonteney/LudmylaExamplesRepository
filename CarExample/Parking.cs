using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarExample
{
    class Parking(Car[] cars, string name)
    {
        public Car[] Cars { get; } = cars;

        public string Name { get; } = name;

        public void DisplayAllCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Mark} {car.Model}");
            }
        }
    }
}
