using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Core
{
    public abstract class ZergUnit : Unit
    {
        public override void Attack(Unit unit)
        {
            Console.WriteLine("Zerg unit attacks a unit");
        }

        public override void Attack(ProtossUnit protoss)
        {
            Console.WriteLine("Zerg unit attacks a protoss unit");
        }

        public override void Attack(TerranUnit terran)
        {
            Console.WriteLine("Zerg unit attacks a terran unit");
        }

        public override void Attack(ZergUnit zerg)
        {
            Console.WriteLine("Zerg unit attack another zerg unit");
        }

        protected ZergUnit(string name) 
            : base("Zerg " + name)
        {
        }
    }
}
