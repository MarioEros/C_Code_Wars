using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            string[] palabras = str.Split(Char.Parse(" "));
            string sol = "";
            StringBuilder aux;
            for (int i = 0; i < palabras.Length; i++)
            {
                    aux = new StringBuilder(palabras[i].Substring(1));
                    aux.Append(palabras[i][0] + "ay");
                    sol = sol+" " + aux.ToString();
            }
            return sol.Substring(1);
        }
    }
}
