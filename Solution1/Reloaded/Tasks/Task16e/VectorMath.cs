using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16e
{
    public class VectorMath
    {
        private double _x;
        private double _y;
        private double _z;

        public VectorMath()
        {
            
        }

        public Vector Sum(Vector a, Vector b)
        {

            var sumAB = new Vector()
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z
            };

            return sumAB;
        }
    }
}
