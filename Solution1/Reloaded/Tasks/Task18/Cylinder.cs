using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class Cylinder : ISolid
    {
        public Cylinder()
        {

        }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double Radius { get; set; }
        public double Height { get; set; }
        public double TotalArea => 2 * Math.PI * Radius * (Radius + Height);
        public double Volume => Math.PI * Math.Pow(Radius, 2) * Height;
    }
}
