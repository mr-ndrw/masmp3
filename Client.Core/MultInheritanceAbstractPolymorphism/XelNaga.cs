using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Core
{
    public abstract class XelNaga : ZergUnit, IProtossUnit
    {
        public override void Attack(Unit unit)
        {
            Console.WriteLine("Xel'Naga unit attacks a unit");
        }

        public override void Attack(ProtossUnit protoss)
        {
            Console.WriteLine("Xel'Naga unit attacks a protoss unit");
        }

        public override void Attack(TerranUnit terran)
        {
            Console.WriteLine("Xel'Naga unit attacks a terran unit");
        }

        public override void Attack(ZergUnit zerg)
        {
            Console.WriteLine("Xel'Naga unit attacks a zerg unit");
        }

        public int Shield { get; set; }
        public int MaxShield { get; set; }

        public void RegenerateShield()
        {
            Shield = MaxShield;
        }

        protected XelNaga(string name) 
            : base("Xel'naga " + name)
        {
        }
    }
}
