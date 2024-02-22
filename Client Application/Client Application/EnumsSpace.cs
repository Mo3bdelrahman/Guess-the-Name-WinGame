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
        StandBy,
        Running
    }
    enum Request

    {
        ClientToServerLogin,// start button 
        ServerToClientLogin,

        ClientToServerLoadLobby, //on lobby load
        ServerToClientLoadLobby,

        ClientToServerLoadCategories, //on create categ
        ServerToClientLoadCategories,

        ClientToServerCreateRoom,
        ServerToClientCreateRoom,//on creating confrimed

        ServerToClientUpdateRooms,

        ClientToServerAskToJoin,//on asking to join
        ServerToClientAskToJoin,

        ClientToServerResponseToJoin,
        ServerToClientResponseToJoin,

        ClientToServerWatch,//on watching
        ServerToClientWatch,
        ServerToClientAddWatcher,

        ClientToServerP1LeaveRoomLobby,//with player only
        ServerToClientP1LeaveRoomLobby,

        ClientToServerP2LeaveRoomLobby,//with player only
        ServerToClientP2LeaveRoomLobby,

        ClientToServerLeaveGame,// with watcher and player
        ServerToClientLeaveGame,

        ClientToServerStartGame,// with player only
        ServerToClientStartGame,

        ClientToServerSendChar,// Game
        ServerToClientSendChar,

        SendCharC,
    }

    enum WordState
    {
        Missing,
        Completed
    }

    enum TurnState
    {
        Player1 =1,
        Player2
    }

}
