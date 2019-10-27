using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class Cone : ISolid
    {
        public Cone()
        {

        }

        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double Radius { get; set; }
        public double Height { get; set; }
        public double TotalArea => Math.PI * Radius * (Radius + Math.Sqrt(Math.Pow(Radius,2) + Math.Pow(Height,2)));
        public double Volume => 1/3 * Math.PI * Math.Pow(Radius, 2) * Height;
    }
}
