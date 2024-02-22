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
            ServerController.RequestHandeller<List<Room>>([p],Request.ServerToClientLoadLobby,Rooms);
            Invoke(() => UpdateRoomList());
            
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

            r.Guest = null;
            r.state = RoomState.Waiting;
            p.State = PlayerState.Available;
            ServerController.RequestHandeller<PlayerState>([p], Request.ServerToClientP2LeaveRoomLobby, p.State);
            ServerController.RequestHandeller<Room>([r.Owner!], Request.ServerToClientP2LeaveRoomLobby, r);
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
                    room.state = RoomState.StandBy;
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
                    //getRand word
                    room.Game = new Game("red");
                    ServerController.RequestHandeller<Game>([room.Owner!,room.Guest!],Request.ServerToClientStartGame,room.Game);
                    Invoke(() => UpdateRoomList());
                    Invoke(() => UpdatePlayerList());

                }
                else
                {
                    room.StartGameFlag = true;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
           
        }

        //UI
        private void UpdateRoomList()
        {
            listRooms.Items.Clear();
            foreach (var r in Rooms)
            {
                string[] s = { $"{r.RoomId}", r.RoomName, r.Owner.Name};
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
