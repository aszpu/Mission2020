using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16
{
    public class TaskClass16
    {
        public const double Factor = 7.7;

        public void Test()
        {
            var circle1 = new Circle
            {
                Radius = 2
            };

            var circle2 = new Circle
            {
                Radius = 4
            };

            var circle3 = new Circle
            {
                Radius = 6
            };

            var circle4 = new Circle
            {
                Radius = 8
            };

            var rectangle1 = new Rectangle
            {
                Height = 5,
                Width = 2
            };

            var rectangle2 = new Rectangle
            {
                Height = 7,
                Width = 3
            };

            var rectangle3 = new Rectangle
            {
                Height = 3,
                Width = 5
            };

            var rectangle4 = new Rectangle
            {
                Height = 5,
                Width = 8
            };

            List<Circle> circleList = new List<Circle>
            {
                circle1,
                circle2,
                circle3,
                circle4
            };

            List<Rectangle> rectangleList = new List<Rectangle>
            {
                rectangle1,
                rectangle2,
                rectangle3,
                rectangle4
            };

            for (int i = 0; i < circleList.Count; i++)
            {
                circleList[i].Scale(Factor);
            }

            for (int i = 0; i < rectangleList.Count; i++)
            {
                rectangleList[i].Scale(Factor);
            }
            
            Console.ReadKey();

        }
    }
}







