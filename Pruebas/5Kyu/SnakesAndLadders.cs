using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class SnakesAndLadders
    {
        int Player1 = 0;
        int Player2 = 0;

        bool IsPlayer1 = true;
        bool IsEnd = false;
        bool NextTurn = true;

        /*List<int> EscalPri = new List<int>() { 2, 7, 8, 15, 21, 28, 36, 51, 71, 78, 87 };
        List<int> EscalFin = new List<int>() { 38, 14, 31, 26, 42, 84, 44, 67, 91, 98, 94 };
        List<int> SerpPri = new List<int>() { 16, 46, 49, 62, 64, 74, 89, 92, 95, 99 };
        List<int> SerpFin = new List<int>() { 6, 25, 11, 19, 60, 53, 68, 88, 75, 80 };*/

        Dictionary<int, int> Obstaculos = new Dictionary<int, int>() { { 2, 38 }, { 7, 14 }, { 8, 31 }, { 15, 26 }, { 16, 6 }, { 21, 42 }, { 28, 84 }, { 36, 44 }, { 46, 25 }, { 49, 11 }, { 51, 67 }, { 62, 19 }, { 64, 60 }, { 71, 91 }, { 74, 53 }, { 78, 98 }, { 87, 94 }, { 89, 68 }, { 92, 88 }, { 95, 75 }, { 99, 80 } };

        public string play(int die1, int die2)
        {
            if (!IsEnd)
            {
                IsPlayer1 = NextTurn;
                if (die1 != die2) NextTurn = !IsPlayer1;
                Console.WriteLine((die1 != die2) + " " + (!IsPlayer1));
                if (IsPlayer1) Player1 += die1 + die2;
                else Player2 += die1 + die2;
                int Casilla = ComprobarPosicion(IsPlayer1 ? Player1 : Player2);
                if (Casilla == 100)
                {
                    IsEnd = true;
                    return "Player " + (IsPlayer1 ? 1 : 2) + " Wins!";
                }
                else if (Casilla > 100)
                {
                    Casilla = 100 - (Casilla - 100);
                    Casilla = ComprobarPosicion(Casilla);
                }
                if (IsPlayer1) Player1 = Casilla;
                else Player2 = Casilla;
                return "Player " + (IsPlayer1 ? 1 : 2) + " is on square " + Casilla;
            }
            return "Game over!";
        }

        private int ComprobarPosicion(int cas)
        {
            /*int Escalera = EscalPri.IndexOf(cas);
            int Serpiente = SerpPri.IndexOf(cas);
            if (Escalera == -1 && Serpiente == -1) return cas;
            else return (Escalera != -1 ? EscalFin[Escalera] : SerpFin[Serpiente]);*/
            if (Obstaculos.ContainsKey(cas)) return Obstaculos[cas];
            else return cas;
        }
    }
}
