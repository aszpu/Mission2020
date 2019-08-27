using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.WordDecorations
{
    public class TextGet
    {
        private const int NumberOfLines = 3;

        public string[] GetText()
        {
            string[] tableGetText = new string[NumberOfLines];
            string line = "";
            Console.WriteLine("Wpisz tekst (3 linijki):");
            for (int i = 0; i < NumberOfLines; i++)
            {
                line = Console.ReadLine();
                tableGetText[i] = line;
            }

            return tableGetText;
        }
    }
}
