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
                List<int>res = new List<int>();
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

                //for (int i = 0; i < divi.Length; i++) num[i] = int.Parse(divi[i]);
                Console.WriteLine(zero_balanced_Array.IsZeroBalanced(res));

            }
        }
    }
}
