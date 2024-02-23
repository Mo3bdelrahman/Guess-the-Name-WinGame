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
        int RoomIdG;
        int PlayerIdG;

        public ServerForm()
        {
            InitializeComponent();
            ServerController.DistributerD += Distributer;
            RoomIdG = 0;
            PlayerIdG = 0;
            listRooms.View = View.Details;
            listRooms.Columns.Add("Room ID", 100);
            listRooms.Columns.Add("Room Name", 100);
            listRooms.Columns.Add("Room Owner", 100);
            listPlayers.View = View.Details;
            listPlayers.Columns.Add("Player Name", 100);
            listPlayers.Columns.Add("Player State", 100);
            //for test
            Logger.Write(Log.General, "Hello from general log1");
            Logger.Write(Log.General, "Hello from general log2");
            Logger.Write(Log.ServerError, "Hello from server error log1");
            Logger.Write(Log.ClientError, "Hello from client error log1");
            Logger.Write(Log.GameResult, "Moahmed wins ");
            Logger.Write(Log.GameResult, "Zeyad winssssssss");


            LogsComboBox.Items.AddRange([Log.All, Log.General, Log.GameResult, Log.ServerError, Log.ClientError]);
            LogsComboBox.SelectedIndex = 0;
            //LogsListBox.Items.AddRange(Logger.Read(Log.All).ToArray());


            // Rooms.Add(new Room()) ;
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
            TcpClient Client = client as TcpClient;
            Player player = new Player(Client, ++PlayerIdG);
            try
            {
                Players.Add(player);
                NetworkStream stream = player.Client.GetStream();

                ServerController.ResponseHandeller(stream);

                while (Client.Connected)
                {
                    if (stream.DataAvailable)
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        WordCategory.AddCategory("team", selectedFilePath);
                        string str = String.Join(", ", WordCategory.GetAllCategories());
                        MessageBox.Show(str);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Category Doesn't Exist", "Wrong Category", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }

        private void LogsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log selectedValue = (Log)LogsComboBox.SelectedItem!;
            LogsListBox.Items.Clear();
            LogsListBox.Items.AddRange(Logger.Read(selectedValue).ToArray());
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            Log selectedValue = (Log)LogsComboBox.SelectedItem!;

            bool res = Logger.ExportLogs(selectedValue);
            if (res)
            {
                MessageBox.Show("Congrats, Successfull Exportation");
                Logger.Write(Log.General, "Congrats, Successfull Exportation");
            }
            else
            {
                MessageBox.Show("Sorry, Unsuccessfull Exportation");
                Logger.Write(Log.ServerError, "Sorry, Unsuccessfull Exportation");
            }
        }
    }
}
