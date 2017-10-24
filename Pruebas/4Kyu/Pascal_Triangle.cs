using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Pascal_Triangle
    {
        public static List<int> PascalsTriangle(int n)
        {
            List<int> Res = new List<int>() { 1 };
            List<int> Ayuda = new List<int>(1) { 1 };
            List<int> Aux = new List<int>();
            for (int i = 1; i < n; i++)
            {
                Aux.Clear();
                Aux.AddRange(Ayuda);
                Ayuda.Add(0);
                for(int j = 1; j < Ayuda.Count; j++)
                {
                    Ayuda[j] += Aux[j - 1];
                }
                Res.AddRange(Ayuda);
            }
            return Res;
        }
    }
}
