using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client_Application
{
    internal struct Player
    {
        TcpClient? tcpClient;
        string? name;
        PlayerState state;
        public Player(){}
        public Player(TcpClient tcp , string pName)
        {
            tcpClient = tcp;
            name = pName;
            state = PlayerState.Available;
        }
    }
    internal struct Room
    {
        Player? owner;
        Player? guest;
        RoomState state;
        int watchersCount;
        public Room() { watchersCount = 0; }
    }
    internal struct Game
    {
        string? CurrentWord;
        TurnState turnState;
        public Game() { }
        public Game(string word, TurnState ts)
        {
            CurrentWord = word;
            turnState = ts;
        }
    }
}
