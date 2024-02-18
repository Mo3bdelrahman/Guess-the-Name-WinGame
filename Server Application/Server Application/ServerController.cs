
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
using System.Net.Sockets;

namespace Server_Application
{
    internal static class ServerController
    {
        public static void RequestHandeller<T1>(NetworkStream networkStream ,Request request, T1 param1)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);
                string jsonRequest = JsonSerializer.Serialize<Request>(request);
                List<string> jsonParams = new List<string>();
                jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                binaryWriter.Write(jsonRequest);
                binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }
           
        }
        public static void RequestHandeller<T1, T2>(NetworkStream networkStream, Request request, T1 param1, T2 param2)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);
                string jsonRequest = JsonSerializer.Serialize<Request>(request);
                List<string> jsonParams = new List<string>();
                jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                jsonParams.Add(JsonSerializer.Serialize<T2>(param2));
                binaryWriter.Write(jsonRequest);
                binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }

        }
        public static void RequestHandeller<T1, T2, T3>(NetworkStream networkStream, Request request, T1 param1, T2 param2, T3 param3)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);
                string jsonRequest = JsonSerializer.Serialize<Request>(request);
                List<string> jsonParams = new List<string>();
                jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                jsonParams.Add(JsonSerializer.Serialize<T2>(param2));
                jsonParams.Add(JsonSerializer.Serialize<T3>(param3));
                binaryWriter.Write(jsonRequest);
                binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }


        }
        public static void RequestHandeller<T1, T2, T3, T4>(NetworkStream networkStream, Request request, T1 param1, T2 param2, T3 param3, T4 param4)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);
                string jsonRequest = JsonSerializer.Serialize<Request>(request);
                List<string> jsonParams = new List<string>();
                jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                jsonParams.Add(JsonSerializer.Serialize<T2>(param2));
                jsonParams.Add(JsonSerializer.Serialize<T3>(param3));
                jsonParams.Add(JsonSerializer.Serialize<T4>(param4));
                binaryWriter.Write(jsonRequest);
                binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }
            

        }
        public static void ResponseHandeller(NetworkStream networkStream)
        {
            try
            {
                BinaryReader binaryReader = new BinaryReader(networkStream);
                string strReq = binaryReader.ReadString();
                string strPara = binaryReader.ReadString();
                Request request = JsonSerializer.Deserialize<Request>(strReq);
                List<string> para = JsonSerializer.Deserialize<List<string>>(strPara);
            }
            catch (Exception ex) { MessageBox.Show("From ResponseHandeller " + ex.Message); }     
        }
        
        private static void BroadcastToClients(string message, List<TcpClient> clients)
        {
            //List<TcpClient> clients = Players.Select(player => player.Client).ToList();

            foreach (TcpClient client in clients)
            {
                try
                {
                    // ( Mohamed Abdelrahman ) -> Stream Code

                    // Data To Be Send To All Clients
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private static void SendToClient(TcpClient client,string from, string to, string body, string? character = null)
        {
            try
            {
                //TcpClient client = Players.Find(client => client.Name == to).Client;

                // ( Mohamed Abdelrahman ) -> Stream Code

                // Data To Be Sent To A Specific Client
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }


    }
}