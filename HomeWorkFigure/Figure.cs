using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWorkFigure
{
    enum Colour
    {
        red = 1,
        green = 2,
        blue = 3,
        yellow = 4,
        black = 5,
        no_color = 0
    }

    internal abstract class Figure
    {        
        private Colour col;
        private (double x, double y) coord;

        public Figure()
        {
            col = Colour.no_color;
            coord = (0, 0);
        }
        public (double, double) coordinates
        {
            get { return coord; }
            set { coord = checked(value); }
        }
        public Colour colour
        {
            get { return col; }
            set 
            {
                switch((Colour)value)
                {
                    case Colour.red: col = Colour.red; break;
                    case Colour.green: col = Colour.green; break;
                    case Colour.blue: col = Colour.blue; break;
                    case Colour.yellow: col = Colour.yellow; break;
                    case Colour.black: col = Colour.black; break;
                    case Colour.no_color: col = Colour.no_color; break;
                    default: Console.WriteLine("Colour is invalid"); break;
                }
            }
        }

        public abstract double perimeter { get; }
        public abstract double Area_of_the_figure { get; }

    }
}
