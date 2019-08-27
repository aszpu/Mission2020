using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro.Vehicles
{
    public interface IVehicle
    {
        double MaxSpeed { get; set; }

        void RunWithSpeed(double speed);
    }
}
