using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest2
{
    internal abstract class Sprite : IMovable
    {
        protected int x { get; set; }
        protected int y { get; set; }

        protected int orient { get; set; }

        public Sprite(int x, int y, int orient)
        {
            this.x = x;
            this.y = y;
            this.orient = orient;
        }

        

        public abstract void Explose();
        public abstract IMovable MoveLeft();
        public abstract IMovable MoveRight();
        public abstract IMovable MoveUp();
        public abstract IMovable MoveDown();
    }
}
