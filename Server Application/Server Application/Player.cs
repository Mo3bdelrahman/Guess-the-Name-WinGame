using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Server_Application
{
    internal class Player
    {
        [JsonIgnore]
        public TcpClient Client { set; get; }
        public string Name { set; get; }
        PlayerState state;
        public Player(TcpClient client)
        {
            this.Client = client;
            this.state = PlayerState.Available;
        }
        public PlayerState getState()
        { return state; }
        public void setState(PlayerState state)
        { this.state = state; }

    }
}
