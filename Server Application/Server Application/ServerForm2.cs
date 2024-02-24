using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    public partial class ServerForm
    {
        private void Distributer(NetworkStream stream, Request req, List<string> para)
        {
            switch (req)
            {
                case Request.ClientToServerLogin: SetPlayerData(stream, para); break;
                case Request.ClientToServerLoadLobby: GetListOfRooms(stream, para); break;
                case Request.ClientToServerCreateRoom: CreateRoom(stream, para); break;
                case Request.ClientToServerP1LeaveRoomLobby: P1LeaveRoom(stream, para); break;
                case Request.ClientToServerP2LeaveRoomLobby: P2LeaveRoom(stream, para); break;
                case Request.ClientToServerAskToJoin: ClientAskToJoinRoom(stream, para);break;
                case Request.ClientToServerResponseToJoin: ClientResponseToJoinRoom(stream, para);break;
                case Request.ClientToServerStartGame: StartGame(stream, para);  break;
                case Request.ClientToServerSendChar: CheckChar(stream, para); break;
                case Request.ClientToServerLoadCategories: SendCategories(stream, para);break;
                case Request.ClientToServerWatch: Watch(stream, para); break;
                case Request.ClientToServerLeaveGame: LeaveGame(stream, para);break;
                case Request.ClientToServerEndGame: EndGame(stream, para); break;

                default: MessageBox.Show($"{req}"); break;
            }
        }
        //Utility
        private Player GetPlayer(NetworkStream stream)
        {
            Player? p = Players.Find(player => player.Client.GetStream() == stream);
            return p!;
        }
        private Player GetPlayer(int id)
        {
            Player? p = Players.Find(player => player.Id == id);
            return p!;
        }
        private Room GetRoom(int id)
        {
            Room? r = Rooms.Find(room => room.RoomId == id);
            return r!;     
        }
        //Response Handellers
        private void SetPlayerData(NetworkStream stream, List<string> jsonStringList)
        {
            Player p = GetPlayer(stream);
            try
            {
                p.Name = jsonStringList[0].GetOriginalData<string>();
                ServerController.RequestHandeller<bool, Player>([p], Request.ServerToClientLogin, true, p);
                Logger.Write(Log.General, $"Player {p.Name} id = {p.Id} Connected");
            }
            catch
            {
                ServerController.RequestHandeller<bool>([p], Request.ServerToClientLogin, false);
            }
            Invoke(()=>UpdatePlayerList()); 
        }
        private void GetListOfRooms(NetworkStream stream, List<string> jsonStringList)
        {
            Player p = GetPlayer(stream);
            List<RoomState> states = new List<RoomState>();

            foreach( Room room in Rooms )
            {
                states.Add(room.State);
            }

            ServerController.RequestHandeller<List<Room>, List<RoomState>>([p],Request.ServerToClientLoadLobby,Rooms, states);
        }
        private void CreateRoom(NetworkStream stream, List<string> jsonStringList)
        {
            Player p = GetPlayer(stream);
            string cat = jsonStringList[0].GetOriginalData<string>();
            Room room = new Room(p, cat, ++RoomIdG);
            Rooms.Add(room);
            p.State = PlayerState.Player1;
            ServerController.RequestHandeller<Room,PlayerState>([p], Request.ServerToClientCreateRoom, room,p.State);
            ServerController.RequestHandeller(Players, Request.ServerToClientUpdateRooms);
            Logger.Write(Log.General,$"{p.Name} create room with id = {room.RoomId}");
            Invoke(() => UpdateRoomList());
            Invoke(() => UpdatePlayerList());
        }
        private void P1LeaveRoom(NetworkStream stream, List<string> jsonStringList)
        {       
            int id = jsonStringList[0].GetOriginalData<int>();
            Player p = GetPlayer(stream);
            Room r = GetRoom(id);
            Rooms.Remove(r);
            p.State = PlayerState.Available;
            if (r.Guest != null)
            {
                r.Guest.State = PlayerState.Available;
                ServerController.RequestHandeller<PlayerState>([p,r.Guest], Request.ServerToClientP1LeaveRoomLobby, p.State);
            }
            else
            {
                ServerController.RequestHandeller<PlayerState>([p], Request.ServerToClientP1LeaveRoomLobby, p.State);
            }
            Invoke(() => UpdateRoomList());
            Invoke(() => UpdatePlayerList());

        }
        private void P2LeaveRoom(NetworkStream stream, List<string> jsonStringList)
        {
            int id = jsonStringList[0].GetOriginalData<int>();
            Player p = GetPlayer(stream);
            Room r = GetRoom(id);
            if(r != null)
            {
                r.Guest = null;
                r.State = RoomState.Waiting;
                ServerController.RequestHandeller<PlayerState>([p], Request.ServerToClientP2LeaveRoomLobby, p.State);
                ServerController.RequestHandeller<Room>([r.Owner!], Request.ServerToClientP2LeaveRoomLobby, r);
            }
            p.State = PlayerState.Available;
            Invoke(() => UpdatePlayerList());

        }
        private void ClientAskToJoinRoom(NetworkStream stream, List<string> jsonStringList)
        {
            try
            {
                int id = jsonStringList[0].GetOriginalData<int>();
                Room room = GetRoom(id);
                Player guest = GetPlayer(stream);
                ServerController.RequestHandeller<Player, Room>([room.Owner!], Request.ServerToClientAskToJoin, guest, room);
            }
            catch(Exception e) { MessageBox.Show("from ask to join"+e.Message); };
            
        }
        private void ClientResponseToJoinRoom(NetworkStream stream, List<string> jsonStringList)
        {
            try
            {
                bool response = jsonStringList[0].GetOriginalData<bool>();
                int pId = jsonStringList[1].GetOriginalData<int>();
                int rId = jsonStringList[2].GetOriginalData<int>();
                Player owner = GetPlayer(stream);
                Player guest = GetPlayer(pId);
                Room room = GetRoom(rId);

                if (response)
                {
                    guest.State = PlayerState.Player2;
                    room.Guest = guest;
                    room.State = RoomState.StandBy;
                    ServerController.RequestHandeller<bool, Room>([owner, guest], Request.ServerToClientResponseToJoin, response, room);
                }
                else
                {
                    ServerController.RequestHandeller<bool>([guest], Request.ServerToClientResponseToJoin, response);
                }
                Invoke(() => UpdateRoomList());
                Invoke(() => UpdatePlayerList());

            }
            catch (Exception e) { MessageBox.Show("From res join"+e.Message); } 

        }
        private void StartGame(NetworkStream stream, List<string> jsonStringList)
        {
            try
            {
                int id = jsonStringList[0].GetOriginalData<int>();
                Room room = GetRoom(id);
                if (room.StartGameFlag)
                {
                    //Note we need here => get Category
                    room.Game = new Game(WordCategory.GetRandomWord(room.Category));
                    room.State = RoomState.Running;
                    ServerController.RequestHandeller<Game,RoomState>([room.Owner!,room.Guest!],Request.ServerToClientStartGame,room.Game, RoomState.Running);
                    Invoke(() => UpdateRoomList());
                    Invoke(() => UpdatePlayerList());
                    Logger.Write(Log.General,$"Game Started in {room.RoomName} with word {room.Game.Word} ( {room.Owner.Name} VS {room.Guest.Name} )");
                    room.StartGameFlag = false;
                }
                else
                {
                    room.StartGameFlag = true;
                }
            }
            catch (Exception e) { Logger.Write(Log.ServerError, e.Message); }
           
        }
        private void CheckChar(NetworkStream stream, List<string> jsonStringList)
        {
            try
            {
                int id = jsonStringList[0].GetOriginalData<int>();
                string GameChar = jsonStringList[1].GetOriginalData<string>();
                Room room = GetRoom(id);
                bool res =  room.Game.Word.CheckLetter(GameChar);
                if (!res)
                {
                    room.Game.TurnTogeller();
                }
                if (room.Game.Word.State == WordState.Completed)
                {
                    if(room.Owner.State.ToString() == room.Game.TurnState.ToString())
                        Logger.Write(Log.GameResult, $"Game Ended in {room.RoomName} winner is {room.Owner.Name}");    
                    else
                        Logger.Write(Log.GameResult, $"Game Ended in {room.RoomName} winner is {room.Guest.Name}");
                    //if (room.Watchers.Count > 0)
                    //{
                    //    foreach (var i in room.Watchers)
                    //    {
                    //        i.State = PlayerState.Available;
                    //    }
                    //    room.Watchers.Clear();
                    //}
                }
                ServerController.RequestHandeller<bool,string, Game>([room.Owner! , room.Guest!],Request.ServerToClientSendChar,res, GameChar, room.Game);
                if (room.Watchers != null && room.Watchers.Count > 0)
                {
                    ServerController.RequestHandeller<bool,string, Game>(room.Watchers!, Request.ServerToClientSendChar, res, GameChar, room.Game);
                }
                


            }
            catch (Exception e) { Logger.Write(Log.ServerError, e.Message); }

        }
        private void SendCategories(NetworkStream stream, List<string> jsonStringList)
        {
            try
            {
                Player p = GetPlayer(stream);
                string[] categories = WordCategory.GetAllCategories();
                ServerController.RequestHandeller<string[]>([p], Request.ServerToClientLoadCategories, categories);
            }
            catch(Exception e) { MessageBox.Show("from send cat"+e.Message); }
        }
        private void Watch(NetworkStream stream, List<string> jsonStringList)
        {
            try
            {
                int id = jsonStringList[0].GetOriginalData<int>();
                Player watcher = GetPlayer(stream);
                Room room = GetRoom(id);
                watcher.State = PlayerState.Watcher;
                room.Watchers.Add(watcher);
                ServerController.RequestHandeller<Player,Room,Game>([watcher], Request.ServerToClientWatch,watcher, room,room.Game);
                ServerController.RequestHandeller([room.Owner!,room.Guest!], Request.ServerToClientAddWatcher);
                Logger.Write(Log.General,$"Player {watcher.Name} watchs Game in Room {room.RoomName}");
            }
            catch (Exception e) { MessageBox.Show("From Watch" + e.Message); }
        }
        private void LeaveGame(NetworkStream stream, List<string> jsonStringList)
        {
            try
            {
                int id = jsonStringList[0].GetOriginalData<int>();
                Player player = GetPlayer(stream);
                Room room = GetRoom(id);
                if(room != null)
                {
                    Rooms.Remove(room);
                    player.State = PlayerState.Available;
                    if (player.State == PlayerState.Watcher)
                    {
                        player.State = PlayerState.Available;
                        ServerController.RequestHandeller<PlayerState>([player], Request.ServerToClientLeaveGame, PlayerState.Available);
                    }
                    else
                    {
                        room.Owner.State = PlayerState.Available;
                        room.Guest.State = PlayerState.Available;
                        if (room.Watchers.Count > 0)
                        {
                            foreach (Player w in room.Watchers)
                            {
                                w.State = PlayerState.Available;
                            }
                        }
                        Rooms.Remove(room);
                        ServerController.RequestHandeller<PlayerState>([room.Owner, room.Guest], Request.ServerToClientLeaveGame, PlayerState.Available);
                        ServerController.RequestHandeller<PlayerState>(room.Watchers, Request.ServerToClientLeaveGame, PlayerState.Available);
                    }
                }
                Invoke(() => UpdateRoomList());
                Invoke(() => UpdatePlayerList());
            }
            catch(Exception e) { MessageBox.Show("from LeaveGame Server"+e.Message); }
           

        }

        private void EndGame(NetworkStream stream, List<string> jsonStringList)
        {
            try
            {
                int rId = jsonStringList[0].GetOriginalData<int>();
                string winerName = jsonStringList[1].GetOriginalData<string>();
                Room room = GetRoom(rId);
                Logger.Write(Log.GameResult,$"Game Ended in {room.RoomName} ( {room.Owner.Name} Vs {room.Guest.Name} ) and the winner is *** {winerName} ***");
                if ( room.Watchers.Count > 0)
                {
                    ServerController.RequestHandeller<PlayerState>(room.Watchers, Request.ServerToClientEndGame, PlayerState.Available);
                    room.Watchers.Clear();
                }

                Invoke(() => UpdateRoomList());
                Invoke(() => UpdatePlayerList());
            }
            catch (Exception e) { MessageBox.Show("from LeaveGame Server" + e.Message); }


        }

        //UI
        private void UpdateRoomList()
        {
            listRooms.Items.Clear();
            foreach (var r in Rooms)
            {
                string[] s = { $"{r.RoomId}", r.RoomName, r.Owner.Name,r.State.ToString()};
                listRooms.Items.Add(new ListViewItem(s));
            }

        }

        private void UpdatePlayerList()
        {
            listPlayers.Items.Clear();
            foreach (var p in Players)
            {
                string[] s = { $"{p.Name}", $"{p.State}" };
                listPlayers.Items.Add(new ListViewItem(s));
            }
        }
    }
}
