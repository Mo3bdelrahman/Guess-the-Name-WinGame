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
            player = new Player();
        }

        public bool Connect()
        {
            try
            {
                player.TcpClient = new TcpClient("127.0.0.1", 12345);
                stream = player.TcpClient.GetStream();
                receiveThread = new Thread(new ThreadStart(ReceiveData));
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
                ResponseHandeller(stream);
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
                    RequestHandeller<string>(stream, Request.ClientToServerLogin, UserNameTextBox.Text);

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
            panelList[index].Visible = false;
            panelList[--index].BringToFront();
            panelList[index].Visible = true;
            panelList.Remove(panelList[index + 1]);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            panelList.Add(GamePanel);
            panelList[++index].BringToFront();
            panelList[index].Visible = true;
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream.Close();
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);

        }
    }
}