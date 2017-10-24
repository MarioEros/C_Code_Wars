using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._7Kyu
{
    class Sum_of_two_lowest_positive_integers
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[0]+numbers[1];
        }
    }
}
