using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16d
{
    public class TaskClass16d
    {
        public void Test()
        {
            var txt = new RichText("Arkadiusz");
            txt.LetterSeparator = "-";
            txt.LetterCase = LetterCaseType.Upper;
            txt.Underline = true;
            txt.ReverseOrder = true;
            txt.Color = ConsoleColor.Yellow;
            txt.Show();
        }
    }
}
