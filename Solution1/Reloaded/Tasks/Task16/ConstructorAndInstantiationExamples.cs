using System;
using System.Collections.Generic;

namespace Reloaded.Tasks.Task16
{
    public class ConstructorAndInstantiationExamples
    {
        public void Test()
        {
            var p1 = new Point(12.2, 33.3);
            var p2 = new Point(20.8, 14.4);
            var segment = new Segment(p1, p2);
            var length = segment.Length;

            var points = new List<Point>()
            {
                new Point(),
                new Point(),
                new Point(3,4),
                new Point(18, 8),
                new Point(),
                new Point(3324123, 323),
                new Point(Double.MaxValue, 0),
            };
        }
    }

    public class Segment
    {
        public Segment(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public Point P1 { get; set; }

        public Point P2 { get; set; }

        public double Length => Math.Sqrt(Math.Pow(P2.X - P1.X, 2) + Math.Pow(P2.Y - P1.Y, 2));
    }

    public class Point
    {
        public Point()
        {
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }
}
