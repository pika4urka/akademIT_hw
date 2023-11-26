using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkFigure
{
    internal class Square : Figure
    {
        private double sd;
        public double side { get { return sd; } set { sd = checked(value); } }
        public Square(Colour Col, (double, double) Coord)
        {
            this.colour = Col;
            this.coordinates = Coord;
            sd = 0;
        }
        public Square() : this(Colour.no_color, (0, 0)) { sd = 0; }

        public override double perimeter
        { 
            get 
            { 
                if (sd == 0)
                    throw new Exception("not all parameters are set");
                else
                    return sd * 4; 
            } 
        }
        public override double Area_of_the_figure
        { 
            get 
            {
                if (sd == 0)
                    throw new Exception("not all parameters are set");
                else
                    return sd * sd; 
            } 
        }
    }
}
