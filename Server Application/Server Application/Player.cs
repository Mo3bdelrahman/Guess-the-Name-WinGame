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
        public PlayerState State { set; get; }
        public int Id { get; set; }
        public Player(TcpClient client,int id)
        {
            this.Client = client;
            this.State = PlayerState.Available;
            Id = id;    
        }


    }
}
