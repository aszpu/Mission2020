using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalSpaceStation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sqlTest = new TestConnection();
            //sqlTest.PerformTest();

            //var logger = new ConsoleGeoLocationLogger();
            var logger = new DbGeoLocationLogger();
            var locator = new FakeIssGeoLocator();
            var observer = new IssObserver(logger, locator);
            observer.Start(1.0, 5);

            Console.ReadKey();
        }
    }
}
