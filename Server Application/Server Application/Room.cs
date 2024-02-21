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
        public RoomState state;
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
            this.RoomName = $"{owner.Name}'s room";
            this.RoomId = id;
            state = RoomState.Waiting;
            StartGameFlag = false;
        }

        //private void CreateGame()
        //{
        //    Game = new Game();
        //    state = RoomState.Running;
        //}
        //private void guestHasJoined(Player guest)
        //{
        //    this.Guest = guest;
        //    CreateGame();
        //}
        //private void PlayAgain()
        //{
        //    if (playAgain)
        //    {
        //        CreateGame();
        //    }
        //}
        //public bool IsRoomCompleted()
        //{
        //    if (game.IsGameCompleted())
        //    {
        //        PlayAgain();
        //    }
        //}

    }
}
