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
            public MarineWeaponUpgrade(IMarine marine)
            {
                this.Damage = marine.Damage+1;
                this.Armor = marine.Armor;
            }
            public int Damage { get; set; }

            public int Armor { get; set; }
        }

        public class MarineArmorUpgrade : IMarine
        {
            public MarineArmorUpgrade(IMarine marine)
            {
                this.Armor = marine.Armor + 1;
                this.Damage = marine.Damage;
            }
            public int Damage { get; set; }

            public int Armor { get; set; }
        }
    }
}
