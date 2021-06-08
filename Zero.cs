using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The { MainColor} Zero flys by my house.Vrooom!");
        }
        public override void Turn(string direction)
        {

            direction = "left";
            Console.WriteLine($"The {MainColor} Zero took a sharp {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero stops in the middle of the road.");
        }
    }
}
