using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NDPTassignment3
{
    [ServiceBehavior]
    public class WordScrambleGame : IWordScrambleGame
    {
        // the maximum number of players allowed playing simultaneously
        private const int MAX_PLAYERS = 5;
        // the user hosting the game. If it’s null nobody is hosting the game.
        private static String userHostingTheGame = null;
        // the Word object that contains the scrambled and unscrambled words
        private static Word gameWords;
        // the list of players playing the game
        private static List<String> activePlayers = new List<string>();

        [OperationBehavior]
        public bool isGameBeingHosted()
        {
            // TO BE COMPLETED BY YOU: Add exception and program logic
            return false;
        }

        [OperationBehavior]
        public string hostGame(String playerName, string hostAddress, String wordToScramble)
        {
            // TO BE COMPLETED BY YOU: Add exception and program logic

            //Petey note: returns the scrambled version of the word as a string
            return "";
        }

        [OperationBehavior]
        public Word join(string playerName)
        {
            // TO BE COMPLETED BY YOU: Add exception and program logic
            return gameWords;
        }

        [OperationBehavior]
        public bool guessWord(string playerName, string guessedWord, string unscrambledWord)
        {
            // TO BE COMPLETED BY YOU: Add exception and program logic
            return true;
        }

        // Utility function to scramble a word
        private string scrambleWord(string word)
        {
            char[] chars = word.ToArray();
            Random r = new Random(2011);
            for (int i = 0; i < chars.Length; i++)
            {
                int randomIndex = r.Next(0, chars.Length);
                char temp = chars[randomIndex];
                chars[randomIndex] = chars[i];
                chars[i] = temp;
            }
            return new string(chars);
        }

    }
}
