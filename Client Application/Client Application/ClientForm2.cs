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
                case Request.ServerToClientUpdateRooms: ClientController.RequestHandeller(stream, Request.ClientToServerLoadLobby); break;
                case Request.ServerToClientP1LeaveRoomLobby: P1leaveRoom(para); break;
                case Request.ServerToClientP2LeaveRoomLobby: P2leaveRoom(para); break;
                case Request.ServerToClientAskToJoin: GuestAskToJoin(para); break;
                case Request.ServerToClientResponseToJoin: PlayerResponseToJoin(para); break;


                default: MessageBox.Show($"Not Handelled  req : {req}"); break;
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
                    MessageBox.Show($"{player.Name}, {player.State}");
                    ClientController.RequestHandeller(stream, Request.ClientToServerLoadLobby);
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
            UpdateRoomList();


        }

        private void RoomLobbyLoad(List<string> jsonStringList)
        {
            room = jsonStringList[0].GetOriginalData<Room>();
            player.State = jsonStringList[1].GetOriginalData<PlayerState>();
            MessageBox.Show($" hi, {room.Owner.Name} you enterd {room.RoomName} Id: {room.RoomId} cat is {room.Category} and player is {player.State}");
            UpdateRoomList();

        }

        private void P1leaveRoom(List<string> jsonStringList)
        {
            if (player.State == PlayerState.Player1)
            {
                player.State = jsonStringList[0].GetOriginalData<PlayerState>();
                room = null;
                ClientController.RequestHandeller(stream, Request.ClientToServerLoadLobby);
            }
            else
            {
                player.State = jsonStringList[0].GetOriginalData<PlayerState>();
                room = null;
                ClientController.RequestHandeller(stream, Request.ClientToServerLoadLobby);
                MessageBox.Show("Player1 Leave, The room was closed");
            }
            UpdateRoomList();
        }

        private void P2leaveRoom(List<string> jsonStringList)
        {
            if (player.State == PlayerState.Player2)
            {
                player.State = jsonStringList[0].GetOriginalData<PlayerState>();
                room = null;
                ClientController.RequestHandeller(stream, Request.ClientToServerLoadLobby);
            }
            else
            {
                room = jsonStringList[0].GetOriginalData<Room>();
                MessageBox.Show("Player2 Leave, Wait for Other Player");
            }
        }


        private void GuestAskToJoin(List<string> jsonStringList)
        {
            Player guest = jsonStringList[0].GetOriginalData<Player>();
            Room room = jsonStringList[1].GetOriginalData<Room>();
            MessageBox.Show($"Player: {guest.Name} Ask To Join");
            // here we need check if owner accept or not
            ClientController.RequestHandeller<bool,int,int>(stream,Request.ClientToServerResponseToJoin,true,guest.Id,room.RoomId);
        }

        private void PlayerResponseToJoin(List<string> jsonStringList)
        {
            try
            {

            }
            catch (Exception e) {MessageBox.Show("from res to join"+e.Message); }
            bool response = jsonStringList[0].GetOriginalData<bool>();
            if(response)
            {
                room = jsonStringList[1].GetOriginalData<Room>();
                // here we need to get into the room
                if (player.State == PlayerState.Player1)
                {
                    MessageBox.Show($"{room.Guest?.Name} Enterd your Room the state now is {room.state}");
                }
                else
                {
                    player.State = room.Guest.State;
                    MessageBox.Show($"hi{player.Name} you Enterd {room.RoomName} the state now is {room.state}");
                }    
            }
            else
            {
                MessageBox.Show($"Sorry, {player.Name} the Owner refused ");
            } 
        }

        private void UpdateRoomList()
        {
            listView1.Items.Clear();
            foreach (var r in roomList)
            {
                string[] s = {$"{r.RoomId}", r.RoomName, r.Owner.Name, r.Guest?.Name};
                listView1.Items.Add(new ListViewItem(s));
            }
                
        }
    }

}
