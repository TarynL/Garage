using System;

namespace Garage
{
    public class Ram : Vehicle, IgasVehicles // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The { MainColor} Ram flys by my house.Vrooom!");
        }
    }
}
