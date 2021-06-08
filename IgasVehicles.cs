using System;

namespace Garage
{
    public interface IgasVehicles
    {
        void RefuelTank();
        double FuelCapacity { get; set; }
        int CurrentTankPercentage { get; set; }

    }
}