using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Core
{
    public class AssaultModeTank : TankMode
    {
        public override void Move(Tank tank)
        {
            Console.WriteLine("Tank in assault mode moves.");
        }

        public override void Attack()
        {
            Console.WriteLine("Tank in assault mode attacks.");
            
        }
    }
}
