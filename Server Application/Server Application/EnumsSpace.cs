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
        ServerToClientUpdateCategories,

        ClientToServerCreateRoom,
        ServerToClientCreateRoom,//on creating confrimed

        ServerToClientUpdateRooms,//on creating to notify all players

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

        ClientToServerEndGame,// Game
        ServerToClientEndGame,

    }
    enum WordState
    {
        Missing,
        Completed
    }

    enum WordCategories
    {
        Food,
        Sports,
        Languages,
        NotAvailable
    }
    enum TurnState
    {
        Player1 = 1,
        Player2
    }

    enum Log
    {
        General,
        ServerError,
        ClientError,
        GameResult,
        All
    }
}
