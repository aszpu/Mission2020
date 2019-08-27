using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.WordDecorations
{
    public class BracketDecorator : IDecorator
    {
        public List<string> Decorate(List<string> text)
        {
            int linesCount = text.Count();

            List<string> tableOutputDecoration = new List<string>();

            string decoratedLine = "";
            for (int i = 0; i < linesCount; i++)
            {
                decoratedLine = "(" + text[i] + ")";
                tableOutputDecoration.Add(decoratedLine);
            }

            return tableOutputDecoration;
        }
    }
}
