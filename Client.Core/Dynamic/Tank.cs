using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Core
{
    public class Tank : TerranUnit
    {
        private TankMode _tankMode;

        public Tank() 
            :base("Tank")
        {
            _tankMode = new AssaultModeTank();
        }

        public override void Move()
        {
            _tankMode.Move(this);
        }

        public override void Attack(Unit unit)
        {
            _tankMode.Attack();
            base.Attack(unit);
        }

        public override void Attack(TerranUnit terran)
        {
            _tankMode.Attack();
            base.Attack(terran);
        }

        public override void Attack(ZergUnit zerg)
        {
            _tankMode.Attack();
            base.Attack(zerg);
        }

        public override void Attack(ProtossUnit protoss)
        {
            _tankMode.Attack();
            base.Attack(protoss);
        }

        public void ChangeMode()
        {
            if (_tankMode is AssaultModeTank)
            {
                _tankMode = new SiegeModeTank();
            }
            else if (_tankMode is SiegeModeTank)
            {
                _tankMode = new AssaultModeTank();
            }
        }
    }
}
