using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._8Kyu
{
    class Calculate_Average
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length == 0) return 0;
            double hey = 0;
            foreach (double uno in array)
            {
                hey += uno;
            }
            return (hey / array.Length);
        }
    }
}
