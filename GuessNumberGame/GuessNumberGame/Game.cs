using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Game : IGame
    {
        private Player player1;
        private Player player2;
        private int[] arr_winNumber;

        public Game()
        { }

        public Game(Player p1, Player p2)
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

        public Player Player1
        {
            get { return player1; }
            set { player1 = value; }
        }

        public Player Player2
        {
            get { return player2; }
            set { player2 = value; }
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

        public string CheckNumber(int[] playersGuess, Player player)
        {
            int A = 0;
            int B = 0;

            //we can get rid of the following if we pass directly playersGuess as int[]
            //don't know yet what this piece of code does
            //source: http://stackoverflow.com/questions/4580261/integer-to-integer-array-c-sharp
            //var digits = new List<int>();
            //for (; playersGuess != 0; playersGuess /= 10)
            //{
            //    digits.Add(playersGuess % 10);
            //}
            //var arr_playersGuess = digits.ToArray();
            //Array.Reverse(arr_playersGuess);

            for (int i = 0; i <= 3; i++)    //"i" picks cells from arr_playersGuess
            {
                if (playersGuess[i] == arr_winNumber[i])
                {
                    A++;
                    if (A == 4)
                    {
                        player1.GameCallback.OnWinner(player);
                        player2.GameCallback.OnWinner(player);
                        return "Player " + player.Username + "wins the game!";
                    }
                }
                for (int j = 0; j <= 3; j++)    //"j" picks cells from arr_winNumber
                {
                    if (i == j)
                        break;

                    if (playersGuess[i] == playersGuess[j])
                    {
                        B++;
                    }
                }
            }

            return A.ToString() + " numbers correct \n" + B.ToString() + "numbers in wrong place";
        }

        public void QuitGame(Player player)
        {
            player2.GameCallback.OnGameInterupted(player);
            player1.GameCallback.OnGameInterupted(player);
        }
    }
}
