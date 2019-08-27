using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task13
{
    // uwagi:
    // - duży plus za walidację wprowadzanych danych i pętle wymuszającą wprowadzenie poprawnej wartości double
    // - ale zamknął bym to w metodę o takiej sygnaturze:
    //   double ReadDoubleFromConsole(string enterValueMessage)
    //   ta metoda powinna mieć całą Twoją logikę zawartą w takim pojedynczym while'u i powinna ostatecznie wypluwać double
    //   i z tej metody trzeba skorzystać dwa razy po to żeby dostać width oraz height. Przykład wywołania dla width:
    //   double width = ReadDoubleFromConsole("Enter the width of the rectangle: ");

    class TaskClass13
    {
        public void Test()
        {
            var rectangle = new Rectangle();

            rectangle.Width = ReadDoubleFromConsole("Enter the width of the rectangle: ");
            rectangle.Height = ReadDoubleFromConsole("Enter the height of the rectangle: ");

            Console.WriteLine("Area of the rectangle: " + rectangle.Area());
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
                if (double.TryParse(readed, out parsed))
                {
                    correctData = true;
                }
                else { Console.WriteLine("Enter correct data!" + Environment.NewLine); }
            }
            Console.WriteLine("");
            return parsed;
        }
    }
}
