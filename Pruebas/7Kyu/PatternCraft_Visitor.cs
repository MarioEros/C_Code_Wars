using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._7Kyu
{
    class PatternCraft_Visitor
    {
        public interface IVisitor
        {
            void VisitLight(ILightUnit unit);
            void VisitArmored(IArmoredUnit unit);
        }

        public interface ILightUnit
        {
            int Health { get; set; }

            void Accept(IVisitor visitor);
        }

        public interface IArmoredUnit
        {
            int Health { get; set; }

            void Accept(IVisitor visitor);
        }

        public class Marine : ILightUnit
        {
            public Marine()
            {
                this.Health = 100;
            }

            public int Health { get; set; }

            public void Accept(IVisitor visitor)
            {
                this.Health -= 21;
            }
        }

        public class Marauder : IArmoredUnit
        {
            public Marauder()
            {
                this.Health = 125;
            }
            public int Health { get; set; }

            public void Accept(IVisitor visitor)
            {
                this.Health -= 32;
            }
        }

        public class TankBullet : IVisitor
        {
            public void VisitLight(ILightUnit unit)
            {
                unit.Health -= 21;
            }

            public void VisitArmored(IArmoredUnit unit)
            {
                unit.Health -= 32;
            }
        }
    }
}
