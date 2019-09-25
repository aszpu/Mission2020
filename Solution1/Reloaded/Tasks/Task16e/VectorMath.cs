using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16e
{
    public class VectorMath
    {

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

        public Vector Sub(Vector a, Vector b)
        {
            var subAB = new Vector()
            {
                X = a.X - b.X,
                Y = a.Y - b.Y,
                Z = a.Z - b.Z
            };

            return subAB;
        }

        public Vector CrossProduct(Vector a, Vector b)
        {
            var crossAB = new Vector()
            {
                X = (a.Y * b.Z) - (a.Z * b.Y),
                Y = (a.Z * b.X) - (a.X * b.Z),
                Z = (a.X * b.Y) - (a.Y * b.X)
            };

            return crossAB;
        }

        public double DotProduct(Vector a, Vector b)
        {
            return (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
        }

        public Vector Neg(Vector a)
        {
            var negAB = new Vector()
            {
                X = -a.X,
                Y = -a.Y,
                Z = -a.Z
            };
            return negAB;
        }

        public double Length(Vector a)
        {
            return Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2) + Math.Pow(a.Z, 2));
        }

        public Vector Mul(Vector a, double factor)
        {
            var mulA = new Vector()
            {
                X = a.X * factor,
                Y = a.Y * factor,
                Z = a.Z * factor
            };

            return mulA;
        }

    }
}
