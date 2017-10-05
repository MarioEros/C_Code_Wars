using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Message_from_Aliens
    {
        public static string Decode(string m)
        {
            char[] caractitos = { ']', '}', '.', '{', '\'', '+' };
            string[] sol = m.Split(caractitos);
            string solucionqueflipas = "";
            foreach (string cul in sol) solucionqueflipas = Alfa(cul) + solucionqueflipas;
            return solucionqueflipas;
        }

        public static string Alfa(string hey)
        {
            switch (hey)
            {
                case "/\\": return "a";
                case "3": return "b";
                case "(": return "c";
                case "|)": return "d";
                case "[-": return "e";
                case "/=": return "f";
                case "(_,": return "g";
                case "|-|": return "h";
                case "|": return "i";
                case "_T": return "j";
                case "/<": return "k";
                case "|_": return "l";
                case "|\\/|": return "m";
                case "|\\|": return "n";
                case "()": return "o";
                case "|^": return "p";
                case "()_": return "q";
                case "/?": return "r";
                case "_\\~": return "s";
                case "~|~": return "t";
                case "|_|": return "u";
                case "\\/": return "v";
                case "\\/\\/": return "w";
                case "><": return "x";
                case "`/": return "y";
                case "~/_": return "z";
                case "__": return " ";
                case "": return "";
            }
            return "";
        }
    }
}


/*
 * "hello", ]   ()     ]    |_  ]]    |_  ]]    [-  ]     |-|  ]
 * 
 *                 |-| [- |_ |_ ()
 *                 
 * 
 * "blip",  {        |^      {     |        {{      |_        {       ]3     {
 * 
 *                  ]3 |_ | |^
 *                  
 * 
 * "die stupid people", ..  [-  .   |_  .   |^  ....    ()  .   [-  .   |^. __   .. |)   ...    |   .  |^    .   |_|    ..  ~|~   .  _\\~  . __   ...    [-  ..    |   .  |)        ..
 *                  
 *                  |) | [-  _\\~ ~|~ |.| |^ |)  |^ [- () |^ |_ [-
 * 
 * 
 * "your brain looks delicious", '''_\\~'|_|'()'|''('|'|_'[-'|)''__'_\\~'/<'()'()'|_'''__'|\\|'|''/\\'/?']3'__''/?'|_|''()'`/''
 * 
 * "try to find duplicated kata", }/\\}~|~}/\\}/<}__}|)}}}[-}~|~}/\\}(}|}|_}|^}|_|}|)}__}|)}}}|\\|}|}/=}__}()}}}~|~}__}`/}/?}}~|~}
*/