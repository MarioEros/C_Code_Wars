using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._7Kyu
{
    class Reversed_Strings
    {
        public static string Solution(string str)
        {
            string sol = "";
            for (int i = str.Length - 1; i >= 0; i--) sol = sol + str[i];
            return sol;
        }
    }
}
