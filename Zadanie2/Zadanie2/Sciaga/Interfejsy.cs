using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2.Sciaga
{
    public class TotalAreaCalculator
    {
        public double CalculateTotalArea(IShape[] shapes)
        {
            double totalArea = 0;
            foreach(var shape in shapes)
            {
                totalArea += shape.Area;
            }
            return totalArea;
        }

        public void RescaleAllShapes(IShape[] shapes, double ratio)
        {

            foreach(var shape in shapes)
            {
                shape.RescaleMe(ratio);
            }
        }
    }

    public interface IShape
    {
        double Area { get; }

        void RescaleMe(double ratio);
    }

    public class SquareShape : IShape
    {

        private double _x;

        public SquareShape(double x)
        {
            _x = x;
        }

        public double X {  get { return _x; } }

        public double Area
        {
            get
            {
                return _x * _x;
            }
        }

        public void RescaleMe(double ratio)
        {
            _x = _x * ratio;    
        }
    }
    
    public class CircleShape : IShape
    {
        private double _r;

        public CircleShape(double r)
        {
            _r = r;
        }

        public double Radius { get { return _r; } }

        public double Area
        {
            get
            {
                return Math.PI * _r * _r;
            }
        }

        public void RescaleMe (double ratio)
        {
            _r = _r * ratio;
        }

    }


    public interface IWitacz
    {
        void Powitaj();
    }

    public class CzlowiekWitajacy : IWitacz
    {
        public void Powitaj()
        {
            WyciagnijReke();
        }

        private void WyciagnijReke()
        {
            // Jakaś implementacja
            throw new NotImplementedException();
        }
    }

    public class PiesWitajacy : IWitacz
    {
        public void Powitaj()
        {
            PodajLape();
        }

        private void PodajLape()
        {
            // Jakaś implementacja
            throw new NotImplementedException();
        }
    }

}
