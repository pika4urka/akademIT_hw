using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkFigure
{
    internal class Rectangle : Figure
    {
        private double a, b;
        public double side_a { get { return a; } set { a = checked(value); } }
        public double side_b { get { return b; } set { b = checked(value); } }

        public Rectangle(Colour Col, (double, double) Coord)
        {
            this.colour = Col;
            this.coordinates = Coord;
            a = 0;
            b = 0;
        }
        public Rectangle() : this(Colour.no_color, (0, 0)) { a = 0; b = 0; }

        public override double perimeter 
        { 
            get 
            { 
                if ( (a == 0) || (b == 0) )
                    throw new Exception("not all parameters are set");
                else
                    return 2 * (a + b); 
            } 
        }

        public override double Area_of_the_figure 
        { 
            get 
            {
                if ((a == 0) || (b == 0))
                    throw new Exception("not all parameters are set");
                else
                    return a * b; 
            } 
        }

    }
}
