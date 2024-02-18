using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    internal class Word
    {
        //word from file
        string originalWord;
        //game word
        public string CurrentWord { get; set; }
        public WordState State { get; private set; }
        public Word()
        {
            originalWord = string.Empty;
            CurrentWord = string.Empty;
        }
        private void GetRandomWordFromFile()
        {

        }
        public string SendWordToTheGame()
        {
            return CurrentWord;
        }
        public string UpdateWord(char letter)
        {
            return CurrentWord;
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
    }
}
