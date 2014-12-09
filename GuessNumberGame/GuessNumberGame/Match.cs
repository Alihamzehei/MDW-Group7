using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Match
    {
        List<Player> PlayersList;
        Player player1;
        Player player2;
        int[] arr_winNumber;

        public Match(Player p1, Player p2)
        {
            this.player1 = p1;
            this.player2 = p2;
            this.arr_winNumber = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Random rnd = new Random();
                arr_winNumber[i] = rnd.Next(0, 9);
            }
        }

        public Player Player
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string CheckNumber(int playersGuess)
        {
            int A = 0;
            int B = 0;

            //we can get rid of the following if we pass directly playersGuess as int[]

            //don't know yet what this piece of code does
            //source: http://stackoverflow.com/questions/4580261/integer-to-integer-array-c-sharp
            var digits = new List<int>();
            for (; playersGuess != 0; playersGuess /= 10)
            {
                digits.Add(playersGuess % 10);
            }
            var arr_playersGuess = digits.ToArray();
            Array.Reverse(arr_playersGuess);

            for (int i = 0; i <= 3; i++)    //"i" picks cells from arr_playersGuess
            {
                if (arr_playersGuess[i] == arr_winNumber[i])
                {
                    A++;
                    if (A == 4)
                    {

                    }
                }
                for (int j = 0; j <= 3; j++)    //"j" picks cells from arr_winNumber
                {
                    if (i == j)
                        break;

                    if (arr_playersGuess[i] == arr_playersGuess[j])
                    {
                        B++;
                    }
                }
            }

            return A.ToString() + " numbers correct \n" + B.ToString() + "numbers in wrong place";
        }


    }
}
