using System;
namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            {
                fxs.MainColor = "black";
            }

            Tesla modelS = new Tesla();
            {
                modelS.MainColor = "blue";
            }

            Cessna mx410 = new Cessna();
            {
                mx410.MainColor = "red";
            }






            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

        }
    }
}

