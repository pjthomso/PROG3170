/**
 * PROG 3170 Assignment 2
 * Nicole Dahlquist and Peter Thomson
 * WordScramblerService.cs
 * 
 * Created: November 06, 2015 
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NDPTassignment2
{
    public class WordScramblerService : IWordScramblerService
    {
        string[] words = { "kitchener", "waterloo", "toronto", "ottawa",
				    "montreal", "calgary", "edmonton", "vancouver" };

        public Word getScrambledWord()
        {
            Random random = new Random();
            string selectedWord = words[random.Next(words.Length)];
            string scrambledWord = scrambleWord(selectedWord);
            Word wordObj = new Word();
            wordObj.unscrambledWord = selectedWord;
            wordObj.scrambledWord = scrambledWord;
            return wordObj;
        }

        public bool guessWord(string guessedWord, string unscrambledWord)
        {
            return (guessedWord.CompareTo(unscrambledWord) == 0);
        }

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
