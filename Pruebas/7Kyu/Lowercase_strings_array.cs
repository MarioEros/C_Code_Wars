using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._7Kyu
{
    class Lowercase_strings_array
    {
        public static object[] ArrayLowerCase(object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    arr[i] = ((string)arr[i]).ToLower();
                }
                catch (Exception e) { }
            }
            return arr;
        }
    }
}
