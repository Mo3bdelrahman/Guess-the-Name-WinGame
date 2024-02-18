using System.Net;
using System.Net.Sockets;

namespace Server_Application
{
    public partial class ServerForm : Form
    {
        List<Player> Players = new List<Player>();
        List<Room> Rooms = new List<Room>();
        TcpListener server;
        Thread clientThread;
        Thread serverThread;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerThread()
        {
            server = new TcpListener(IPAddress.Any, 8080);
            server.Start();

            MessageBox.Show("Server Started");

            try
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    clientThread = new Thread(new ParameterizedThreadStart(ConnectToClient));
                    clientThread.Start(client);
                }
            }
            finally
            {
                server.Stop();
            }
        }

        private void ConnectToClient(object client)
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
        public void StartServer()
        {
            btnStart.Enabled = false;
            serverThread = new Thread(ServerThread);
            serverThread.Start();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            StartServer();
        }

    }
}
