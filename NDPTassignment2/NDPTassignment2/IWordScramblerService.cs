/**
 * PROG 3170 Assignment 2
 * Nicole Dahlquist and Peter Thomson
 * IWordScramblerService.cs
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
    [ServiceContract]
    public interface IWordScramblerService
    {
        [OperationContract]
        /**
        * Randonly selects a word, scrambles it, and retuns the original
        * (unscrambled) and the scrambed words as a single Word object
        **/
        Word getScrambledWord();

        [OperationContract]
        /**
        * Returns true if the guessed word correctly matches the
        * unscrambled word or false otherwise
        **/
        bool guessWord(string guessedWord, string unscrambledWord);

    }

    [DataContract]
    public class Word
    {
        [DataMember]
        public string unscrambledWord { get; set; }

        [DataMember]
        public string scrambledWord { get; set; }
    }
}
