using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro.Vehicles
{
    public class Boat : IVehicle
    {
        private double _currentSpeed;

        public double MaxSpeed { get; set; }
        public bool IsSubmarine { get; set; }

        public void Submerge()
        {

        }

        public void RunWithMaxSpeed()
        {
            _currentSpeed = MaxSpeed;
        }

        public void RunWithSpeed(double speed)
        {
            if (speed > MaxSpeed)
            {
                _currentSpeed = MaxSpeed;
            }
            else
                _currentSpeed = speed;
        }

        public void Stop()
        {
            _currentSpeed = 0;
        }

        public string GenerateReport()
        {
            if (_currentSpeed == 0)
            {
                return "Is stationary";
            }

            return $"Is moving at {_currentSpeed}";
        }

        public int OpositeValue(int value)
        {
            return -value;
        }
    }
}
