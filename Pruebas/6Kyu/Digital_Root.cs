using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Digital_Root
    {
        public int DigitalRoot(long n)
        {
            string sol = "";
            string auxiliar = n.ToString();
            while (auxiliar.Length != 1)
            {
                auxiliar = auxiliar.Sum(a => int.Parse(a.ToString())).ToString();
            }
            return int.Parse(auxiliar);
        }
    }
}
