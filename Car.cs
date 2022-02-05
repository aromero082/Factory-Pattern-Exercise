using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Car is driving safely yayyy!");
        }
    }
}
