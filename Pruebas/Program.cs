using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Eros\source\repos\C_Code_Wars\Pruebas\TextoPruebas.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //StreamWriter sw= new StreamWriter(fs);
            //sw.WriteLine("hola caracola");
            //sw.Close();
            StreamReader sr = new StreamReader(fs);
            for (int m = 0;m<5;m++)
            {
                FileStream fss = new FileStream(@"Pruebas.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fss);
                string pruebas = sr.ReadLine();
                sw.WriteLine(pruebas);
                //if ("FIN".Equals(pruebas.ToUpper())) break;
                //string[] divi = pruebas.Split('*');
                //int[] num = new int[divi.Length];
                //for (int i = 0; i < divi.Length; i++) num[i] = int.Parse(divi[i]);
                Dictionary<string, int> diccio = new Dictionary<string, int>();
                //(C5H5)    Fe  (CO)    2CH3
                Console.WriteLine(pruebas);
                while (pruebas.IndexOfAny(new char[] { '(', '[', '{' }) != -1)
                {
                    List<String> lista = new List<string>(Regex.Split(pruebas, @"([\{\[\(][A-Za-z0-9]*[\}\]\)])"));
                    lista.RemoveAll(a => a == " " || a == "");
                    int exponente = 1;
                    for (int i = 0; i < lista.Count; i++)
                    {
                        //(C5H5),(CO)
                        if ((lista[i].StartsWith("(") && lista[i].EndsWith(")")) || (lista[i].StartsWith("[") && lista[i].EndsWith("]")) || (lista[i].StartsWith("{") && lista[i].EndsWith("}")))
                        {
                            if (i + 1 < lista.Count)
                            {
                                exponente = encuentraNum(lista[i + 1]);
                                lista[i + 1] = (exponente > 9 ? lista[i + 1].Substring(2) : exponente > 1 ? lista[i + 1].Substring(1) : lista[i + 1]);
                            }
                            List<String> Atomos = new List<string>(Regex.Split(lista[i], @"([A-Z][a-z]{0,2}[0-9]*)"));
                            Atomos.RemoveAll(a => a == "{" || a == "(" || a == "[" || a == " " || a == "" || a == ")" || a == "]" || a == "}");
                            //C5    H5
                            if (exponente != 1)
                            {
                                for (int j = 0; j < Atomos.Count; j++)
                                {
                                    List<String> At = new List<String>(Regex.Split(Atomos[j], @"([0-9]+)"));
                                    At.RemoveAll(b => b == " " || b == "");
                                    Atomos[j] = At[0] + (At.Count > 1 ? "" + (int.Parse(At[1]) * exponente) : "" + exponente);
                                }
                            }
                            if (i == 0)
                            {
                                lista[0] = "";
                                Atomos.ForEach(a => lista[0] += a);
                                if (1 < lista.Count)
                                {
                                    lista[0] += lista[1];
                                    lista.RemoveAt(1);
                                    i--;
                                }
                            }
                            else
                            {
                                Atomos.ForEach(a => lista[i - 1] += a);
                                lista.RemoveAt(i);
                                if (i < lista.Count)
                                {
                                    lista[i - 1] += lista[i];
                                    lista.RemoveAt(i);
                                    i--;
                                }
                                i--;
                            }
                        }
                    }
                    pruebas = lista[0];
                }
                List<String> AtSplit = new List<string>(Regex.Split(pruebas, "([A-Z][a-z]*[0-9]*)"));
                AtSplit.RemoveAll(a => a == "" || a == " ");
                foreach (String item in AtSplit)
                {
                    diccio.AddOrSum(item);
                }
                foreach (var item in diccio)
                {
                    Console.WriteLine(item.Key+"-->"+item.Value);
                }
                Console.WriteLine("-------------------------------------");
            }
            Console.ReadKey();
            sr.Close();
            fs.Close();
        }
        public static int encuentraNum(string num)
        {
            int i = 0;
            while (i<num.Length&&Char.IsDigit(num[i])) i++;
            return (i==0?1:int.Parse(num.Substring(0,i)));
        }
    }
}
