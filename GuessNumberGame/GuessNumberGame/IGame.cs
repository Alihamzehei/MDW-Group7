using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    [ServiceContract(Namespace = "Server", CallbackContract = typeof(IGameCallBack))]
    public interface IGame
    {
        /// <summary>
        /// Checks the guess of the player.
        /// </summary>
        /// <param name="number">The player's guess in int array.</param>
        /// <param name="player">The player who made the guess.</param>
        /// <returns>A string in which "A" is correct numbers and "B" rights in wrong places.</returns>
        [OperationContract]
        string CheckNumber(int[] number,Player player);

        /// <summary>
        /// It is called when a player leaves the game.
        /// </summary>
        /// <param name="player">The player that left.</param>
        [OperationContract]
        void QuitGame(Player player);
    }

    public interface IGameCallBack
    {
        /// <summary>
        /// It is called when a player leaves the game.
        /// </summary>
        /// <param name="player">The player that left.</param>
        [OperationContract]
        void OnGameInterupted(Player player);

        /// <summary>
        /// It is called when a player wins a game.
        /// </summary>
        /// <param name="player">The winner of the game.</param>
        [OperationContract]
        void OnWinner(Player player);

        /// <summary>
        /// It is called every time the other player makes a guess.
        /// </summary>
        /// <param name="guessResult">The result of other player's guess.</param>
        [OperationContract]
        void OnOpponentGuess(string guessResult);
    }
}
