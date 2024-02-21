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
        public Player? Owner { get; set; }
        public Player? Guest { get; set; }
        public RoomState state { get; set; }
        public int WatchersCount { get; set; }
        public string Category { get; set; }
        public string RoomName { get; set; }
        public int RoomId { get; set; }
        public Room() { WatchersCount = 0; }

        public override string ToString()
        {
            return $"Id: {RoomId} \t Name: {RoomName} \t state: {state}";
        }
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
