using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class Sphere : ISolid
    {
        public Sphere()
        {

        }

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public double TotalArea => 4 * Math.PI * Math.Pow(Radius, 2);
        public double Volume => 4/3 * Math.PI * Math.Pow(Radius, 2);
    }
}
