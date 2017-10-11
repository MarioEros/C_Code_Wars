using System;

namespace Pruebas
{
    public static class CamelCase_Method
    {

        public static string CamelCase(this string str)
        {
            if (str == "") return "";
            String[] Dividida = str.Split(char.Parse(" "));
            String sol = "";
            foreach (String item in Dividida)
            {
                if (item == "") sol += "";
                else sol = sol + char.ToString(item[0]).ToUpper() + item.Substring(1).ToLower();
            }
            return sol;
        }
    }
}
