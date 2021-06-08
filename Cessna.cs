using System;

namespace Garage
{
    public class Cessna : Vehicle, IgasVehicles // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The { MainColor} Cessna flys by my house.Vrooom!");
        }

        public override void Turn(string direction)
        {

            direction = "right";
            Console.WriteLine($"The {MainColor} Cessna took a sharp {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna stops in the middle of the runway.");
        }

    }
}