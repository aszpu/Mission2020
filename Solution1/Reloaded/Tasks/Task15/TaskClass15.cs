using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task15
{
    class TaskClass15
    {
        public void Test()
        {
            var rectangle = new Rectangle
            {
                Width = 5,
                Height = 8
            };

            var circle = new Circle
            {
                Radius = 10
            };

            var scale = new ReadDouble();
            var factor = scale.Read("Enter factor: ");

            rectangle.Scale(factor);
            circle.Scale(factor);

            Console.WriteLine("Surface areas after scalling...");
            Console.WriteLine("Rectangle: " + rectangle.Area);
            Console.WriteLine("Circle: " + circle.Area);
            Console.ReadKey();
        }
    }
}
