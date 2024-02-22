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

                default: MessageBox.Show($"{req}"); break;
            }
        }
        //Utility
        private Player GetPlayer(NetworkStream stream)
        {
            Player? p = Players.Find(player => player.Client.GetStream() == stream);
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
        }
        private void GetListOfRooms(NetworkStream stream, List<string> jsonStringList)
        {
            Player p = GetPlayer(stream);
            ServerController.RequestHandeller<List<Room>>([p],Request.ServerToClientLoadLobby,Rooms);
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
        }
        private void P2LeaveRoom(NetworkStream stream, List<string> jsonStringList)
        {
            int id = jsonStringList[0].GetOriginalData<int>();
            Player p = GetPlayer(stream);
            Room r = GetRoom(id);

            r.Guest = null;
            p.State = PlayerState.Available;
            ServerController.RequestHandeller<PlayerState>([p], Request.ServerToClientP2LeaveRoomLobby, p.State);
            ServerController.RequestHandeller<Room>([r.Owner!], Request.ServerToClientP2LeaveRoomLobby, r);            
        }
    }
}
