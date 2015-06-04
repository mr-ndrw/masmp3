using System;

namespace Logic.Core
{
    public abstract class Unit
    {
        protected Unit(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public abstract void Attack(Unit unit);
        public abstract void Attack(TerranUnit terran);
        public abstract void Attack(ZergUnit zerg);
        public abstract void Attack(ProtossUnit protoss);

        public virtual void Move()
        {
            Console.WriteLine("Unit {0} moves.", Name);
        }
    }
}