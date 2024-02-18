using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    internal class Room
    {
        int Id { get; set; }
        Player Owner { get; set; }
        Player Guest { get; set; }
        Game Game { get; set; }
        RoomState state;
        bool playAgain;
        public Room(Player owner)
        {
            this.Owner = owner;
            state = RoomState.Waiting;
        }

        private void CreateGame()
        {
            Game = new Game(Owner, Guest);
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
