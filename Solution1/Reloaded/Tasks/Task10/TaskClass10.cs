using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task10
{
    class TaskClass10
    {
        public void Test()
        {
            Console.WriteLine("");
            Console.WriteLine("Task 10");
            Console.WriteLine("Wpisz tekst!");
            var text = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Wpisany tekst: " + text);

            Console.ReadKey();
        }
    }
}
