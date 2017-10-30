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
            // Do your science here :)
            Dictionary<string, int> diccio = new Dictionary<string, int>();
            List<string> formDiv = new List<string>(formula.Split(new char[] { '(', ')', '[', ']', '{', '}' }));
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
                int indice = 1;
                for (int i = palabra.Length - 1; i > -1; i--)
                {
                    int exp = 1;
                    if (valor[i] == 'd')
                    {
                        exp = exp * int.Parse(palabra[i].ToString());
                        if (valor[i - 1] == 'd')
                        {
                            exp += (palabra[i - 1] * 10);
                            if (valor[i - 2] == 'b')
                            {
                                diccio.Add(palabra.Substring(i - 3, 2), exp * indice);
                                i -= 3;
                            }
                            else
                            {
                                diccio.Add(palabra[i - 2].ToString(), exp * indice);
                                i -= 2;
                            }
                        }
                        else if (valor[i - 1] == 'b')
                        {
                            diccio.Add(palabra.Substring(i - 2, 2), exp * indice);
                            i -= 2;
                        }
                        else
                        {
                            diccio.Add(palabra[i - 1].ToString(), exp * indice);
                            i--;
                        }
                    }
                    else if (valor[i] == 'b')
                    {
                        diccio.Add(palabra.Substring(i - 1, 2), exp * indice);
                        i--;
                    }
                    else
                    {
                        diccio.Add(palabra[i].ToString(), exp * indice);
                    }
                }
                formDiv.RemoveAt(0);
            }
            return diccio;
        }
    }
}
