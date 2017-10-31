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
            //UubFe(Al(P(Mg(NBeArLiNKBe)3MgOUuu(OSiCaLiULi)4(MgUtnFSArUup)8)13((FeFePSi)3Uuo(SUAr)12)9(LiClUbn(UuoUUub)8(UqnAlUPUuoNa)8(UupArUtnClFeN)5(BeUubK)5)6((HUuuCa)2ArUqnUup)12(F(NBeUunBe)11(HCBe)12)6O)8((P(UuuUqnNUuu)2(UubPUbnFeUtnUtn)12(UbnBeMgArNaH)4K(UuuUunUUUubNUup)13)12P(Al(MgSiUuuFUtnBeHe)7(UubUunUuoNeNK)8U(UqnUuoOUbn)9HBe)12)2C)8Uuo(((NLiLiAlSiUun)8SiUP((NaBeBSUun)2Uup(UbnUKSiH)7)6((CUuoClNUupK)2(ClLiNeHArSiHe)11HHe(MgNaUuoSAr)7)7)3UubMgMg((BeC(UuuCArMg)10Si)12((UtnUtnKFeNe)2(HUtnUunPFeKCa)13Ar)10F)6(ClFF(Be(UunFOCaUbn)5Uqn)5FBCl)3(((HUBeNa)4Mg(PHeUup)5(AlNeMgHUuo)13)12KOUubUtnK)5)10BMg
            //System.IndexOutOfRangeException : Index was outside the bounds of the array.
            //C6H12O6       Expected: < [C, 6], [H, 12], [O, 6] >
            //              But was:  < [O, 6], [H, 492], [C, 6] >
            //(C5H5)Fe(CO)2CH3 da fallo porque aplica el exp del lado derecho a ambos parentesis
            //((H)2[O])
            Dictionary<string, int> diccio = new Dictionary<string, int>();
            List<String> lista = new List<string>(Regex.Split(formula, @"([\{\[\(][A-Za-z0-9]*[\}\]\)])"));
            lista.RemoveAll(a => a == " "|| a== "");
            //(C5H5)    Fe  (CO)    2CH3
            while (lista.Count > 1)
            {
                int exponente = 1;
                for (int i = 0; i > lista.Count; i++)
                {
                    //(C5H5),(CO)
                    if ((lista[i].StartsWith("(") && lista[i].EndsWith(")"))||(lista[i].StartsWith("[") && lista[i].EndsWith("]"))||(lista[i].StartsWith("{") && lista[i].EndsWith("}")))
                    {
                        if(i+1<lista.Count)exponente = encuentraNum(lista[i + 1]);
                        List<String> Atomos = new List<string>(Regex.Split(lista[i], @"([A-Z][a-z]{0,2}[0-9]*)"));
                        Atomos.RemoveAll(a => a == "{" || a == "(" || a == "[" || a == " " || a == "" || a == ")" || a == "]" || a == "}");
                        //C5    H5
                    }
                }
            }
            return diccio;
        }
        public static int encuentraNum(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (!char.IsDigit(num[i])) break;
                else if (i + 1 < num.Length && char.IsDigit(num[i + 1])) return int.Parse(num.Substring(i, 2));
                else return int.Parse(num.Substring(i, 1));
            }
            return 1;
        }
    }
    public static class Dico
    {
        public static void AddOrSum(this Dictionary<string, int> dic, string Ele, int ind)
        {
            if (dic.ContainsKey(Ele)) dic[Ele] = dic[Ele] + ind;
            else dic.Add(Ele, ind);
        }
    }
}
