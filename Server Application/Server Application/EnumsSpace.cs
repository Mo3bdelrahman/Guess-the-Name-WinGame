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
    enum Requests
    {
        CreateRoom,
        JoinRoom
    }

}
