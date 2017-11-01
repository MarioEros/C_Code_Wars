using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Molecule_to_atoms
    {
        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            Dictionary<string, int> diccio = new Dictionary<string, int>();
            while (formula.IndexOfAny(new char[] { '(', '[', '{' }) != -1)
            {
                List<String> lista = new List<string>(Regex.Split(formula, @"([\{\[\(][A-Za-z0-9]*[\}\]\)])"));
                lista.RemoveAll(a => a == " " || a == "");
                int exponente = 1;
                for (int i = 0; i < lista.Count; i++)
                {
                    if ((lista[i].StartsWith("(") && lista[i].EndsWith(")")) || (lista[i].StartsWith("[") && lista[i].EndsWith("]")) || (lista[i].StartsWith("{") && lista[i].EndsWith("}")))
                    {
                        if (i + 1 < lista.Count)
                        {
                            exponente = encuentraNum(lista[i + 1]);
                            lista[i + 1] = (exponente > 9 ? lista[i + 1].Substring(2) : exponente > 1 ? lista[i + 1].Substring(1) : lista[i + 1]);
                        }
                        List<String> Atomos = new List<string>(Regex.Split(lista[i], @"([A-Z][a-z]{0,2}[0-9]*)"));
                        Atomos.RemoveAll(a => a == "{" || a == "(" || a == "[" || a == " " || a == "" || a == ")" || a == "]" || a == "}");
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
                formula = lista[0];
            }
            List<String> AtSplit = new List<string>(Regex.Split(formula, "([A-Z][a-z]*[0-9]*)"));
            AtSplit.RemoveAll(a => a == "" || a == " ");
            foreach (String item in AtSplit)
            {
                diccio.AddOrSum(item);
            }
            return diccio;
        }
        public static int encuentraNum(string num)
        {
            int i = 0;
            while (i < num.Length && Char.IsDigit(num[i])) i++;
            return (i == 0 ? 1 : int.Parse(num.Substring(0, i)));
        }
    }
    public static class Dico
    {
        public static void AddOrSum(this Dictionary<string, int> dic, string At)
        {
            List<String> Frac = new List<String>(Regex.Split(At, @"([0-9]+)"));
            Frac.RemoveAll(b => b == " " || b == "");
            string key = Frac[0];
            int value = (Frac.Count > 1 ? int.Parse(Frac[1]) : 1);
            if (dic.ContainsKey(key)) dic[key] += value;
            else dic.Add(key, value);
        }
    }
}
