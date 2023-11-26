using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Math;

namespace HomeWorkFigure
{
    internal class Ellipse : Figure
    {
        private double a, b;
        private const double pi = 3.14;

        public double param_a { get { return a; } set { a = checked(value); } }
        public double param_b { get { return b; } set { b = checked(value); } }

        public Ellipse(Colour Col, (double, double) Coord)
        {
            this.colour = Col;
            this.coordinates = Coord;
            a = 0;
            b = 0;
        }
        public Ellipse() : this(Colour.no_color, (0, 0)) { a = 0; b = 0; }

        public override double perimeter
        { 
            get 
            {
                if ((a <= 0) || (b <= 0))
                    throw new Exception("not all parameters are set\nor incorrect data entered");
                else
                {
                    double buf = 2 * PI * Sqrt((a * a + b * b) / 2);
                    return buf;
                }
            } 
        }
        public override double Area_of_the_figure
        { 
            get 
            {
                if ((a <= 0) || (b <= 0))
                    throw new Exception("not all parameters are set\nor incorrect data entered");
                else
                    return PI * a * b;
            } 
        }
    }
}
