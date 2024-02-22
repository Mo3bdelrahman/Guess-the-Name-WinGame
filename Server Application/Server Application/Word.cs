using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server_Application
{
    internal class Word
    {
        [JsonIgnore]
        //word from file
        string? originalWord;
        //game word
        public string? CurrentWord { get; set; }
        public WordState State { get; set; }

        public Word(string word)
        {
            originalWord = word;
            GetRandomWordFromFile();
        }
        public void GetRandomWordFromFile()
        {
            CurrentWord = "";
            for (int i = 0; i < originalWord?.Length; i++)
            {
                CurrentWord += "_";
            }
            State = WordState.Missing;
        }

        public void IsTheWordCompleted()
        {
            if (originalWord == CurrentWord)
            {
                State = WordState.Completed;
            }
            else
            {
                State = WordState.Missing;
            }
        }
        public bool CheckLetter(string letter)
        {
            bool retVal = false;
            for (int i = 0; i < originalWord.Length; i++)
            {
                if (letter[0] == originalWord[i])
                {
                    CurrentWord = CurrentWord.Remove(i, 1).Insert(i, letter);
                    retVal =  true;
                }
            }
            IsTheWordCompleted();
            return retVal;
        }
    }
}
