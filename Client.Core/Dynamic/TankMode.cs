using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Core
{
    public abstract class TankMode
    {
        public abstract void Move(Tank tank);
        public abstract void Attack();
    }
}
