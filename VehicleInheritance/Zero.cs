using System;

namespace VehicleInheritance
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        // public void ChargeBattery () { ... }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeoooowwww!");
        }
    }
}