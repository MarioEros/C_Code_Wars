using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Reversed_Words
    {
        public static string ReverseWords(string str)
        {
            return String.Join(" ",str.Split(' ').Reverse());
        }
    }
}
