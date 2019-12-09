using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGameSimulator
{
    class Game
    {
        private Boolean isplaying;
        private Player player1;
        private Player player2;
        private ScoreRules rules;

        /// <summary>
        /// Game constructor to define 2 player names to simulate the gameplay
        /// </summary>
        /// <param name="playerName1"> Type string, name of first player </param>
        /// <param name="playerName2">Type string, name of second player </param>
        public Game(string playerName1, string playerName2)
        {
            this.isplaying = true;
            this.rules = new ScoreRules();                   // Declare the rules
            this.player1 = new Player(playerName1);     // Instantiate the first player when creating the game
            this.player2 = new Player(playerName2);     // Instantiate the second player when creating the game

        }

        /// <summary>
        /// Method to check if the game is being played
        /// </summary>
        /// <returns> True if the game is playing, false otherwise </returns>
        public Boolean IsPlaying()
        {
            return this.isplaying;
        }

        /// <summary>
        /// Method to set the current boolean value for the game.
        /// </summary>
        /// <param name="playing"> Boolean value to end game, True if the the game is being played, false otherwise </param>
        internal void SetIsPlaying(bool playing)
        {
            this.isplaying = playing;
        }

        public int CheckFinished()
        {
            if (player1.GetPlayerScore() + player2.GetPlayerScore() >= 4)
            {
                if (player1.GetPlayerScore() >= player2.GetPlayerScore() + 2)
                {
                    return 1;
                }
                if (player1.GetPlayerScore() + 2 <= player2.GetPlayerScore())
                {
                    return 2;
                }

            }
            return 0;
        }

        /// <summary>
        /// Method to print the result and mean while checking up if the result is a deuce of advantage. If that is the case
        /// it saves results into the temp array based on the result and returns it.
        /// </summary>
        /// <returns> returns String[] type of the Print result </returns>
        public String[] PrintResult()
        {
            string[] temp = new string[2];

            // checks total score if its not even
            if (player1.GetPlayerScore() + player2.GetPlayerScore() <= 5)
            {
                temp[0] = player1.GetPlayerName() + " has " + player1.GetPlayerScore() + " which is " + rules.getCurrentScore(player1.GetPlayerScore());
                temp[1] = player2.GetPlayerName() + " has " + player2.GetPlayerScore() + " which is " + rules.getCurrentScore(player2.GetPlayerScore());
            }
            // checks total score it is even and some conditions apply to win the game
            else if (player1.GetPlayerScore() + player2.GetPlayerScore() >= 6)
            {
                // checks if decuce
                if (player1.GetPlayerScore() == player2.GetPlayerScore())
                {
                    temp[0] = player1.GetPlayerName() + " has " + player1.GetPlayerScore() + " and " + player2.GetPlayerName() + " has " + player2.GetPlayerScore();
                    temp[1] = "score is deuce";
                }
                // Checks if advantage
                else if (player1.GetPlayerScore() > player2.GetPlayerScore())
                {
                    temp[0] = player1.GetPlayerName() + " has " + player1.GetPlayerScore() + " and " + player2.GetPlayerName() + " has " + player2.GetPlayerScore();
                    temp[1] = player1.GetPlayerName() + " has advantage";
                }
                else if (player1.GetPlayerScore() < player2.GetPlayerScore())
                {
                    temp[0] = player1.GetPlayerName() + " has " + player1.GetPlayerScore() + " and " + player2.GetPlayerName() + " has " + player2.GetPlayerScore();
                    temp[1] = player2.GetPlayerName() + " has advantage";
                }
            }
            return temp;
        }

        /// <summary>
        /// This method starts the tennis game where it generates a random result number,
        /// and also checks based on if a game is finished, if that is the case it breaks
        /// the loop and changes the games playing state to false.
        /// </summary>
        public void StartGame()
        {
            int gameFinished = 0;
            

            while (IsPlaying())
            {
                Random rand = new Random();
                int number = rand.Next(1, 3);
                String[] resultArray = PrintResult();
                Console.WriteLine(resultArray[0]);
                Console.WriteLine(resultArray[1]);
                Console.WriteLine("------------------------------------------------------------");

                // Add points randomely to players
                if (number == 1)
                {
                    player1.AddPointToPlayer();
                }
                else
                {
                    player2.AddPointToPlayer();
                }

                gameFinished = CheckFinished();     // Check if game is finished where 1 is first player and 2 is second player

                if (gameFinished == 1)
                {
                    Console.WriteLine(player1.GetPlayerName() + " won the game");  
                    SetIsPlaying(false);
                    
                }

                if (gameFinished == 2)
                {
                    Console.WriteLine(player2.GetPlayerName() + " won the game");
                    SetIsPlaying(false);
                }

            }
        }
    }
}

