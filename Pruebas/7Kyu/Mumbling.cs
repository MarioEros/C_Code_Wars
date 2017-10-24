using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._7Kyu
{
    class Mumbling
    {
        public static String Accum(string s)
        {
            string Sol = "";
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Sol += (j==0?char.ToUpper(s[i]):char.ToLower(s[i]));
                }
                if (i == s.Length - 1) { }
                else Sol += "-";
            }
            return Sol;
        }
    }
}
