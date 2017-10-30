using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class PatternCraft_Decorator
    {

        public interface IMarine
        {
            int Damage { get; set; }
            int Armor { get; set; }
        }

        public class Marine : IMarine
        {
            public Marine(int damage, int armor)
            {
                Damage = damage;
                Armor = armor;
            }

            public int Damage { get; set; }
            public int Armor { get; set; }
        }

        public class MarineWeaponUpgrade : IMarine
        {
            private IMarine marine;//

            public MarineWeaponUpgrade(IMarine marine)
            {
                this.marine.Damage = marine.Damage+1;
                this.marine.Armor = marine.Armor;
            }
            public int Damage
            {
                get
                {
                    return marine.Damage;
                }
                set
                {
                    this.Damage = value;
                }
            }

            public int Armor
            {
                get
                {
                    return marine.Armor;
                }
                set
                {
                    this.Armor = value;
                }
            }
        }

        public class MarineArmorUpgrade : IMarine
        {
            private IMarine marine;

            public MarineArmorUpgrade(IMarine marine)
            {
                this.marine.Armor = marine.Armor + 1;
                this.marine.Damage = marine.Damage;
            }

            public int Damage
            {
                get
                {
                    return marine.Damage;
                }
                set
                {
                    this.Damage = value;
                }
            }

            public int Armor
            {
                get
                {
                    return marine.Armor;
                }
                set
                {
                    this.Armor = value;
                }
            }
        }
    }
}
