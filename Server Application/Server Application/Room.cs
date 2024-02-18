using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    internal class Room
    {
        Player owner;
        Player guest;
        Game game;
        RoomState state;
        bool playAgain;
        public Room(Player owner)
        {
            this.owner = owner;
            state = RoomState.Waiting;
        }

        private void CreateGame()
        {
            game = new Game(owner, guest);
            state = RoomState.Running;
        }
        private void guestHasJoined(Player guest)
        {
            this.guest = guest;
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
