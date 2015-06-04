using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Core
{
    public abstract class ProtossUnit : Unit, IProtossUnit
    {
        public override void Attack(Unit unit)
        {
            Console.WriteLine("Protos unit attacks a unit");
        }

        public override void Attack(ZergUnit zerg)
        {
            Console.WriteLine("Protoss unit attack a zerg unit");
        }

        public override void Attack(ProtossUnit protoss)
        {
            Console.WriteLine("Protoss unit attacks another terrant unit");
        }

        public override void Attack(TerranUnit terran)
        {
            Console.WriteLine("Protoss unit attacks a terran unit");
        }

        public int Shield { get; set; }
        public int MaxShield { get; set; }

        public void RegenerateShield()
        {
            Shield = MaxShield;
        }

        protected ProtossUnit(string name) : base("Protoss " + name)
        {
        }
    }
}
