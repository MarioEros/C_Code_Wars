using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Sum_by_Factors
    {
        public static string sumOfDivided(int[] lst)
        {
            int ChachoPrimo = nextPrime(5);
            return ""+ChachoPrimo;
        }
        private static bool isPrime(int x)
        {
            int max = (int)Math.Sqrt(x);
            for (int i=2;i<=max&& (x/i>i);i++) if (x % i == 0) return true;
            {
                int q = x / i;
                if (q < i)
                    return true;
                if (x % i == 0)
                    return false;
            }
        }

        private static int nextPrime(int x)
        {
            while (!isPrime(x)) x++;
            return x;
        }
    }
}
