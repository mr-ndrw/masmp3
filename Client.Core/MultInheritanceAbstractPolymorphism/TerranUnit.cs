using System;

namespace Logic.Core
{
    public abstract class TerranUnit : Unit
    {
        protected TerranUnit(string name)
            : base("Terran " + name)
        {

        }
        public override void Attack(Unit unit)
        {
            Console.WriteLine("Terran unit attacks a unit.");
        }

        public override void Attack(TerranUnit terran)
        {
            Console.WriteLine("Terran unit attacks other terran unit");
        }

        public override void Attack(ZergUnit zerg)
        {
            Console.WriteLine("Terran unit attack a zerg unit");
        }

        public override void Attack(ProtossUnit protoss)
        {
            Console.WriteLine("Terran unit attacks another terrant unit");
        }

    }
}