using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class zero_balanced_Array
    {
        public static bool IsZeroBalanced(List<int> xs)
        {
            if(xs.Count<1)return false;
            List<int> res = new List<int>();
            if (xs.Sum() != 0) return false;
            foreach (int item in xs)
            {
                if (res.IndexOf(-item) != -1) res.Remove(-item);
                else if (item == 0){}
                else res.Add(item);
            }
            return res.Count == 0;
        }
    }
}
