using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Weight_for_weight
    {
        public static string orderWeight(string strng)
        {
            string[] numletricos = strng.Split(' ');
            List<NumLetra> orden = new List<NumLetra>(
                from x in numletricos
                let a = Regex.Split(x,"([0-9])").Where(b=>b!="").
                Select(a=>int.Parse(a)).
                Sum()
                select new NumLetra(int.Parse(x), x));
            orden.Sort();
            numletricos = (from x in orden select x.getnum);
            return String.Join(" ",orden);
        }
        private class NumLetra : IComparable<NumLetra>
        {
            private int num;
            private string letra;

            public NumLetra(int num,string let)
            {
                this.num = num;
                this.letra = let;
            }

            public int getnum()
            {
                return num;
            }

            public int CompareTo(NumLetra other)
            {
                if (this.num == other.num) return this.letra.CompareTo(other.letra);
                return this.num.CompareTo(other.num);
            }
        }
    }
}
