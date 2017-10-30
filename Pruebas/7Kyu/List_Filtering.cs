using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class List_Filtering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> num = new List<int>();
            foreach(object numero in listOfItems)
            {
                try { num.Add((int)numero); } catch (Exception e){ }
            }
            return num;
        }
    }
}
