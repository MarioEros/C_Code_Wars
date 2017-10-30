using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._7Kyu
{
    class Get_the_Middle_Character
    {
        public static string GetMiddle(string s)
        {
            return (s.Length % 2 == 0 ? s.ElementAt((s.Length / 2) - 1).ToString() + s.ElementAt(s.Length / 2).ToString() : s.ElementAt(s.Length / 2).ToString());
        }
    }
}
