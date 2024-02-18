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
        TcpClient client;
        string name;
        PlayerState state;
        public Player(TcpClient client, string name)
        {
            this.client = client;
            this.name = name;
        }

        public TcpClient getClient()
        { return client; }
        public string getName()
        { return name; }
        public PlayerState getState()
        { return state; }
        public void setState(PlayerState state)
        { this.state = state; }

    }
}
