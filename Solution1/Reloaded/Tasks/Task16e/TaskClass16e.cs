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
                new Vector(2,3,4),
                new Vector(2,2,2)
            };

            var sum = new VectorMath().Sum(vectorList[0], vectorList[1]);
            
            Console.ReadKey();
        }
    }
}
