using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Playing_with_digits
    {
        public static long digPow(int n, int p)
        {
            string numeros = n.ToString();
            double chachi = 0;
            for (int x = 0; x < numeros.Length; x++) chachi += Math.Pow(int.Parse(Char.ToString(numeros[x])),p+x);
            return (chachi%n==0?(long)chachi/n:-1);
        }
    }
}
