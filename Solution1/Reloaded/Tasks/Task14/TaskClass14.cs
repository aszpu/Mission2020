using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task14
{
    class TaskClass14
    {
        public void Test()
        {
            var circle = new Circle();
            circle.Radius = ReadDoubleFromConsole("Enter radius of the circle: ");
            Console.WriteLine("Circle surface area: " + circle.Area + Environment.NewLine);
            Console.ReadKey();
        }

        private double ReadDoubleFromConsole(string enterValueMessage)
        {
            bool correctData = false;
            var parsed = new double();

            while (!correctData)
            {
                Console.WriteLine(enterValueMessage);
                var readed = Console.ReadLine();

                if(double.TryParse(readed, out parsed))
                {
                    correctData = true;
                    Console.WriteLine("");
                }
                else { Console.WriteLine("Enter correct value!" + Environment.NewLine); }
            }
            return parsed;
        }
    }
}
