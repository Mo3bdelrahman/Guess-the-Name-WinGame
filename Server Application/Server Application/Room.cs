using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Server_Application
{
    internal class Room
    {
        public Player? Owner { get; set; }
        public Player? Guest { get; set; }
        [JsonIgnore]
        public Game? Game { get; set; }
        public RoomState State;
        [JsonIgnore]
        public bool playAgain;
        [JsonIgnore]
        public List<Player>? Watchers {  get; set; } 
        public string Category { get; set; }
        public string RoomName { get; set; }
        public int RoomId { get; set; }
        [JsonIgnore]
        public bool StartGameFlag { get; set; }
        public Room(Player owner, string cat,int id)
        {
            this.Owner = owner;
            this.Category = cat;
            Watchers = new List<Player>();
            this.RoomName = $"{owner.Name}'s room";
            this.RoomId = id;
            State = RoomState.Waiting;
            StartGameFlag = false;
        }
        public override string ToString()
        {
            return $"Id: {RoomId} \t Name: {RoomName} \t state: {State}";
        }
      

    }
}
