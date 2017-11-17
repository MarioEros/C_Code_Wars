using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._6Kyu
{
    class Array_diff
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> sol = a.ToList();
            sol.RemoveAll(x => b.Contains(x));
            return sol.ToArray();
        }
    }
}
