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
                /*List<int>res = new List<int>();
                res.Add(1);
                res.Add(2);
                res.Add(4);
                res.Add(3);
                res.Add(0);
                res.Add(0);
                res.Add(-4);
                res.Add(-2);
                res.Add(-1);
                res.Add(-3);
                foreach (int item in res)
                {
                    Console.WriteLine(item);
                }
                string hola = @"C:\Usuarios\GenteSuperGuay";
                string quepa = "C:\\Usuarios\\GenteSuperGuay";
                Console.WriteLine(@"C:\Usuarios\GenteSuperGuay");
                Console.WriteLine(hola);
                Console.WriteLine(quepa+@"\YoMismo");*/

                Console.WriteLine(IP_Validation.is_valid_IP(pruebas));


            }
        }
    }
}
