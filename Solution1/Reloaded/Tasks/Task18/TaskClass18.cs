using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class TaskClass18
    {
        public void Test()
        {
            var solidList = new List<ISolid>
            {
                new Cone(2,8),
                new Cone(3,10),
                new Cube(5),
                new Cube(10),
                new Cylinder(4,10),
                new Cylinder(5,12),
                new Sphere(10),
                new Sphere(20),
            };

            var aggregateTotalArea = new double();
            var aggregateVolume = new double();

            for (int i = 0; i < solidList.Count; i++)
            {
                aggregateTotalArea += solidList[i].TotalArea;
                aggregateVolume += solidList[i].Volume;
            }
            Console.ReadKey();
        }
    }
}
