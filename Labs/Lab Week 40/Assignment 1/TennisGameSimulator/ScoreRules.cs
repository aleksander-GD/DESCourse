using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGameSimulator
{
    

    public class ScoreRules {

        private String[] scoreArray;

        public ScoreRules ()
        {
           this.scoreArray = new string[] { "love", "fifteen", "thirty", "forty" };
        }

        /// <summary>
        /// Get the scoreArray { "love", "fifteen", "thirty", "forty" }
        /// </summary>
        /// <returns> Returns String[] representation of the score rules </returns>
        public String[] getScoreArray()
        {
            return this.scoreArray;
        }
        /// <summary>
        /// Get current score. Checks based on a int value inside the scoreArray for the string score representation
        /// </summary>
        /// <param name="score"> int value for the score </param>
        /// <returns> Returns string based on score number given { "love", "fifteen", "thirty", "forty" } </returns>
        public string getCurrentScore(int score)
        {
            return this.scoreArray[score];
        }
    }
   
    
}
