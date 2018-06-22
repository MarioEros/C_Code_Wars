using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._7Kyu
{
    class PatternCraft_Adapter
    {
        public class MarioAdapter : IUnit{
            private Mario mario;
    
            public MarioAdapter(Mario mario){
                this.mario = mario;
            }

            public void Attack(Target target){
                target.Health -= this.mario.jumpAttack();
            }
        }
    }
}
