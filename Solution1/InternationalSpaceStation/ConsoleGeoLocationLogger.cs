using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalSpaceStation
{
    public class ConsoleGeoLocationLogger : IGeoLocationLogger
    {
        public void CleanUp()
        {
            Console.Clear();
        }

        public void LogLocation(Coordinates coordinates)
        {
            Console.WriteLine("Longitude: " + coordinates.Longitude);
            Console.WriteLine("Latitude: " + coordinates.Latitude);
        }
    }
}
