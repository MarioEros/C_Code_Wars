using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Find_The_Parity_Outlier
    {
        public static int Find(int[] integers)
        {
            return (integers.Where(a=>a%2!=0).Count()==1? integers.Where(a => a % 2 != 0).First(): integers.Where(a => a % 2 == 0).First());
        }
    }
}
