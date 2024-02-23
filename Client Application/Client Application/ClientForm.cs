using Client_Application;
using Guna.UI2.WinForms.Suite;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Client_Application
{
    partial class ClientForm : Form
    {
        Player player;
        NetworkStream stream;
        Task receiveTask;
        List<Panel> Panels;
        List<Button> Letters = new List<Button>();
        List<Button> ClickedCharacters = new List<Button>();
        TurnState turnState;
        Panel ActivePanel;
        Button ClickedButton;
        string ActiveRoom;

        public ClientForm()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Rooms", listView1.Width);
            Panels = new List<Panel>() { StartPanel, LoginPanel, LoobyPanel, RoomLoobyPanel, GamePanel };
            AddLetters();
            ActivePanel = StartPanel;
            this.Controls.Add(StartPanel);
            ClientController.DistributerD += Distributer;
            player = new Player();
            InitializeTimer();
        }



        public bool Connect()
        {
            try
            {
                player.TcpClient = new TcpClient("127.0.0.1", 12345);
                stream = player.TcpClient.GetStream();
                receiveTask = Task.Run((Action)ReceiveData);

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

        private async void ReceiveData()
        {
            while (true)
            {
                bool isConnected = await Task.Run(() => ClientController.ResponseHandeller(stream));

                if (!isConnected)
                {
                    timer.Dispose();
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
                }
            }
            timer.Start(); // Start the timer
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            ClientController.RequestHandeller(stream, Request.ClientToServerLoadCategories);
        }

        private void JoinRoomButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Note we need here get id of the selected room from list box
                ClientController.RequestHandeller<int>(stream, Request.ClientToServerAskToJoin, int.Parse(ActiveRoom.Split(' ')[1]));
            }
            catch (Exception ex) { MessageBox.Show("You Cant Join that Room.."); }
             
        }

        private void WatchGameButton_Click(object sender, EventArgs e)
        {
            //OnWatchClick();
            //ViewPanel(GamePanel);
            try
            {
                int id = int.Parse(ActiveRoom.Split(' ')[1]);
                ClientController.RequestHandeller<int>(stream, Request.ClientToServerWatch, id);
            }
            catch{ MessageBox.Show("You Cant Watch that Room.."); }
            
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {

            if (player.State == PlayerState.Player1)
            {
                ClientController.RequestHandeller<int>(stream, Request.ClientToServerP1LeaveRoomLobby, room.RoomId);
            }
            else if (player.State == PlayerState.Player2)
            {
                ClientController.RequestHandeller<int>(stream, Request.ClientToServerP2LeaveRoomLobby, room.RoomId);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            ClientController.RequestHandeller<int>(stream,Request.ClientToServerStartGame,room.RoomId);
        }

        private void XExitLabel_Click(object sender, EventArgs e)
        {
            stream?.Close();
            Environment.Exit(Environment.ExitCode);
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
                //ViewPanel(LoobyPanel);
                ClientController.RequestHandeller<int>(stream,Request.ClientToServerLeaveGame,room.RoomId);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            ViewPanel(LoginPanel);
        }
        private void AddLetters()
        {
            Letters.Add(AButton);
            Letters.Add(BButton);
            Letters.Add(CButton);
            Letters.Add(DButton);
            Letters.Add(EButton);
            Letters.Add(FButton);
            Letters.Add(GButton);
            Letters.Add(HButton);
            Letters.Add(IButton);
            Letters.Add(JButton);
            Letters.Add(KButton);
            Letters.Add(LButton);
            Letters.Add(MButton);
            Letters.Add(NButton);
            Letters.Add(OButton);
            Letters.Add(PButton);
            Letters.Add(QButton);
            Letters.Add(RButton);
            Letters.Add(SButton);
            Letters.Add(TButton);
            Letters.Add(UButton);
            Letters.Add(VButton);
            Letters.Add(WButton);
            Letters.Add(XButton);
            Letters.Add(YButton);
            Letters.Add(ZButton);
        }

        // Custom Event Functions

        private void OnLoginClick()
        {
            Invoke(() => ViewPanel(LoobyPanel));
        }

        private void OnCreateClick()
        {
            Invoke(() =>
            {
                Dialog dialog = new Dialog(Categories);
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ClientController.RequestHandeller<string>(stream, Request.ClientToServerCreateRoom, dialog.cat);
                    ViewPanel(RoomLoobyPanel);
                }
            });
        }

        private void OnCreateResponse()
        {
            Invoke(() =>
            {
                UpdateRoomList();
                Player1Label.Text = room.Owner?.Name;
                Player2Label.Text = "Searching...";
                StartButton.Enabled = false;
            });
            
        }

        private void OnWatchClick()
        {
            Invoke(() =>
            {
                foreach(Button btn in Letters)
                {
                    btn.Visible = false;
                }
                ViewPanel(GamePanel);
            });
        }

        private void OnJoinClick(bool response)
        {
            Invoke(() => 
            {
                if (response) 
                {
                    if (player.State == PlayerState.Player1)
                    {
                        Player2Label.Text = room.Guest?.Name;
                        StartButton.Enabled = true;
                    }
                    else
                    {
                        Player1Label.Text = room.Owner?.Name;
                        Player2Label.Text = room.Guest?.Name;
                        ViewPanel(RoomLoobyPanel);
                    }
                }
            });
        }

        private void OnLeaveClick() 
        {
            Invoke(() => 
            { 
                ViewPanel(LoobyPanel);
                UpdateRoomList();
            });
        }

        private void OnStartClick()
        {
            Invoke(() =>
            {
                if (room.state == RoomState.Running) 
                {
                    ClickedCharacters.Clear();
                    DashLabel.Text = game.Word.CurrentWord;

                    if (player.State == room.Owner?.State)
                    {
                        turnState = TurnState.Player1;
                        PlayerTurnLabel.Text = $"Your Turn";

                        foreach (Button btn in Letters)
                        {
                            btn.Enabled = true;
                        }
                    }
                    else
                    {
                        turnState = TurnState.Player2;
                        PlayerTurnLabel.Text = "Opponent's Turn";
                        foreach (Button btn in Letters)
                        {
                            btn.Enabled = false;
                        }
                    }

                    ViewPanel(GamePanel);
                }
            });
        }

        private void OnCharacterClick(Button btn)
        {
            ClickedCharacters.Add(btn);
            ClientController.RequestHandeller<int,string>(stream,Request.ClientToServerSendChar,room.RoomId,btn.Text);
        }

        private void ToggleTurn(string gChar)
        {
            Invoke(() =>
            {
                foreach(var i in Letters)
                {
                    if(gChar == i.Text)
                    {
                        ClickedCharacters.Add(i);
                    }
                }
               DashLabel.Text = game.Word.CurrentWord;

                if (game.Word.State == WordState.Completed)
                {
                    if (player.State != PlayerState.Watcher)
                    {
                        if (game.TurnState != turnState)
                        {
                            MessageBox.Show("You Lost. Better Luck Next Time");
                        }
                        else
                        {
                            MessageBox.Show("You Win. Congrats on your victory!");
                        }

                        foreach (Button btn in Letters)
                        {
                            btn.Enabled = false;
                        }

                        DialogResult result = MessageBox.Show("Play Again?", "One More Round", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Send To Server
                            ClientController.RequestHandeller<int>(stream, Request.ClientToServerStartGame, room.RoomId);
                        }
                        else
                        {
                            if (player.State == PlayerState.Player1 && room != null)
                            {
                                ClientController.RequestHandeller<int>(stream, Request.ClientToServerP1LeaveRoomLobby, room.RoomId);
                            }
                            else if (player.State == PlayerState.Player2 && room != null)
                            {
                                ClientController.RequestHandeller<int>(stream, Request.ClientToServerP2LeaveRoomLobby, room.RoomId);
                            }
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Game Is Over!");
                        ViewPanel(LoobyPanel);
                    }
                }
                else
                {
                    if (game.TurnState != turnState)
                    {
                        if (player.State == PlayerState.Watcher)
                        {
                            PlayerTurnLabel.Text = $"{game.TurnState}'s Turn";
                        }
                        else
                        {
                            PlayerTurnLabel.Text = $"Opponent's Turn";

                            foreach (Button btn in Letters)
                            {
                                btn.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        if ( player.State == PlayerState.Watcher )
                        {
                            PlayerTurnLabel.Text = $"{game.TurnState}'s Turn";
                        }
                        else
                        {
                            PlayerTurnLabel.Text = $"Your Turn";

                            foreach (Button btn in Letters)
                            {
                                if (ClickedCharacters.Contains(btn))
                                {
                                    btn.Enabled = false;
                                }
                                else
                                {
                                    btn.Enabled = true;
                                }
                            }
                        }
                    }
                }
            });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ActiveRoom = listView1.SelectedItems[0].Text;
                WatchGameButton.Enabled = true;
                JoinRoomButton.Enabled = true;
            }
        }

        private void QButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(QButton);
        }

        private void WButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(WButton);
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(EButton);
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(RButton);
        }

        private void TButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(TButton);
        }

        private void YButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(YButton);
        }

        private void UButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(UButton);
        }

        private void IButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(IButton);
        }

        private void OButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(OButton);
        }

        private void PButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(PButton);
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(AButton);
        }

        private void SButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(SButton);
        }

        private void DButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(DButton);
        }

        private void FButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(FButton);
        }

        private void GButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(GButton);
        }

        private void HButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(HButton);
        }

        private void JButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(JButton);
        }

        private void KButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(KButton);
        }

        private void LButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(LButton);
        }

        private void ZButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(ZButton);
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(XButton);
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(CButton);
        }

        private void VButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(VButton);
        }

        private void BButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(BButton);
        }

        private void NButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(NButton);
        }

        private void MButton_Click(object sender, EventArgs e)
        {
            OnCharacterClick(MButton);
        }
        
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Close();
            Environment.Exit(Environment.ExitCode);
            Application.Exit();
        }
    }
}