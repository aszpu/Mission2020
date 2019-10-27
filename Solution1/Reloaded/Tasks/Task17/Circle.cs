using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task17
{
    public class Circle : IScalable
    {
        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public double Area => Math.PI * Math.Pow(Radius, 2);

        public void Scale (double factor)
        {
            Radius *= factor;
        }
    }
}
