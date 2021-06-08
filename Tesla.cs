using System;

namespace Garage
{
    public class Tesla : Vehicle, IelectricVehicles // Electric car
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The { MainColor} Tesla flys by my house.Vrooom!");
        }
    }
}
