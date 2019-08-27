using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.WordDecorations
{
    public class NullDecorator : IDecorator
    {
        public List<string> Decorate(List<string> text)
        {
            //Console.WriteLine(text);
            return text;
        }
    }
}
