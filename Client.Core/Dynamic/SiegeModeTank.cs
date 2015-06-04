using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Core
{
    public class SiegeModeTank : TankMode
    {
        public override void Move(Tank tank)
        {
            Console.WriteLine("Tank can't move. It's in Siege Mode.");
        }

        public override void Attack()
        {
            Console.WriteLine("Tank in Siege Mode attacks.");
        }
    }
}
