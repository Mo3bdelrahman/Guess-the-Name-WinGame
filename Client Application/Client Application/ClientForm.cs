using Client_Application;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Net.Sockets;
using System.Text;

namespace Client_Application
{
    partial class ClientForm : Form
    {
        Player player;
        NetworkStream stream;
        Thread receiveThread;
        List<Panel> panelList = new List<Panel>();
        int index;
        public ClientForm()
        {
            InitializeComponent();
            receiveThread = new Thread(new ThreadStart(ReceiveData));
            ClientController.DistributerD += Distributer;
            player = new Player();
        }

        public bool Connect()
        {
            try
            {
                player.TcpClient = new TcpClient("127.0.0.1", 12345);
                stream = player.TcpClient.GetStream();
                receiveThread.Start();


                return true;
            }
            catch (SocketException ex)
            {
                DialogResult result = MessageBox.Show("Server Is Down...\nPlease Try Again Later", "Server Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                {
                    Connect();
                }

                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ReceiveData()
        {
            while (true)
            {
                bool IsConnected = ClientController.ResponseHandeller(stream);

                if (!IsConnected) 
                {
                    break;
                }
            }
        }

        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text))
            {
                string message = "please Enter your name";
                MessageBox.Show(message);
            }
            else
            {
                bool IsConnected = Connect();

                if (IsConnected)
                {
                    ClientController.RequestHandeller<string>(stream, Request.ClientToServerLogin, UserNameTextBox.Text);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            index = 0;
            panelList.Add(LoginPanel);
            panelList.Add(LoobyPanel);
            panelList[index].Visible = true;
            panelList[index].BringToFront();       

        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {

            ClientController.RequestHandeller<string>(stream, Request.ClientToServerCreateRoom, "cars");
            panelList.Add(RoomLoobyPanel);
            panelList[++index].BringToFront();
            panelList[index].Visible = true;


        }

        private void JoinRoomButton_Click(object sender, EventArgs e)
        {

            RoomLoobyPanel.Visible = true;

        }

        private void WatchGameButton_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = true;
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
           
            if (player.State == PlayerState.Player1)
            {
                ClientController.RequestHandeller<int>(stream, Request.ClientToServerP1LeaveRoomLobby, room.RoomId);
            }
            else if(player.State == PlayerState.Player2)
            {
                ClientController.RequestHandeller<int>(stream, Request.ClientToServerP2LeaveRoomLobby, room.RoomId);
            }
            
 
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            panelList.Add(GamePanel);
            panelList[++index].BringToFront();
            panelList[index].Visible = true;
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Close();
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);

        }
    }
}