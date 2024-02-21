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
                    result = $"{player1.Name} wins";

                }
                else
                {
                    result = $"{player2.Name} wins";
                }
                return true;
            }
            return false;
        }

    }
}
