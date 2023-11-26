using HomeWorkFigure;
using static System.Console;

namespace HomeWork
{
    class Prog
    {
        static void Main(string[] args) 
        {
            try
            {
                Circle fig = new Circle();
                fig.radius = Convert.ToDouble(Console.ReadLine());
                //Square fig = new Square();
                //fig.colour = (Colour)10;
                //WriteLine(fig.colour);
                //fig.side = 5;

                WriteLine($"Perimeter = {fig.perimeter}");
                WriteLine($"Square = {fig.Area_of_the_figure}");




                Read();
            }
            catch(Exception ex) { WriteLine(ex.Message); }
        }
    }
}