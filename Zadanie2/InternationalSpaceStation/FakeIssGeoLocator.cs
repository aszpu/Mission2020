using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalSpaceStation
{
    public class FakeIssGeoLocator : IIssGeoLocator
    {
        private Random _random;

        public FakeIssGeoLocator()
        {
            _random = new Random();
        }

        public Coordinates GetLocation()
        {
            double minLongValue = -180;
            double maxLongValue = 180;

            double minLatValue = -90;
            double maxLatValue = 90;

            Coordinates location = new Coordinates();
            location.Longitude = minLongValue + (_random.NextDouble() * 2 * maxLongValue);
            location.Latitude = minLatValue + (_random.NextDouble() * 2 * maxLatValue);

            return location;
        }
    }
}
