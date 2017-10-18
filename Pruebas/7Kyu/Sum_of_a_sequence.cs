using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._7Kyu
{
    class Sum_of_a_sequence
    {
        public static int SequenceSum(int start, int end, int step)
        {
            int sum = 0;
            for (int i = start; i <= end; i+=step) sum +=i;
            return sum;
        }
    }
}
