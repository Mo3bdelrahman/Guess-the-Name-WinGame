
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
        static List<Player> Players = new List<Player>();
        static List<Room> Rooms = new List<Room>();
        static TcpListener server;

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
        

        private static void ServerThread()
        {
            server = new TcpListener(IPAddress.Any, 8080);
            server.Start();

            MessageBox.Show("Server Started");

            try
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    Thread clientThread = new Thread(new ParameterizedThreadStart(ConnectToClient));
                    clientThread.Start(client);
                }
            }
            finally
            {
                server.Stop();
            }
        }

        private static void ConnectToClient(object client)
        {
            TcpClient Client = (TcpClient)client;
            // Temporary Player Until Name Is Recieved From The Login
            Player player = new Player(Client, "Zeyad");

            try
            {
                // Temporary Code To Keep The Connection Running
                Players.Add(player);
                MessageBox.Show($"{player.Name} is connected");
                while (true)
                { }

                // ( Mohamed Abdelrahman ) -> Stream Code

                // If It Is The Login Message,
                // Initialize The Player With The Client ( From Above ) And Name ( From Login )
                // Add The Player Using The ServerController.AddPlayer Method
                // A Loop Must Be Added, Waiting For Messages From The Client
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred with a client connection: " + ex.Message);
            }
            finally
            {
                player.Client.Close();
                Players.Remove(player);
                MessageBox.Show($"{player.Name} disconnected.");
            }
        }
        private static void BroadcastToClients(string message)
        {
            List<TcpClient> clients = Players.Select(player => player.Client).ToList();

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

        private static void SendToClient(string from, string to, string body, string? character = null)
        {
            try
            {
                TcpClient client = Players.Find(client => client.Name == to).Client;

                // ( Mohamed Abdelrahman ) -> Stream Code

                // Data To Be Sent To A Specific Client
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public static void StartServer(Button startButton)
        {
            startButton.Enabled = false;
            Thread serverThread = new Thread(ServerThread);
            serverThread.Start();
        }
    }
}