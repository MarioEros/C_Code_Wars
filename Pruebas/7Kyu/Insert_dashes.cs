using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Insert_dashes
    {
        public static string InsertDash(int num)
        {
            string sol = "";
            string numerico = "" + num;
            for(int i = 0; i < numerico.Length - 1; i++)
            {
                if (numerico[i] % 2 != 0 && numerico[i + 1] % 2 != 0) sol += numerico[i] + "-";
                else sol += numerico[i];
            }
            sol += numerico[numerico.Length - 1];
            return sol;
        }
    }
}
