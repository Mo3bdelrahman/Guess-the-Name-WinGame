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
        //utility
        private Player GetPlayer(NetworkStream stream)
        {
            Player? p = Players.Find(player => player.Client.GetStream() == stream);
            return p!;
        }
        //response from login
        public void SetPlayerData(NetworkStream stream, List<string> jsonStringList)
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
    }
}
