using System;
using System.Collections.Generic;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string pruebas = Console.ReadLine();
                if ("FIN".Equals(pruebas.ToUpper())) break;
                //string[] divi = pruebas.Split('*');
                //int[] num = new int[divi.Length];
                //for (int i = 0; i < divi.Length; i++) num[i] = int.Parse(divi[i]);

                Console.WriteLine(IP_Validation.is_valid_IP(pruebas));


            }
        }
    }
}
