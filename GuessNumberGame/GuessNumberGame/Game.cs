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
        Random guessNumber;
        int guessTimes;

        public Game()
        {
            guessNumber = new Random();
            guessNumber.Next(0, 9999);
        }

        public void countGuessTimes()
        {
            guessTimes++;
        }

        //TODO
        public string checkNumber(int playersGuess)
        {
            countGuessTimes();
            int A = 0;
            int B = 0;

            var digits = new List<int>();

            //don't know yet what this piece of code does
            //source: http://stackoverflow.com/questions/4580261/integer-to-integer-array-c-sharp
            for (; playersGuess != 0; playersGuess /= 10)
            {
                digits.Add(playersGuess % 10);
            }

            var arr = digits.ToArray();
            Array.Reverse(arr);

            //TODO
            throw new NotImplementedException();
        }

        public void quitGame(Player p)
        {
            throw new NotImplementedException();
        }

        public void winner(Player p)
        {
            throw new NotImplementedException();
        }
    }
}
