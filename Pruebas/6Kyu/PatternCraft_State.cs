using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class PatternCraft_State
    {
        public interface IUnit
        {
            IUnitState State { get; set; }
            bool CanMove { get; }
            int Damage { get; }
        }

        public interface IUnitState
        {
            bool CanMove { get; set; }
            int Damage { get; set; }
        }

        public class SiegeState : IUnitState
        {
            public SiegeState()
            {
                this.CanMove = false;
                this.Damage = 20;
            }

            public bool CanMove { get; set; }
            public int Damage { get; set; }
        }

        public class TankState : IUnitState
        {
            public TankState()
            {
                CanMove = true;
                Damage = 5;
            }

            public bool CanMove { get; set; }
            public int Damage { get; set; }
        }

        public class Tank : IUnit
        {
            public Tank()
            {
                this.State = new TankState();
            }
            public IUnitState State
            {
                get
                {
                    return this.State;
                }
                set
                {
                    this.CanMove = value.CanMove;
                    this.Damage = value.Damage;
                }
            }
            public bool CanMove { get; set; }
            public int Damage { get; set; }
        }
    }
}
