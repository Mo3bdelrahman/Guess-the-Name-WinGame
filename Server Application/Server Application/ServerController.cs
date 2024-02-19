
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net;


namespace Server_Application
{
    public partial class ServerForm
    {
        private void RequestHandeller(Player[] players, Request request)
        {
            try
            {
                foreach (Player player in players)
                {
                    if (player != null)
                    {
                        BinaryWriter binaryWriter = new BinaryWriter(player.Client.GetStream());
                        string jsonRequest = JsonSerializer.Serialize<Request>(request);
                        List<string> jsonParams = new List<string>();
                        binaryWriter.Write(jsonRequest);
                        binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }

        }
        private void RequestHandeller<T1>(Player[] players ,Request request, T1 param1)
        {
            try
            {
                foreach (Player player in players)
                {
                    if (player != null)
                    {
                        BinaryWriter binaryWriter = new BinaryWriter(player.Client.GetStream());
                        string jsonRequest = JsonSerializer.Serialize<Request>(request);
                        List<string> jsonParams = new List<string>();
                        jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                        binaryWriter.Write(jsonRequest);
                        binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
                    }
                }
                
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }
           
        }
        private void RequestHandeller<T1, T2>(Player[] players, Request request, T1 param1, T2 param2)
        {
            try
            {
                foreach (Player player in players)
                {
                    if (player != null)
                    {
                        BinaryWriter binaryWriter = new BinaryWriter(player.Client.GetStream());
                        string jsonRequest = JsonSerializer.Serialize<Request>(request);
                        List<string> jsonParams = new List<string>();
                        jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                        jsonParams.Add(JsonSerializer.Serialize<T2>(param2));
                        binaryWriter.Write(jsonRequest);
                        binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
                    }
                }
                
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }

        }
        private void RequestHandeller<T1, T2, T3>(Player[] players, Request request, T1 param1, T2 param2, T3 param3)
        {
            try
            {
                foreach (Player player in players)
                {
                    if (player != null)
                    {
                        BinaryWriter binaryWriter = new BinaryWriter(player.Client.GetStream());
                        string jsonRequest = JsonSerializer.Serialize<Request>(request);
                        List<string> jsonParams = new List<string>();
                        jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                        jsonParams.Add(JsonSerializer.Serialize<T2>(param2));
                        jsonParams.Add(JsonSerializer.Serialize<T3>(param3));
                        binaryWriter.Write(jsonRequest);
                        binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }


        }
        private void RequestHandeller<T1, T2, T3, T4>(Player[] players, Request request, T1 param1, T2 param2, T3 param3, T4 param4)
        {
            try
            {
                foreach (Player player in players)
                {
                    if (player != null)
                    {
                        BinaryWriter binaryWriter = new BinaryWriter(player.Client.GetStream());
                        string jsonRequest = JsonSerializer.Serialize<Request>(request);
                        List<string> jsonParams = new List<string>();
                        jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                        jsonParams.Add(JsonSerializer.Serialize<T2>(param2));
                        jsonParams.Add(JsonSerializer.Serialize<T3>(param3));
                        jsonParams.Add(JsonSerializer.Serialize<T4>(param4));
                        binaryWriter.Write(jsonRequest);
                        binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }
            

        }
        private void ResponseHandeller(NetworkStream networkStream)
        {
            try
            {
                BinaryReader binaryReader = new BinaryReader(networkStream);
                string strReq = binaryReader.ReadString();
                string strPara = binaryReader.ReadString();
                Request request = JsonSerializer.Deserialize<Request>(strReq);
                List<string>? para = JsonSerializer.Deserialize<List<string>>(strPara);
                Distributer(networkStream, request, para!);
            }
            catch (Exception ex) { MessageBox.Show("From ResponseHandeller " + ex.Message); }     
        }
        
        private void Distributer(NetworkStream stream, Request req, List<string> para)
        {
            switch(req)
            {
                case Request.ClientToServerLogin: SetPlayerData(stream, para); break;
                default: MessageBox.Show($"{req}"); break;
            }
        }
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
                RequestHandeller<bool, Player>([p], Request.ServerToClientLogin, true, p);
            }
            catch
            {
                RequestHandeller<bool>([p], Request.ServerToClientLogin, false);
            }
        }

    }
}