using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using static System.Math;

namespace HomeWorkFigure
{
    
    internal class Circle : Figure
    {
        private double rad;
        public double radius
        {
            get { return rad; }
            set { rad = value; }
        }

        public Circle(Colour Col, (double, double) Coord)
        {
            this.colour = Col;
            this.coordinates = Coord;
            rad = 0;
        }
        public Circle() : this(Colour.no_color, (0, 0)) { rad = 0; }

        public override double perimeter
        { 
            get 
            {
                if (rad == 0)
                    throw new Exception("not all parameters are set");
                else
                    return 2 * PI * rad; 
            } 
        }

        public override double Area_of_the_figure
        { 
            get 
            {
                if (rad == 0)
                    throw new Exception("not all parameters are set");
                else
                    return PI * rad * rad; 
            } 
        }
    }
}
