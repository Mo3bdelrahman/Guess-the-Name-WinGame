namespace Client_Application
{
    internal partial class ClientForm
    {
        Room room;
        List<Room> roomList;
        Game game;
        string[] Categories;


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
                case Request.ServerToClientStartGame: StartGame(para); break;
                case Request.ServerToClientSendChar: Play(para); break;
                case Request.ServerToClientLoadCategories: loadCategories(para); break;
                case Request.ServerToClientWatch: WatchGame(para); break;
                case Request.ServerToClientAddWatcher: AddWatcher(para); break;
                case Request.ServerToClientLeaveGame: LeaveGame(para); break;


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
                    OnLoginClick();
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
            Invoke(() => UpdateRoomList());
        }

        private void RoomLobbyLoad(List<string> jsonStringList)
        {
            room = jsonStringList[0].GetOriginalData<Room>();
            player.State = jsonStringList[1].GetOriginalData<PlayerState>();
            MessageBox.Show($" hi, {room.Owner.Name} you enterd {room.RoomName} Id: {room.RoomId} cat is {room.Category} and player is {player.State}");
            //Invoke(() => UpdateRoomList());
            OnCreateResponse();
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

            OnLeaveClick();
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
            }
        }

        private void GuestAskToJoin(List<string> jsonStringList)
        {
            Player guest = jsonStringList[0].GetOriginalData<Player>();
            Room room = jsonStringList[1].GetOriginalData<Room>();
            MessageBox.Show($"Player: {guest.Name} Ask To Join");
            // here we need check if owner accept or not
            ClientController.RequestHandeller<bool, int, int>(stream, Request.ClientToServerResponseToJoin, true, guest.Id, room.RoomId);
        }

        private void PlayerResponseToJoin(List<string> jsonStringList)
        {
            try
            {
                bool response = jsonStringList[0].GetOriginalData<bool>();
                if (response)
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

                OnJoinClick(response);

            }
            catch (Exception e) { MessageBox.Show("from res to join" + e.Message); }

        }

        private void StartGame(List<string> jsonStringList)
        {
            try
            {
                game = jsonStringList[0].GetOriginalData<Game>();
                room.state = jsonStringList[1].GetOriginalData<RoomState>();
                //Invoke(() => ViewPanel(GamePanel));
                OnStartClick();
                MessageBox.Show($"the Game started {game.TurnState} turn and the word is {game.Word.CurrentWord}");
            }
            catch (Exception e) { MessageBox.Show("From start game" + e.Message); }

        }

        private void Play(List<string> jsonStringList)
        {
            bool res = jsonStringList[0].GetOriginalData<bool>();
            string GameChar = jsonStringList[1].GetOriginalData<string>();
            game = jsonStringList[2].GetOriginalData<Game>();
            // update UI here
            Invoke(() => MessageBox.Show("Game updated turn of " + game.TurnState + "the Word now is" + game.Word.CurrentWord + "boolean value" + res));
            ToggleTurn();
        }
        private void loadCategories(List<string> jsonStringList)
        {
            try
            {
                Categories = jsonStringList[0].GetOriginalData<string[]>();
                MessageBox.Show("Categories : " + String.Join(",", Categories));

                OnCreateClick();
            }
            catch (Exception e) { MessageBox.Show("Load Categories" + e.Message); }
        }
        private void WatchGame(List<string> jsonStringList)
        {
            try
            {
                player = jsonStringList[0].GetOriginalData<Player>();
                room = jsonStringList[1].GetOriginalData<Room>();
                game = jsonStringList[2].GetOriginalData<Game>();
                //update game Panal
                //Invoke(() => ViewPanel(GamePanel));
                OnWatchClick();
                MessageBox.Show($"Wellcome {player?.Name}, Have fun in {room?.RoomName} now turn of {game?.TurnState} the word is {game?.Word?.CurrentWord}");
            }
            catch (Exception e) { MessageBox.Show("From watch game" + e.Message); }

        }
        private void AddWatcher(List<string> jsonStringList)
        {
            try
            {
                room.WatchersCount++;
                // update Counter in game panal
                MessageBox.Show($"the Watcher count is {room.WatchersCount} ");
            }
            catch (Exception e) { MessageBox.Show("From add watcher " + e.Message); }

        }
        private void LeaveGame(List<string> jsonStringList)
        {
            try
            {
                player.State = jsonStringList[0].GetOriginalData<PlayerState>();
                room = null;
                ClientController.RequestHandeller(stream, Request.ClientToServerLoadLobby);
                MessageBox.Show("Player Leaved,Game Finished and The room was closed");
                Invoke(() => ViewPanel(LoobyPanel));
                //OnLeaveClick();
            }
            catch(Exception e) { MessageBox.Show("Leave Game Error"+e.Message); }
            Invoke(() => UpdateRoomList());
        }

        private void UpdateRoomList()
        {
            listView1.Items.Clear();
            foreach (var r in roomList)
            {
                string s = r.ToString();
                listView1.Items.Add(new ListViewItem(s));
            }
        }
    }

}
