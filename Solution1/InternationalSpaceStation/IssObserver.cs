using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternationalSpaceStation
{
    public class IssObserver
    {
        private IGeoLocationLogger _logger;
        private IIssGeoLocator _locator;

        public IssObserver (IGeoLocationLogger l, IIssGeoLocator loc)
        {
            _logger = l;
            _locator = loc;
        }

        public void Start(double interval, int count)
        {
            _logger.CleanUp();
            for (int i=0; i<count; i++)
            {
                Thread.Sleep((int)(interval * 1000));
                Coordinates coordinates = _locator.GetLocation();
                _logger.LogLocation(coordinates);
            }
        }
    }
}
