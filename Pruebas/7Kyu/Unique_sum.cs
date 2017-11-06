using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Unique_sum
    {
        public static int? UniqueSum(List<int> lst)
        {
            return lst.Count == 0 ? null : (int?)lst.Distinct().Sum();
        }
    }
}
