using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pruebas
{
    class IP_Validation
    {
        public static bool is_valid_IP(string IpAddres)
        {
            try
            {
                Regex pat = new Regex("0[0-9]+");
                string[] numeros=IpAddres.Split('.');
                if (numeros.Length != 4) return false;
                foreach (string num in numeros)
                {
                    if (num == "") return false;
                    if (pat.IsMatch(num)) return false;
                    if (num.Contains(" ")) return false;
                    if (int.Parse(num) > 255|| int.Parse(num) <= 0) return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
