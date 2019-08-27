using Retro.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            double y1;
            string napis1;

            x1 = 1;
            y1 = 44.44;
            napis1 = "test";

            int x2 = 1;
            double y2 = 44.44;
            string napis2 = "test";

            var x3 = 1;
            var y3 = 44.44;
            var napis3 = "test";

            var x4 = x1;
            var y4 = y1;
            var napis4 = napis1;

            var boat1 = new Boat();
            var boat2 = new Boat();
            var boat3 = new Boat();

            var car1 = new Car();           
         
            boat1.IsSubmarine = true;
            boat1.MaxSpeed = 30;
         
            boat2.IsSubmarine = false;
            boat2.MaxSpeed = 60;
         
            boat3.IsSubmarine = false;
            boat3.MaxSpeed = 70;
         
            boat1.RunWithMaxSpeed();
            boat2.RunWithMaxSpeed();
            boat3.RunWithMaxSpeed();

            boat1.RunWithSpeed(12.587);
            var rep1 = boat1.GenerateReport();

            boat2.RunWithSpeed(1111112.587);
            var rep2 = boat2.GenerateReport();




            var oposite = boat3.OpositeValue(10).ToString();


            ChangeSpeedOfAnyVehicle(boat1, 23);
            ChangeSpeedOfAnyVehicle(car1, 23);
        }

        private static void ChangeSpeedOfAnyVehicle(IVehicle vehicle, double speed)
        {
            vehicle.RunWithSpeed(speed);
        }
    }
}
