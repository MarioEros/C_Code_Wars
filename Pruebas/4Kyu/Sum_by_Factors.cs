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
            int max = 0;
            foreach (int numM in lst) if (Math.Abs(numM) > max) max = Math.Abs(numM);
            string sol = "";
            int sum = 0;
            for (int i = 2; i <= max; i = nextPrime(i))
            {
                sum = 0;
                foreach(int numerito in lst)
                {
                    if (numerito % i == 0) sum += numerito;
                }
                if(sum!=0)sol +="("+i+" "+sum+")";
            }
            return sol;
        }
        private static bool isPrime(int x)
        {
            int max = (int)Math.Sqrt(x);
            for (int i=2;i<=max&& (x/i>=i);i++) if (x % i == 0)
            {
                int q = x / i;
                if (q < i)
                    return true;
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        public static int nextPrime(int x)
        {
            while (!isPrime(++x));
            return x;
        }
    }
}
