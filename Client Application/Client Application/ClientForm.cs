using Client_Application;
using Guna.UI2.WinForms.Suite;
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
        List<Button> Letters = new List<Button>();
        List<string> ClickedCharacters = new List<string>();
        TurnState turnState;
        Panel ActivePanel;
        string ActiveRoom;
        public ClientForm()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Room ID", 50);
            listView1.Columns.Add("Room Name", 100);
            listView1.Columns.Add("Room Owner", 100);
            listView1.Columns.Add("Guest", 100);
            Panels = new List<Panel>() { LoginPanel, LoobyPanel, RoomLoobyPanel, GamePanel };
            AddLetters();
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
                }
            }
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ClientController.RequestHandeller<string>(stream, Request.ClientToServerCreateRoom, ActiveRoom);
            }
        }

        private void JoinRoomButton_Click(object sender, EventArgs e)
        {
            OnJoinResponseReceive();
            //Note we need here get id of the selected room from list box
            ClientController.RequestHandeller<int>(stream,Request.ClientToServerAskToJoin,1);
        }

        private void WatchGameButton_Click(object sender, EventArgs e)
        {
            OnWatchClick();
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

            ViewPanel(LoobyPanel);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            OnStartClick();
            ClientController.RequestHandeller<int>(stream,Request.ClientToServerStartGame,room.RoomId);
        }

        private void XExitLabel_Click(object sender, EventArgs e)
        {
            stream?.Close();
            Application.ExitThread();
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
            OnLeaveClick();
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

        private void FillRooms(List<Room> rooms)
        {
            Invoke(() =>
            {
                listView1.Items.Clear();

                if (rooms.Count > 0)
                {
                    foreach (var room in rooms)
                    {
                        ListViewItem roomItem = new ListViewItem(room.ToString());
                        roomList.Add(room);
                        listView1.Items.Add(roomItem);
                    }
                }
            });
        }

        private void ToggleTurn()
        {
            Invoke(() =>
            {
                if (turnState == TurnState.Player2)
                {
                    foreach (Button btn in Letters)
                    {
                        btn.Enabled = false;
                    }
                }
                else
                {
                    foreach (Button btn in Letters)
                    {
                        if (ClickedCharacters.Contains(btn.Text))
                        {
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.Enabled = true;
                        }
                    }
                }
            });
        }

        private void EnableLetters()
        {
            foreach(Button btn in Letters)
            {
                btn.Visible = true;
                btn.Enabled = true;
            }
        }

        // Custom Event Functions

        private void OnLoginClick()
        {
            Invoke(() => ViewPanel(LoobyPanel));
        }

        private void OnLoadLobby()
        {
            Invoke(() =>
            {
                FillRooms(roomList);

                WatchGameButton.Enabled = false;
                JoinRoomButton.Enabled = false;
            });
        }

        private void OnCreateClick(bool IsCreated)
        {
            Invoke(() =>
            {
                if (IsCreated)
                {
                    ListViewItem roomItem = new ListViewItem(room.ToString());
                    roomList.Add(room);
                    listView1.Items.Add(roomItem);
                    CreateRoomButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Failed To Create Room");
                }
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

        private void OnJoinRequestReceive()
        {
            DialogResult result = MessageBox.Show("Player anything Wants to join your room", "Join Request", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Invoke(() =>
                {
                    ViewPanel(RoomLoobyPanel);
                });
            }
        }

        private void OnJoinResponseReceive()
        {
            Invoke(() =>
            {
                ViewPanel(RoomLoobyPanel);
            });
        }

        private void OnLeaveClick()
        {
            Invoke(() =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to leave the game?", "Leave Game Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ClickedCharacters.Clear();
                    EnableLetters();
                    ViewPanel(LoobyPanel);
                }
            });
        }

        private void OnLeaveReceive()
        {
            Invoke(() =>
            {
                ViewPanel(LoobyPanel);
            });
        }

        private void OnStartClick()
        {
            Invoke(() =>
            {
                ClickedCharacters.Clear();
                if (turnState == TurnState.Player1)
                {
                    turnState = TurnState.Player2;
                    PlayerTurnLabel.Text = "Player 2's Turn";
                    foreach(Button btn in Letters)
                    {
                        btn.Enabled = false;
                    }
                }
                else
                {
                    turnState = TurnState.Player1;
                    PlayerTurnLabel.Text = "Player 1's Turn";
                    foreach (Button btn in Letters)
                    {
                        btn.Enabled = true;
                    }
                }

                ViewPanel(GamePanel);
            });
        }

        private void OnCharacterClick(Button btn)
        {
            Invoke(() =>
            {
                foreach (Button button in Letters)
                {
                    if (button.Text == btn.Text)
                    {
                        ClickedCharacters.Add(button.Text);
                        button.Enabled = false;
                    }
                }

                if (turnState == TurnState.Player1)
                {
                    turnState = TurnState.Player2;
                    PlayerTurnLabel.Text = "Player 2's Turn";
                }
                else
                {
                    turnState = TurnState.Player1;
                    PlayerTurnLabel.Text = "Player 1's Turn";
                }

                ToggleTurn();
            });
        }

        private void OnGameEnd(string result)
        {
            Invoke(() =>
            {
                if (result == "winner")
                    MessageBox.Show("Congrats! You Won");
                else
                    MessageBox.Show("Better Luck Next Time");

                DialogResult confirmation = MessageBox.Show("Do you want to play again?", "One More Round", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    if (result == "winner")
                    {
                        foreach (Button button in Letters)
                        {
                            button.Enabled = true;
                        }

                        turnState = TurnState.Player1;
                        PlayerTurnLabel.Text = "Player1's Turn";
                    }
                    else
                    {
                        foreach (Button button in Letters)
                        {
                            button.Enabled = false;
                        }

                        turnState = TurnState.Player2;
                        PlayerTurnLabel.Text = "Player2's Turn";
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
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
            Application.Exit();
        }
    }
}