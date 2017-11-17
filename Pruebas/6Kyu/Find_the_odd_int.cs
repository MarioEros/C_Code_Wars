using System.Collections;
using System.Linq;

namespace Pruebas
{
    public class Find_the_odd_int
    {
        public static int find_it(int[] seq)
        {
            return (from x in seq where seq.Count(a=>a==x) % 2 == 1 select x).First();
        }
    }
}