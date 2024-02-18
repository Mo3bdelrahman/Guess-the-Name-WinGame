using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    internal enum PlayerState
    {
        Available,
        Player1,
        Player2,
        Watcher
    }
    internal enum RoomState
    {
        Waiting,
        Running   
    }
    internal enum Request
    {
        CreateRoom,
        JoinRoom
    }

}
