using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("Lets go mudding!");
        }
    }
}
