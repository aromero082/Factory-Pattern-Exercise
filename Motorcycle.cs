using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is super fast!");
            Console.WriteLine("vrooooooom!");
        }

    }
}
