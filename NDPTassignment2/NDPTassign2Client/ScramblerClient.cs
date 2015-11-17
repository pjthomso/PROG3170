/**
 * PROG 3170 Assignment 2
 * Nicole Dahlquist and Peter Thomson
 * ScramblerClient.cs
 * 
 * Created: November 06, 2015 
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDPTassign2Client.worldScramblerServiceReference;

namespace NDPTassign2Client
{
    class ScramblerClient
    {
        static void Main(string[] args)
        {
            WordScramblerServiceClient game = new WordScramblerServiceClient();
            
            Word word = game.getScrambledWord();
            Console.WriteLine("Can you unscramble this word?");
            Console.WriteLine("=> " + word.scrambledWord);
            string guessedWord = Console.ReadLine();

            if (game.guessWord(guessedWord, word.unscrambledWord))
            {
                Console.WriteLine("Wow, You Won! ;-)");
            }
            else
            {
                Console.WriteLine("Sorry, You Lose :-(");
            }
            Console.ReadKey();            
        }
    }
}
