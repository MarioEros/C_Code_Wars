using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Pruebas._4Kyu
{
    class Sum_Strings
    {
        public static string sumStrings(string a, string b)
        {
            Console.WriteLine(a + b);
            a = a.Replace(" ", "");
            return ((a == "" ? 0 : BigInteger.Parse(a)) + (b == "" ? 0 : BigInteger.Parse(b))).ToString();
        }
    }
}
