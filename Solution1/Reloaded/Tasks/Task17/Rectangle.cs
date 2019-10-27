using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task17
{
    public class Rectangle : IScalable
    {
        public Rectangle()
        {

        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;

        public void Scale (double factor)
        {
            Width *= factor;
            Height *= factor;
        }
    }
}
