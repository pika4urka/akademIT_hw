using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest2
{
    internal class Monster : Sprite
    {
        public Monster(int x, int y, int orient) : base(x, y, orient)
        {
        }

        public override void Explose()
        {
            Console.WriteLine("Monster Exploted!!");
            
        }

        public override IMovable MoveDown()
        {
            y-=2; Console.WriteLine($"Monster moves down x = {x}, y = {y}");
            return this;
        }

        public override IMovable MoveLeft()
        {
            x-=2; Console.WriteLine($"Monster moves left x = {x}, y = {y}");
            return this;
        }

        public override IMovable MoveRight()
        {
            x+=2; Console.WriteLine($"Monster moves right x = {x}, y = {y}");
            return this;
        }

        public override IMovable MoveUp()
        {
            y+=2; Console.WriteLine($"Monster moves up x = {x}, y = {y}");
            return this;
        }
    }
}
