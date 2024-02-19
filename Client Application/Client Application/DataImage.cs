using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client_Application
{
    internal class Player
    {
        public TcpClient? TcpClient { get; set; }
        public string? Name { get; set; }
        public PlayerState State { get; set; }
        public Player(){}
        public Player(TcpClient tcp , string pName)
        {
            TcpClient = tcp;
            Name = pName;
            State = PlayerState.Available;
        }
    }
    internal class Room
    {
        Player? owner;
        Player? guest;
        RoomState state;
        int watchersCount;
        public Room() { watchersCount = 0; }
    }
    internal class Game
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
