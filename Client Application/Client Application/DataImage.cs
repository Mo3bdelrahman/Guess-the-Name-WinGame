using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Client_Application
{
    internal class Player
    {
        public TcpClient? TcpClient { get; set; }
        public string? Name { get; set; }
        public PlayerState State { get; set; }
        public int Id { get; set; }
        public Player() { }
        public Player(TcpClient tcp, string pName, int id)
        {
            TcpClient = tcp;
            Name = pName;
            State = PlayerState.Available;
            Id = id;
        }
    }
    internal class Room
    {
        public Player? Owner { get; set; }
        public Player? Guest { get; set; }
        public RoomState State { get; set; }
        public int WatchersCount { get; set; }
        public string Category { get; set; }
        public string RoomName { get; set; }
        public int RoomId { get; set; }
        public Room() { WatchersCount = 0; }

        public override string ToString()
        {
            return $"Id: {RoomId} \t Name: {RoomName} \t state: {State}";
        }
    }
    internal class Word
    {
        public string? CurrentWord { get; set; }
        public WordState State { get; set; }
    }
    internal class Game
    {
        public Word Word { get; set; }
        public TurnState TurnState { get; set; }
    }
}
