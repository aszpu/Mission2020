using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16
{
    public class CircleOld
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Math.Pow(Radius, 2);

        public void Scale(double factor)
        {
            Radius = Radius * factor; // da się też tak: Radius *= factor; - mnoży lewy operand przez prawy i przypisuje wartość do lewego
        }
    }

    public class Circle
    {
        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;

        }

        public double Radius { get; set; }
        public double Area => Math.PI * Math.Pow(Radius, 2);

        public void Scale(double factor)
        {
            Radius *= factor;
        }
    }
}
