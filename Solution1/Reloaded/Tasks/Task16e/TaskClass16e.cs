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

            var vectorOperations = new VectorMath();

            var sum = vectorOperations.Sum(vectorList[0], vectorList[1]);
            var sub = vectorOperations.Sub(vectorList[0], vectorList[1]);
            var cross = vectorOperations.CrossProduct(vectorList[0], vectorList[1]);
            var dotProd = vectorOperations.DotProduct(vectorList[0], vectorList[1]);
            var neg = vectorOperations.Neg(vectorList[0]);
            var length = vectorOperations.Length(vectorList[0]);
            var mul = vectorOperations.Mul(vectorList[0], 3);

            Console.ReadKey();
        }
    }
}