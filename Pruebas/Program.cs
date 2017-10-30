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
                List<object> lista = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 };
                IEnumerable<int> numeros = List_Filtering.GetIntegersFromList(lista);
                foreach (var item in numeros)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
