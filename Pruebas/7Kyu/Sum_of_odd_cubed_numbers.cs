using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Sum_of_odd_cubed_numbers
    {
        public static int CubeOdd(int[] arr)
        {
            return arr.Where(a=>a % 2 != 0).Select(a=>a*a*a).Sum();
        }
    }
}
