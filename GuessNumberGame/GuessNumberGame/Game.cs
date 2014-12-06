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
        
        public void CountGuessTimes()
        {
            guessTimes++;
        }

        //TODO
        public string CheckNumber(int[] number)
        {
            CountGuessTimes();
            throw new NotImplementedException();
        }
    }
}
