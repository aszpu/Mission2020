using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks
{
    public class ReadDouble
    {
        public double Read(string enterValueMessage)
        {
            bool correctData = false;
            var parsed = new double();

            while (!correctData)
            {
                Console.WriteLine(enterValueMessage);
                var readed = Console.ReadLine();

                if (double.TryParse(readed, out parsed))
                {
                    correctData = true;
                    Console.WriteLine("");
                }
                else { Console.WriteLine("Enter correct value (double)!" + Environment.NewLine); }
            }
            return parsed;
        }
    }
}
