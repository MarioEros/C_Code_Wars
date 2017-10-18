using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Wo_lo_loooooo
    {
        public static string AlphabetWar(string fight)
        {
            char[] EndBattle = new char[fight.Length];
            for (int i = 0; i < fight.Length; i++)
            {
                EndBattle[i] = fight[i];
            }
            int sum = 0;
            for (int i = 0; i < EndBattle.Length; i++)
            {
                if (fight[i] == 't' || fight[i] == 'j')
                {
                    try
                    {
                        if ((EndBattle[i] == 't' && EndBattle[i + 2] == 'j') || (EndBattle[i] == 'j' && EndBattle[i + 2] == 't'))
                        {
                            i += 1;
                        }
                        else
                        {
                            EndBattle[i + 1] = Wololize(EndBattle[i], EndBattle[i + 1]);
                            i++;
                        }

                    }
                    catch (Exception e)
                    {
                        try
                        {
                            EndBattle[i + 1] = Wololize(EndBattle[i], EndBattle[i + 1]);
                            i++;
                        }
                        catch(Exception ee) { }
                    }
                }
                else if (i + 1 < EndBattle.Length)
                {
                    EndBattle[i] = Wololize(EndBattle[i + 1], EndBattle[i]);
                }
            }
            foreach (char item in EndBattle)
            {
                sum += ComparePowa(item);
            }
            return (sum<0? "Left side wins!":sum>0? "Right side wins!": "Let's fight again!");

        }
        public static char Wololize(char priest, char wol)
        {
            switch (priest)
            {
                case 'j':
                    switch (wol)
                    {
                        case 'w': return 'm';
                        case 'p': return 'q';
                        case 'b': return 'd';
                        case 's': return 'z';
                        case 't': return 't';
                        default: return wol;
                    }
                case 't':
                    switch (wol)
                    {

                        case 'm': return 'w';
                        case 'q': return 'p';
                        case 'd': return 'b';
                        case 'z': return 's';
                        case 'j': return 'j';
                        default:return wol;
                    }
                default: return wol;
            }
        }
        public static int ComparePowa(char let)
        {
            switch (let)
            {
                case 'w': return -4;
                case 'p': return -3;
                case 'b': return -2;
                case 's': return -1;
                case 't': return 0;
                case 'm': return 4;
                case 'q': return 3;
                case 'd': return 2;
                case 'z': return 1;
                case 'j': return 0;
                default: return 0;
            }

        }
    }
}
