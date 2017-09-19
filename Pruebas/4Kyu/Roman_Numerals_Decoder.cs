using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Roman_Numerals_Decoder
    {
        public static int Solution(String s)
        {

            int[] numeros = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                numeros[i] = Trans(s[i]);
            }

            int total = 0;
            for (int i = numeros.Length - 1; i > 0; i--)
            {
                if (numeros[i - 1] < numeros[i])
                {
                    numeros[i] = numeros[i] - numeros[i - 1];
                    numeros[i - 1] = 0;
                }
            }
            foreach (int p in numeros) total = total + p;
            return total;
        }

        static int Trans(char s)
        {
            switch (s)
            {
                case 'M': return 1000;
                case 'D': return 500;
                case 'C': return 100;
                case 'L': return 50;
                case 'X': return 10;
                case 'V': return 5;
                case 'I': return 1;
                default: return 0;
            }
        }
    }
}