using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class Cube : ITotalArea, IVolume
    {
        public Cube()
        {

        }

        public Cube(double edge)
        {
            Edge = edge;
        }

        public double Edge { get; set; }
        public double TotalArea => 6 * Math.Pow(Edge, 2);
        public double Volume => Math.Pow(Edge, 3);
    }
}
