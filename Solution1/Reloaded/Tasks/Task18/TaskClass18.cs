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
            var cone1 = new Cone(2, 8);
            var cone2 = new Cone(3, 10);
            var cube1 = new Cube(5);
            var cube2 = new Cube(10);
            var cylinder1 = new Cylinder(4, 10);
            var cylinder2 = new Cylinder(5, 12);
            var sphere1 = new Sphere(10);
            var sphere2 = new Sphere(20);

            var totalAreaList = new List<ITotalArea>
            {
            cone1,
            cone2,
            cube1,
            cube2,
            cylinder1,
            cylinder2,
            sphere1,
            sphere2,
            };

            var volumeList = new List<IVolume>
            {
            cone1,
            cone2,
            cube1,
            cube2,
            cylinder1,
            cylinder2,
            sphere1,
            sphere2,
            };

            var aggregateTotalArea = new double();
            var aggregateVolume = new double();

            for (int i = 0; i < totalAreaList.Count; i++)
            {
                aggregateTotalArea += totalAreaList[i].TotalArea;
            }

            for (int i = 0; i < volumeList.Count; i++)
            {
                aggregateVolume += volumeList[i].Volume;
            }
            Console.ReadKey();
        }
    }
}
