using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task17
{
    public class TaskClass17
    {
        public const double Factor = 7;

        public void Test()
        {
            var shapeList = new List<IScalable>
            {
                new Circle(2),
                new Circle(4),
                new Circle(6),
                new Circle(8),
                new Rectangle(2,4),
                new Rectangle(6,8),
                new Rectangle(10,12),
                new Rectangle(14,16),
            };
            
            for (int i = 0; i < shapeList.Count; i++)
            {
                shapeList[i].Scale(Factor);
            }
        }
    }
}
