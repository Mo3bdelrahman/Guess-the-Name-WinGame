using System.Net;
using System.Net.Sockets;

namespace Server_Application
{
    internal static class ServerController
    {
        static List<Player> Players = new List<Player>();
        static List<Room> Rooms = new List<Room>();
        static TcpListener server;

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