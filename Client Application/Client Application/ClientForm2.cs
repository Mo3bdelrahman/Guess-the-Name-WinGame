namespace Client_Application
{
    internal partial class ClientForm
    {
        Room room;
        List<Room> roomList;
        Game game;


        private void Distributer(Request req, List<string> para)
        {
            switch (req)
            {
                case Request.ServerToClientLogin: SetPlayerData(para); break;
                case Request.ServerToClientLoadLobby: LobbyLoad(para); break;
                case Request.ServerToClientCreateRoom: RoomLobbyLoad(para); break;
                case Request.ServerToClientUpdateRooms: ClientController.RequestHandeller(stream,Request.ClientToServerLoadLobby); break;
                case Request.ServerToClientP1LeaveRoomLobby: P1leaveRoom(para); break;
                case Request.ServerToClientP2LeaveRoomLobby: P2leaveRoom(para); break;
                default: MessageBox.Show($"{req}"); break;
            }
        }
        //request handlers
        private void SetPlayerData(List<string> jsonStringList)
        {
            try
            {
                if (jsonStringList[0].GetOriginalData<bool>())
                {
                    player = jsonStringList[1].GetOriginalData<Player>();
                    OnLoginClick();
                    MessageBox.Show($"{player.Name}, {player.State}");
                    ClientController.RequestHandeller(stream,Request.ClientToServerLoadLobby);
                }
                else
                {
                    MessageBox.Show("Couldn't connect To the Server, Please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("from Method " + ex.Message);
            }
        }

        private void LobbyLoad(List<string> jsonStringList)
        {
            roomList = jsonStringList[0].GetOriginalData<List<Room>>();
            OnLoadLobby();
            MessageBox.Show("Rooms is Here");
        }

        private void RoomLobbyLoad(List<string> jsonStringList)
        {
            room = jsonStringList[0].GetOriginalData<Room>();
            player.State = jsonStringList[1].GetOriginalData<PlayerState>();
            // I Also Need A Boolean Value For Confirmation
            MessageBox.Show(room.ToString());
            OnCreateClick(true);
            MessageBox.Show($" hi, {room.Owner.Name} you enterd {room.RoomName} Id: {room.RoomId} cat is {room.Category} and player is {player.State}");
        }

        private void P1leaveRoom(List<string> jsonStringList)
        {
            if (player.State == PlayerState.Player1)
            {
                player.State = jsonStringList[0].GetOriginalData<PlayerState>();
                room = null;
                ClientController.RequestHandeller(stream, Request.ClientToServerLoadLobby);
                OnLeaveClick();
            }
            else
            {
                player.State = jsonStringList[0].GetOriginalData<PlayerState>();
                room = null;
                ClientController.RequestHandeller(stream, Request.ClientToServerLoadLobby);
                MessageBox.Show("Player1 Leave, The room was closed");
                OnLeaveReceive();
            }
        }

        private void P2leaveRoom(List<string> jsonStringList)
        {
            if (player.State == PlayerState.Player2)
            {
                player.State = jsonStringList[0].GetOriginalData<PlayerState>();
                room = null;
                ClientController.RequestHandeller(stream, Request.ClientToServerLoadLobby);
                OnLeaveClick();
            }
            else
            {
                room = jsonStringList[0].GetOriginalData<Room>();
                MessageBox.Show("Player2 Leave, Wait for Other Player");
                OnLeaveReceive();
            }
        }

    }
}
