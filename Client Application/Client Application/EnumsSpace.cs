using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Application
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
        ClientToServerLogin,// start button 
        ServerToClientLogin,

        ClientToServerLoadLobby, //on lobby load
        ServerToClientLoadLobby,

        ClientToServerCreateRoom,
        ServerToClientCreateRoom,//on creating confrimed

        ClientToServerAskToJoin,//on asking to join
        ServerToClientAskToJoin,

        ClientToServerResponseToJoin,
        ServerToClientResponseToJoin,

        ClientToServerWatch,//on watching
        ServerToClientWatch,

        ClientToServerLeaveRoomLobby,//with player only
        ServerToClientLeaveRoomLobby,

        ClientToServerLeaveGame,// with watcher and player
        ServerToClientLeaveGame,

        StartGameC,
        SendCharC,
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
