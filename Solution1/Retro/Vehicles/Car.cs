using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro.Vehicles
{
    public class Car : IVehicle
    {
        public double MaxSpeed { get; set; }

        public void RunWithSpeed(double speed)
        {
            // jakaś inna implementacja niż w Boat
        }
    }
}
