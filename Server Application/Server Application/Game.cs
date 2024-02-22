using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    internal class Game
    {
        public Word Word { get; set; }
        public TurnState TurnState { get; set; }
        //string result;

        public Game(string wordStr)
        {
            Word = new Word(wordStr);
            TurnState = TurnState.Player1;
        }

        //public bool IsGameCompleted()
        //{
        //    if (word.State == WordState.Completed)
        //    {
        //        if (turnState == TurnState.Player1)
        //        {
        //            result = $"{player1.Name} wins";

        //        }
        //        else
        //        {
        //            result = $"{player2.Name} wins";
        //        }
        //        return true;
        //    }
        //    return false;
        //}

    }
}
