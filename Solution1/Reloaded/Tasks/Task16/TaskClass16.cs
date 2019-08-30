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
            var circle1 = new CircleOld
            {
                Radius = 2
            };

            var circle2 = new CircleOld
            {
                Radius = 4
            };

            var circle3 = new CircleOld
            {
                Radius = 6
            };

            var circle4 = new CircleOld
            {
                Radius = 8
            };

            var rectangle1 = new RectangleOld
            {
                Height = 5,
                Width = 2
            };

            var rectangle2 = new RectangleOld
            {
                Height = 7,
                Width = 3
            };

            var rectangle3 = new RectangleOld
            {
                Height = 3,
                Width = 5
            };

            var rectangle4 = new RectangleOld
            {
                Height = 5,
                Width = 8
            };

            List<CircleOld> circleList = new List<CircleOld>
            {
                circle1,
                circle2,
                circle3,
                circle4
            };

            List<RectangleOld> rectangleList = new List<RectangleOld>
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

        public void Test2()
        {
            var circleList = new List<Circle>
            {
                new Circle (2),
                new Circle (4),
                new Circle (6),
                new Circle (8),
            };

            var rectangleList = new List<Rectangle>
            {
                new Rectangle(5,2),
                new Rectangle(7,3),
                new Rectangle(3,5),
                new Rectangle(5,8),
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







