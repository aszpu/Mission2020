using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task11
{
    class TaskClass11
    {
        public void Test()
        {
            Console.WriteLine("");
            Console.WriteLine("Task 11");
            Console.WriteLine("Wpisz tekst!");
            var text = Console.ReadLine();

            if (text != "socjalizm")
            {
                Console.WriteLine("Wpisany tekst: " + text.ToUpper());
                Console.ReadKey();
            }
        }
    }
}
