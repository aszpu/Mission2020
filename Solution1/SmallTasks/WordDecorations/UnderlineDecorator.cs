using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.WordDecorations
{
    public class UnderlineDecorator : IDecorator
    {
        public List<string> Decorate(List<string> text)
        {
            int linesCount = text.Count();
            int lineLength = 0;

            for (int i = 0; i < linesCount; i++)
            {
                if (text[i].Length > lineLength) { lineLength = text[i].Length; }
            }

            text.Add(LineDecorate(lineLength));

            return text;
        }

        private string LineDecorate(int lineLength)
        {
            string lineString = "";
            for (int i = 1; i <= lineLength; i++)
            {
                lineString += "*";
            }
            return lineString;
        }
    }
}
