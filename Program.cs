using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IelectricVehicles> electricVehicles = new List<IelectricVehicles>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (IelectricVehicles ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IelectricVehicles ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IelectricVehicles ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IgasVehicles> gasVehicles = new List<IgasVehicles>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IgasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IgasVehicles gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IgasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}

// namespace Garage
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Zero fxs = new Zero();
//             {
//                 fxs.MainColor = "black";
//             }

//             Tesla modelS = new Tesla();
//             {
//                 modelS.MainColor = "blue";
//             }

//             Cessna mx410 = new Cessna();
//             {
//                 mx410.MainColor = "red";
//             }






//             fxs.Drive();
//             fxs.Turn("right");
//             fxs.Stop();
//             modelS.Drive();
//             modelS.Turn("left");
//             modelS.Stop();
//             mx410.Drive();
//             mx410.Turn("right");
//             mx410.Stop();

//         }
//     }
// }

