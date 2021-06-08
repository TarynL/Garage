using System;

namespace Garage
{
    public interface IelectricVehicles
    {
        void ChargeBattery();
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }

    }
}