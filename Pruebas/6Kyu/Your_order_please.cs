using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Your_order_please
    {
        public static string Order(string words)
        {
            if (words == "") return "";
            string[] palabros=words.Split(' ');
            List<string> sol = new List<string>(palabros.Length);
            for (int i = 1; i <= sol.Capacity; i++)sol.Add(palabros.Where(a => a.Contains(i.ToString())).First());
            return String.Join(" ",sol);
        }
    }
}
