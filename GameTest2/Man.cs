using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest2
{
    internal class Man : Sprite
    {
        public Man(int x, int y, int orient) : base(x, y, orient)          //base(x, y, orient)
        {

        }

        public override void Explose()
        {
            Console.WriteLine("Man Exploted!!");
            
        }

        public override IMovable MoveDown()
        {
            y--; Console.WriteLine($"Man moves down x = {x}, y = {y}");
            return this;
        }

        public override IMovable MoveLeft()
        {
            x--; Console.WriteLine($"Man moves left x = {x}, y = {y}");
            return this;
        }

        public override IMovable MoveRight()
        {
            x++; Console.WriteLine($"Man moves right x = {x}, y = {y}");
            return this;
        }

        public override IMovable MoveUp()
        {
            y++; Console.WriteLine($"Man moves up x = {x}, y = {y}");
            return this;
        }
    }
}
