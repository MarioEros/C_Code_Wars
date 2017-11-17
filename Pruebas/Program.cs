using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;

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
            Console.WriteLine(Reversed_Words.ReverseWords("hola majo"));
        }
        
    }
}
