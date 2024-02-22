﻿using System;
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
        ClientToServerLogin,// start button 
        ServerToClientLogin,

        ClientToServerLoadLobby, //on lobby load
        ServerToClientLoadLobby,

        ClientToServerCreateRoom,
        ServerToClientCreateRoom,//on creating confrimed

        ServerToClientUpdateRooms,//on creating to notify all players

        ClientToServerAskToJoin,//on asking to join
        ServerToClientAskToJoin,

        ClientToServerResponseToJoin,
        ServerToClientResponseToJoin,

        ClientToServerWatch,//on watching
        ServerToClientWatch,

        ClientToServerP1LeaveRoomLobby,//with player only
        ServerToClientP1LeaveRoomLobby,

        ClientToServerP2LeaveRoomLobby,//with player only
        ServerToClientP2LeaveRoomLobby,

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

    enum WordCategories
    {
        Food,
        Sports,
        Languages,
        NotAvailable
    }
    enum TurnState
    {
        Player1,
        Player2
    }
}
