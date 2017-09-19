using System;
using System.Collections;

namespace Pruebas
{
    public class Find_the_odd_int
    {
        public static int find_it(int[] seq)
        {
            ArrayList numeros = new ArrayList(seq);
            while (numeros.Capacity > 1)
            {
                if (numeros.IndexOf(numeros[0], 1) != -1)
                {
                    numeros.Remove(numeros.IndexOf(numeros[0], 1));
                    numeros.Remove(0);
                }
                else return (int)numeros[0];
            }
            return 0;
        }
    }
}