using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    enum PlayerState
    {
        Available,
        Player1,
        Player2,
        Watcher
    }
    enum RoomState
    {
        Waiting,
        Running
    }
    enum Request

    {
        CreateRoom,
        JoinRoom
    }
    enum WordState
    {
        Missing,
        Completed
    }
    enum TurnState
    {
        Player1,
        Player2
    }
}
