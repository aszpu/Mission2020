using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16e
{
    public class TaskClass16e
    {
        public void Test()
        {
            var vectorList = new List<Vector>
            {
                new Vector(2,6,3),
                new Vector(3,4,5)
            };

            var sum = new VectorMath().Sum(vectorList[0], vectorList[1]);
            var sub = new VectorMath().Sub(vectorList[0], vectorList[1]);
            var cross = new VectorMath().CrossProduct(vectorList[0], vectorList[1]);
            var dotProd = new VectorMath().DotProduct(vectorList[0], vectorList[1]);
            var neg = new VectorMath().Neg(vectorList[0]);
            var length = new VectorMath().Length(vectorList[0]);
            var mul = new VectorMath().Mul(vectorList[0], 3);

            Console.ReadKey();
        }
    }
}