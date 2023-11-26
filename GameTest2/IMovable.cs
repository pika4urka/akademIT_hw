using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest2
{
    internal interface IMovable
    {
        IMovable MoveLeft();
        IMovable MoveRight();
        IMovable MoveUp();
        IMovable MoveDown();
    }
}
