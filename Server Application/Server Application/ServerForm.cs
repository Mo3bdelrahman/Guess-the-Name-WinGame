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
            ServerController.DistributerD += Distributer;
        }

        private void ServerThread()
        {
            server = new TcpListener(new IPAddress(new byte[] { 127, 0, 0, 1 }), 12345);
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
            TcpClient Client =client as TcpClient;
            Player player = new Player(Client);
            try
            {
                Players.Add(player);
                NetworkStream stream = player.Client.GetStream();

                ServerController.ResponseHandeller(stream);
                MessageBox.Show($"Player {player.Name} is connected");
                while (true)
                {
                    ServerController.ResponseHandeller(stream);
                }
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
        private void Distributer(NetworkStream stream, Request req, List<string> para)
        {
            switch (req)
            {
                case Request.ClientToServerLogin: SetPlayerData(stream, para); break;
                default: MessageBox.Show($"{req}"); break;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            ServerController.RequestHandeller<string>(Players.ToArray(), Request.ServerToClientLogin, "hamada");
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);

        }
    }
}
