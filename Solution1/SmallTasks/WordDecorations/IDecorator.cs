using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTasks.WordDecorations
{
    public interface IDecorator
    {
        List<string> Decorate(List<string> text);
    }
}
