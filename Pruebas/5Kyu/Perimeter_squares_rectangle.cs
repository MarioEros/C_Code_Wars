using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._5Kyu
{
    class Perimeter_squares_rectangle
    {
        public static BigInteger perimeter(BigInteger n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            List<BigInteger> fibo = new List<BigInteger>();
            fibo.Add(new BigInteger(1));
            fibo.Add(new BigInteger(1));
            for(int i= 2; i < n; i++)
            {
                fibo.Add(new BigInteger(i) + fibo[i - 1]);
            }
            BigInteger num = new BigInteger();
            foreach (BigInteger uno in fibo) num += uno;
            return num*4;
        }
    }
}
