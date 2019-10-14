using System;

namespace VehicleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Midnight Blue",
                MaximumOccupancy = "2"
            };

            Tesla modelS = new Tesla()
            {
                MainColor = "White",
                MaximumOccupancy = "4"
            };

            Cessna mx410 = new Cessna()
            {
                MainColor = "Silver",
                MaximumOccupancy = "6"
            };

            Ram the3500 = new Ram()
            {
                MainColor = "Black",
                MaximumOccupancy = "4"
            };
            
            /* Practice: Custom Colors and Sounds. Move all common properties in your vehicles to a new Vehicle class. Create an instance of each vehicle. Define a different value for each vehicle's properties. Create a Drive() method in the Vehicle class. Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!").
            
            Create a Turn(string direction) mathod, and a Stop() method on Vehicle. Define a basic implementation of each.
            Override all three of those methods on some of the vehicles. For example, the Stop() method for a plane would be to output the message "The white Cessna rolls to a stop after rolling a mile down the runway."
            Make your vehicle instances perform all three behaviors.
            */

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();

            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            Console.WriteLine();

            the3500.Drive();
            the3500.Turn("right");
            the3500.Stop();
            Console.WriteLine();
            
        }
    }
}
