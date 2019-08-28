using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks
{
    // Tutaj można się zastanowić nad lepszą nazwą.
    // Patrząc od strony abstrakcji to rzeczywiście jest ReadDouble albo może bardziej DoubleReader czy nawet DoubleValueProvider
    // Patrząc od strony konkretnej implementacji
    // (a że narazie nie ma tu większego sensu robienie jakiegoś interfejsu i alternatywnych implementacji, to możemy przyjąć, że jest po prostu ta jedna klasa)
    // to będzie bardziej ConsoleDoubleValueProvider czyli na polskie - konsolowy dostarczacz wartości typu double ;) ot taka propozycja.
    public class ConsoleDoubleValueProvider
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
                else { Console.WriteLine("Enter correct value (type: double)!" + Environment.NewLine); }
            }
            return parsed;
        }
    }
}
