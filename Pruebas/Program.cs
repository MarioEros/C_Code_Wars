using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

                //List<String> lista = new List<string>(Regex.Split(pruebas, @"([\{\[\(][A-Za-z0-9]*[\}\]\)])")); List<String> lista2 = new List<string>();
                /*List<String> lista = new List<string>(Regex.Split(pruebas, @"([\{\[\(][A-Za-z0-9]*[\}\]\)])"));
                for (int i =0; i < lista.Count;i++)
                {
                    Console.WriteLine("L: "+lista[i]);
                    Console.WriteLine("-->"+(i+1<lista.Count?encuentraNum(lista[i+1]):1));
                }*/
                /*Console.WriteLine("--------------------------");
                lista.RemoveAll(a => a == "{" || a == "(" || a == "[" || a == " " || a == ")" || a == "]" || a == "}");
                foreach (string item in lista)
                {
                    Console.WriteLine(item);
                }*/
                List<String> lista = new List<string>(Regex.Split(pruebas, @"([\{\[\(][A-Za-z0-9]*[\}\]\)])"));
                lista.RemoveAll(a => a == " " || a == "");
                foreach (string item in lista)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static int encuentraNum(string num)
        {
            for(int i = 0; i < num.Length; i++)
            {
                if (!char.IsDigit(num[i])) break;
                else if (i + 1 < num.Length && char.IsDigit(num[i+1])) return int.Parse(num.Substring(i, 2));
                else return int.Parse(num.Substring(i, 1));
            }
            return 1;
        }
    }
}
