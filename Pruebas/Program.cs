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
            FileStream fs = new FileStream(@"Pruebas.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            //StreamWriter sw= new StreamWriter(fs);
            //sw.WriteLine("hola caracola");
            //sw.Close();
            /*while(true)
            {
                string pruebas = Console.ReadLine();//sr.ReadLine();
                if ("FIN".Equals(pruebas.ToUpper())) break;
                //string[] divi = pruebas.Split('*');
                //int[] num = new int[divi.Length];
                //for (int i = 0; i < divi.Length; i++) num[i] = int.Parse(divi[i]);
                
            }*/
            Console.WriteLine(Sum_of_odd_cubed_numbers.CubeOdd(new int[] { -3, -2, 2, 3}));
        }
        public static int encuentraNum(string num)
        {
            int i = 0;
            while (i<num.Length&&Char.IsDigit(num[i])) i++;
            return (i==0?1:int.Parse(num.Substring(0,i)));
        }
    }
}
