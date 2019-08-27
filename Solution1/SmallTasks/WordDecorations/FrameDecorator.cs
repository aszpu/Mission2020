using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.WordDecorations
{
    public class FrameDecorator : IDecorator
    {
        private char _decorator;

        public FrameDecorator(char d)
        {
            _decorator = d;
        }

        public List<string> Decorate(List<string> text)
        {
            int linesCount = text.Count();
            int lineLength = 0;

            for (int i = 0; i < linesCount; i++)
            {
                 if (text[i].Length > lineLength) {lineLength = text[i].Length;}
            }
            
            List<string> tableOutputDecoration = new List<string>();
            tableOutputDecoration.Add(LineDecorate(lineLength));

            string basePartOfLine = "";
            for (int i = 0; i < linesCount; i++)
            {
                basePartOfLine = _decorator + text[i];
                int actualLineLength = text[i].Length;
                int emptyRequiredCharsNumber = lineLength - actualLineLength;

                string emptyPartOfLine = "";
                for (int j=1; j<=emptyRequiredCharsNumber; j++)
                {
                    emptyPartOfLine += " ";
                }

                string fullLine = basePartOfLine + emptyPartOfLine + _decorator;
                tableOutputDecoration.Add(fullLine);                
            }
            
            tableOutputDecoration.Add(LineDecorate(lineLength));

            return tableOutputDecoration;
        }

        private string LineDecorate(int lineLength)
        {
            string lineString = "";
            for (int i = 1; i <= lineLength + 2; i++)
            {
                lineString += _decorator;
            }
            return lineString;
        }
    }
}
