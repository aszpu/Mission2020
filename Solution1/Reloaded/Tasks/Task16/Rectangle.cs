using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;

        public void Scale(double factor)
        {
            Width = Width * factor;
            Height = Height * factor;
        }
    }
}
