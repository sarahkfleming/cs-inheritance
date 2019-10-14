using System;

namespace VehicleInheritance
{
    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        // public void ChargeBattery () { ... }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. Mmmmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a {direction} turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }
}