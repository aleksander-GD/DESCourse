using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGameSimulator
{
    class Player
    {
        private string playerName;
        private int playerScore;
        
        /// <summary>
        /// Constructor for Player to construct with a specified name
        /// </summary>
        /// <param name="playerName"> string parameter to define the player name </param>
        public Player(string playerName)
        {
            
            this.playerName = playerName;
            this.playerScore = 0;
        }

        /// <summary>
        /// Add points to playerScore attribute by +1.
        /// </summary>
        public void AddPointToPlayer()
        {
            this.playerScore++;
        }

        /// <summary>
        /// Get the specified players score
        /// </summary>
        /// <returns> Returns an int value based on the score </returns>
        public int GetPlayerScore()
        {
            return this.playerScore;
        }

        /// <summary>
        /// Get player name
        /// </summary>
        /// <returns> Returns string based on the player name </returns>
        public string GetPlayerName()
        {
            return this.playerName;
        }

        


    }
}
