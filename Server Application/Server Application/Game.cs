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
        Player player1;
        Player player2;
        List<Player> watchers;
        Word word;
        TurnState turnState;
        string result;

        public Game(Player p1, Player p2)
        {
            word = new Word();
            player1 = p1;
            player2 = p2;
            watchers = new List<Player>();
            turnState = TurnState.Player1;
        }

        public bool IsGameCompleted()
        {
            if (word.State == WordState.Completed)
            {
                if (turnState == TurnState.Player1)
                {
                    result = $"{player1.getName()} wins";


                }
                else
                {
                    result = $"{player2.getName()} wins";
                }
                return true;
            }
            return false;
        }

        public string UpdateWord(char letter)
        {
            if (turnState == TurnState.Player1)
            {
                turnState = TurnState.Player2;
            }
            else
            {
                turnState = TurnState.Player1;
            }
            return word.UpdateWord(letter);
        }
    }
}
