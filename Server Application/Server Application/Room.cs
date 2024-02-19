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
      
        public Room(Player owner)
        {
            this.Owner = owner;
            state = RoomState.Waiting;
        }

        private void CreateGame()
        {
            Game = new Game(Owner!, Guest!);
            state = RoomState.Running;
        }
        private void guestHasJoined(Player guest)
        {
            this.Guest = guest;
            CreateGame();
        }
        private void PlayAgain()
        {
            if (playAgain)
            {
                CreateGame();
            }
        }
        //public bool IsRoomCompleted()
        //{
        //    if (game.IsGameCompleted())
        //    {
        //        PlayAgain();
        //    }
        //}

    }
}
