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
            Dictionary<string, int> diccio = new Dictionary<string, int>();
            List<string> formDiv = new List<string>(formula.Split(new char[] { '(', ')', '[', ']', '{', '}' }));
            int indice = 1;
            while (formDiv.Count > 0)
            {
                string palabra = formDiv[0];
                char[] valor = new char[palabra.Length];
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (Char.IsDigit(palabra[i])) valor[i] = 'd';
                    else if (Char.IsLower(palabra[i])) valor[i] = 'b';
                    else if (Char.IsUpper(palabra[i])) valor[i] = 'A';
                    else
                    {
                        valor[i] = 'Z';
                        Console.WriteLine("Cosa ni numero,ni minus, ni Mayus");
                    }
                }
                for (int i = palabra.Length - 1; i > -1; i--)
                {
                    int exp = 1;
                    if (valor[i] == 'd')
                    {
                        exp = exp * int.Parse(palabra[i].ToString());
                        if (valor[i - 1] == 'd')
                        {
                            exp += (int.Parse(palabra[i-1].ToString()) * 10);
                            if (valor[i - 2] == 'b')
                            {
                                diccio.AddOrSum(palabra.Substring(i - 3, 2), exp * indice);
                                i -= 3;
                            }
                            else
                            {
                                diccio.AddOrSum(palabra[i - 2].ToString(), exp * indice);
                                i -= 2;
                            }
                        }
                        else if (valor[i - 1] == 'b')
                        {
                            diccio.AddOrSum(palabra.Substring(i - 2, 2), exp * indice);
                            i -= 2;
                        }
                        else
                        {
                            diccio.AddOrSum(palabra[i - 1].ToString(), exp * indice);
                            i--;
                        }
                    }
                    else if (valor[i] == 'b')
                    {
                        diccio.AddOrSum(palabra.Substring(i - 1, 2), exp * indice);
                        i--;
                    }
                    else
                    {
                        diccio.AddOrSum(palabra[i].ToString(), exp * indice);
                    }
                }
                formDiv.RemoveAt(0);
                if (formDiv.Count==0)break;
                palabra=formDiv[formDiv.Count-1];
                valor= new char[palabra.Length];
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (Char.IsDigit(palabra[i])) valor[i] = 'd';
                    else if (Char.IsLower(palabra[i])) valor[i] = 'b';
                    else if (Char.IsUpper(palabra[i])) valor[i] = 'A';
                    else
                    {
                        valor[i] = 'Z';
                        Console.WriteLine("Cosa ni numero,ni minus, ni Mayus");
                    }
                }
                for (int i = palabra.Length - 1; i > -1; i--)
                {
                    int exp = 1;
                    if (i==0 && valor[i] == 'd')
                    {
                        indice =indice*int.Parse(palabra[i].ToString());
                    }
                    else if (valor[i] == 'd')
                    {
                        exp = exp * int.Parse(palabra[i].ToString());
                        if (valor[i - 1] == 'd')
                        {
                            exp += (int.Parse(palabra[i - 1].ToString()) * 10);
                            if (valor[i - 2] == 'b')
                            {
                                diccio.AddOrSum(palabra.Substring(i - 3, 2), exp * indice);
                                i -= 3;
                            }
                            else
                            {
                                diccio.AddOrSum(palabra[i - 2].ToString(), exp * indice);
                                i -= 2;
                            }
                        }
                        else if (valor[i - 1] == 'b')
                        {
                            diccio.AddOrSum(palabra.Substring(i - 2, 2), exp * indice);
                            i -= 2;
                        }
                        else
                        {
                            diccio.AddOrSum(palabra[i - 1].ToString(), exp * indice);
                            i--;
                        }
                    }
                    else if (valor[i] == 'b')
                    {
                        diccio.AddOrSum(palabra.Substring(i - 1, 2), exp * indice);
                        i--;
                    }
                    else
                    {
                        diccio.AddOrSum(palabra[i].ToString(), exp * indice);
                    }
                }
                formDiv.RemoveAt(formDiv.Count-1);
            }
            return diccio;
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
