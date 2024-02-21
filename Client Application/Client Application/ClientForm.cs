using Client_Application;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Net.Sockets;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Client_Application
{
    partial class ClientForm : Form
    {
        Player player;
        NetworkStream stream;
        Thread receiveThread;
        List<Panel> Panels;
        Panel ActivePanel;
        public ClientForm()
        {
            InitializeComponent();
            Panels = new List<Panel>() { LoginPanel, LoobyPanel, RoomLoobyPanel, GamePanel };
            ActivePanel = LoginPanel;
            this.Controls.Add(LoginPanel);
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

        private void ViewPanel(Panel panel)
        {
            foreach (Panel p in Panels)
            {
                if (p == ActivePanel)
                {
                    this.Controls.Remove(p);
                    break;
                }
            }

            foreach (Panel p in Panels)
            {
                if (p == panel)
                {
                    ActivePanel = p;
                    this.Controls.Add(p);
                    break;
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please Enter Your Name", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool IsConnected = Connect();

                if (IsConnected)
                {
                    ClientController.RequestHandeller<string>(stream, Request.ClientToServerLogin, textBox1.Text);
                    ViewPanel(LoobyPanel);
                }
            }
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ClientController.RequestHandeller<string>(stream, Request.ClientToServerCreateRoom, "cars");
                ViewPanel(RoomLoobyPanel);
            }
        }

        private void JoinRoomButton_Click(object sender, EventArgs e)
        {
            ViewPanel(RoomLoobyPanel);
        }

        private void WatchGameButton_Click(object sender, EventArgs e)
        {
            ViewPanel(GamePanel);
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

            ViewPanel(LoobyPanel);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ViewPanel(GamePanel);
        }

        private void XExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void XExitLabel_MouseHover(object sender, EventArgs e)
        {
            XExitLabel1.BackColor = Color.Red;
            XExitLabel2.BackColor = Color.Red;
            XExitLabel3.BackColor = Color.Red;
            XExitLabel4.BackColor = Color.Red;
        }

        private void XExitLabel_MouseLeave(object sender, EventArgs e)
        {
            XExitLabel1.BackColor = Color.Transparent;
            XExitLabel2.BackColor = Color.Transparent;
            XExitLabel3.BackColor = Color.Transparent;
            XExitLabel4.BackColor = Color.Transparent;
        }

        private void LeaveGameButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to leave the game?", "Leave Game Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ViewPanel(LoobyPanel);
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Close();
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }
    }
}