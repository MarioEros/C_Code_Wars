using System;

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
                string[] divi = pruebas.Split('-');
                int[] num = new int[divi.Length];
                for (int i = 0; i < divi.Length; i++) num[i] = int.Parse(divi[i]);

                Console.WriteLine(Find_the_odd_int.find_it(num));

            }
        }
    }
}
