using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Exes_and_Ohs
    {
        public static bool XO(string input)
        {
            return input.ToLower().Count(x=>x=='o')==input.ToLower().Count(x=>x=='x');
        }
    }
}
