using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas._7Kyu
{
    class Remove_Url
    {
        public static string RemoveUrlAnchor(string url)
        {
            return url.Substring(0, (-url.IndexOf('#') == 1 ? url.Length : url.IndexOf('#')));
        }
    }
}
