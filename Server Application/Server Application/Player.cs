using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    internal class Player
    {
        public TcpClient Client { set; get; }
        public string Name { set; get; }
        PlayerState state;
        public Player(TcpClient client, string name)
        {
            this.Client = client;
            this.Name = name;
        }

        public TcpClient getClient()
        { return Client; }
        public string getName()
        { return Name; }
        public PlayerState getState()
        { return state; }
        public void setState(PlayerState state)
        { this.state = state; }

    }
}
