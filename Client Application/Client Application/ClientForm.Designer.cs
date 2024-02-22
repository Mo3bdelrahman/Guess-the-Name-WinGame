using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Windows.Forms.DataFormats;

namespace Client_Application
{
    partial class ClientForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LoginPanel = new Panel();
            textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            LoginButton = new Guna.UI2.WinForms.Guna2Button();
            UserNameLabel = new Label();
            XExitLabel1 = new Label();
            XExitLabel2 = new Label();
            XExitLabel3 = new Label();
            XExitLabel4 = new Label();
            LoobyPanel = new Panel();
            WatchGameButton = new Guna.UI2.WinForms.Guna2Button();
            JoinRoomButton = new Guna.UI2.WinForms.Guna2Button();
            CreateRoomButton = new Guna.UI2.WinForms.Guna2Button();
            listView1 = new ListView();
            RoomLoobyPanel = new Panel();
            LeaveButton = new Guna.UI2.WinForms.Guna2Button();
            StartButton = new Guna.UI2.WinForms.Guna2Button();
            Player2Label = new Label();
            Player1Label = new Label();
            VSLabel = new Label();
            GamePanel = new Panel();
            LeaveGameButton = new Guna.UI2.WinForms.Guna2CircleButton();
            PlayerTurnLabel = new Label();
            DashLabel = new Label();
            QButton = new Button();
            EButton = new Button();
            RButton = new Button();
            TButton = new Button();
            PButton = new Button();
            KButton = new Button();
            AButton = new Button();
            LButton = new Button();
            IButton = new Button();
            OButton = new Button();
            VButton = new Button();
            NButton = new Button();
            BButton = new Button();
            MButton = new Button();
            UButton = new Button();
            DButton = new Button();
            FButton = new Button();
            GButton = new Button();
            HButton = new Button();
            JButton = new Button();
            XButton = new Button();
            CButton = new Button();
            SButton = new Button();
            YButton = new Button();
            WButton = new Button();
            ZButton = new Button();
            StartPanel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            LoginPanel.SuspendLayout();
            LoobyPanel.SuspendLayout();
            RoomLoobyPanel.SuspendLayout();
            GamePanel.SuspendLayout();
            StartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.Transparent;
            LoginPanel.BackgroundImage = (Image)resources.GetObject("LoginPanel.BackgroundImage");
            LoginPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LoginPanel.Controls.Add(textBox1);
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Controls.Add(UserNameLabel);
            LoginPanel.Controls.Add(XExitLabel1);
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(1164, 620);
            LoginPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderRadius = 15;
            textBox1.CustomizableEdges = customizableEdges1;
            textBox1.DefaultText = "";
            textBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.ForeColor = Color.Black;
            textBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox1.Location = new Point(527, 335);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '\0';
            textBox1.PlaceholderText = "";
            textBox1.SelectedText = "";
            textBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textBox1.Size = new Size(293, 39);
            textBox1.TabIndex = 7;
            // 
            // LoginButton
            // 
            LoginButton.BorderRadius = 30;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.CustomizableEdges = customizableEdges3;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.FillColor = Color.MediumSeaGreen;
            LoginButton.Font = new Font("Ravie", 10.8F);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(511, 381);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            LoginButton.Size = new Size(139, 56);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.Click += LoginButton_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Showcard Gothic", 13.8F);
            UserNameLabel.ForeColor = Color.Orange;
            UserNameLabel.Location = new Point(345, 339);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(164, 29);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "Player Name";
            // 
            // XExitLabel1
            // 
            XExitLabel1.AutoSize = true;
            XExitLabel1.Cursor = Cursors.Hand;
            XExitLabel1.Font = new Font("Ravie", 18F, FontStyle.Bold);
            XExitLabel1.ForeColor = SystemColors.ButtonHighlight;
            XExitLabel1.Location = new Point(1107, 9);
            XExitLabel1.Name = "XExitLabel1";
            XExitLabel1.Size = new Size(46, 40);
            XExitLabel1.TabIndex = 6;
            XExitLabel1.Text = "X";
            XExitLabel1.Click += XExitLabel_Click;
            XExitLabel1.MouseLeave += XExitLabel_MouseLeave;
            XExitLabel1.MouseHover += XExitLabel_MouseHover;
            // 
            // XExitLabel2
            // 
            XExitLabel2.AutoSize = true;
            XExitLabel2.Cursor = Cursors.Hand;
            XExitLabel2.Font = new Font("Ravie", 18F, FontStyle.Bold);
            XExitLabel2.ForeColor = SystemColors.ButtonHighlight;
            XExitLabel2.Location = new Point(1101, 9);
            XExitLabel2.Name = "XExitLabel2";
            XExitLabel2.Size = new Size(46, 40);
            XExitLabel2.TabIndex = 6;
            XExitLabel2.Text = "X";
            XExitLabel2.Click += XExitLabel_Click;
            XExitLabel2.MouseLeave += XExitLabel_MouseLeave;
            XExitLabel2.MouseHover += XExitLabel_MouseHover;
            // 
            // XExitLabel3
            // 
            XExitLabel3.AutoSize = true;
            XExitLabel3.Cursor = Cursors.Hand;
            XExitLabel3.Font = new Font("Ravie", 18F, FontStyle.Bold);
            XExitLabel3.ForeColor = SystemColors.ButtonHighlight;
            XExitLabel3.Location = new Point(1106, 9);
            XExitLabel3.Name = "XExitLabel3";
            XExitLabel3.Size = new Size(46, 40);
            XExitLabel3.TabIndex = 6;
            XExitLabel3.Text = "X";
            XExitLabel3.Click += XExitLabel_Click;
            XExitLabel3.MouseLeave += XExitLabel_MouseLeave;
            XExitLabel3.MouseHover += XExitLabel_MouseHover;
            // 
            // XExitLabel4
            // 
            XExitLabel4.AutoSize = true;
            XExitLabel4.Cursor = Cursors.Hand;
            XExitLabel4.Font = new Font("Ravie", 18F, FontStyle.Bold);
            XExitLabel4.ForeColor = SystemColors.ButtonHighlight;
            XExitLabel4.Location = new Point(1104, 9);
            XExitLabel4.Name = "XExitLabel4";
            XExitLabel4.Size = new Size(46, 40);
            XExitLabel4.TabIndex = 6;
            XExitLabel4.Text = "X";
            XExitLabel4.Click += XExitLabel_Click;
            XExitLabel4.MouseLeave += XExitLabel_MouseLeave;
            XExitLabel4.MouseHover += XExitLabel_MouseHover;
            // 
            // LoobyPanel
            // 
            LoobyPanel.BackColor = Color.Transparent;
            LoobyPanel.BackgroundImage = (Image)resources.GetObject("LoobyPanel.BackgroundImage");
            LoobyPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LoobyPanel.Controls.Add(WatchGameButton);
            LoobyPanel.Controls.Add(JoinRoomButton);
            LoobyPanel.Controls.Add(CreateRoomButton);
            LoobyPanel.Controls.Add(listView1);
            LoobyPanel.Controls.Add(XExitLabel2);
            LoobyPanel.Dock = DockStyle.Fill;
            LoobyPanel.Location = new Point(0, 0);
            LoobyPanel.Name = "LoobyPanel";
            LoobyPanel.Size = new Size(1152, 564);
            LoobyPanel.TabIndex = 3;
            // 
            // WatchGameButton
            // 
            WatchGameButton.BorderRadius = 15;
            WatchGameButton.Cursor = Cursors.Hand;
            WatchGameButton.CustomizableEdges = customizableEdges5;
            WatchGameButton.DisabledState.BorderColor = Color.DarkGray;
            WatchGameButton.DisabledState.CustomBorderColor = Color.DarkGray;
            WatchGameButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            WatchGameButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            WatchGameButton.FillColor = Color.SaddleBrown;
            WatchGameButton.Font = new Font("Ravie", 10.8F);
            WatchGameButton.ForeColor = Color.Gold;
            WatchGameButton.Location = new Point(68, 257);
            WatchGameButton.Name = "WatchGameButton";
            WatchGameButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            WatchGameButton.Size = new Size(225, 56);
            WatchGameButton.TabIndex = 8;
            WatchGameButton.Text = "Watch Game";
            WatchGameButton.Click += WatchGameButton_Click;
            // 
            // JoinRoomButton
            // 
            JoinRoomButton.BorderRadius = 15;
            JoinRoomButton.Cursor = Cursors.Hand;
            JoinRoomButton.CustomizableEdges = customizableEdges7;
            JoinRoomButton.DisabledState.BorderColor = Color.DarkGray;
            JoinRoomButton.DisabledState.CustomBorderColor = Color.DarkGray;
            JoinRoomButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            JoinRoomButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            JoinRoomButton.FillColor = Color.SaddleBrown;
            JoinRoomButton.Font = new Font("Ravie", 10.8F);
            JoinRoomButton.ForeColor = Color.Gold;
            JoinRoomButton.Location = new Point(68, 360);
            JoinRoomButton.Name = "JoinRoomButton";
            JoinRoomButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            JoinRoomButton.Size = new Size(225, 56);
            JoinRoomButton.TabIndex = 7;
            JoinRoomButton.Text = "Join Room";
            JoinRoomButton.Click += JoinRoomButton_Click;
            // 
            // CreateRoomButton
            // 
            CreateRoomButton.BorderRadius = 15;
            CreateRoomButton.Cursor = Cursors.Hand;
            CreateRoomButton.CustomizableEdges = customizableEdges9;
            CreateRoomButton.DisabledState.BorderColor = Color.DarkGray;
            CreateRoomButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CreateRoomButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CreateRoomButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CreateRoomButton.FillColor = Color.SaddleBrown;
            CreateRoomButton.Font = new Font("Ravie", 10.8F);
            CreateRoomButton.ForeColor = Color.Gold;
            CreateRoomButton.Location = new Point(68, 145);
            CreateRoomButton.Name = "CreateRoomButton";
            CreateRoomButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            CreateRoomButton.Size = new Size(225, 56);
            CreateRoomButton.TabIndex = 4;
            CreateRoomButton.Text = "Create Room";
            CreateRoomButton.Click += CreateRoomButton_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(23, 30, 46);
            listView1.Location = new Point(417, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(673, 489);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // RoomLoobyPanel
            // 
            RoomLoobyPanel.BackColor = Color.Transparent;
            RoomLoobyPanel.BackgroundImage = (Image)resources.GetObject("RoomLoobyPanel.BackgroundImage");
            RoomLoobyPanel.BackgroundImageLayout = ImageLayout.Stretch;
            RoomLoobyPanel.Controls.Add(LeaveButton);
            RoomLoobyPanel.Controls.Add(StartButton);
            RoomLoobyPanel.Controls.Add(Player2Label);
            RoomLoobyPanel.Controls.Add(Player1Label);
            RoomLoobyPanel.Controls.Add(VSLabel);
            RoomLoobyPanel.Controls.Add(XExitLabel3);
            RoomLoobyPanel.Dock = DockStyle.Fill;
            RoomLoobyPanel.Location = new Point(0, 0);
            RoomLoobyPanel.Name = "RoomLoobyPanel";
            RoomLoobyPanel.Size = new Size(1164, 620);
            RoomLoobyPanel.TabIndex = 4;
            // 
            // LeaveButton
            // 
            LeaveButton.BorderRadius = 25;
            LeaveButton.Cursor = Cursors.Hand;
            LeaveButton.CustomizableEdges = customizableEdges11;
            LeaveButton.DisabledState.BorderColor = Color.DarkGray;
            LeaveButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LeaveButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LeaveButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LeaveButton.FillColor = Color.Red;
            LeaveButton.Font = new Font("Ravie", 10.8F);
            LeaveButton.ForeColor = Color.White;
            LeaveButton.Location = new Point(750, 378);
            LeaveButton.Name = "LeaveButton";
            LeaveButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            LeaveButton.Size = new Size(168, 56);
            LeaveButton.TabIndex = 7;
            LeaveButton.Text = "Leave";
            LeaveButton.Click += LeaveButton_Click;
            // 
            // StartButton
            // 
            StartButton.BorderRadius = 25;
            StartButton.Cursor = Cursors.Hand;
            StartButton.CustomizableEdges = customizableEdges13;
            StartButton.DisabledState.BorderColor = Color.DarkGray;
            StartButton.DisabledState.CustomBorderColor = Color.DarkGray;
            StartButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            StartButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            StartButton.FillColor = Color.LimeGreen;
            StartButton.Font = new Font("Ravie", 10.8F);
            StartButton.ForeColor = Color.White;
            StartButton.Location = new Point(247, 378);
            StartButton.Name = "StartButton";
            StartButton.ShadowDecoration.CustomizableEdges = customizableEdges14;
            StartButton.Size = new Size(168, 56);
            StartButton.TabIndex = 5;
            StartButton.Text = "Start";
            StartButton.Click += StartButton_Click;
            // 
            // Player2Label
            // 
            Player2Label.AutoSize = true;
            Player2Label.Font = new Font("Ravie", 24F, FontStyle.Bold);
            Player2Label.ForeColor = Color.Khaki;
            Player2Label.Location = new Point(787, 113);
            Player2Label.Name = "Player2Label";
            Player2Label.Size = new Size(239, 54);
            Player2Label.TabIndex = 5;
            Player2Label.Text = "Player2";
            // 
            // Player1Label
            // 
            Player1Label.AutoSize = true;
            Player1Label.Font = new Font("Ravie", 24F, FontStyle.Bold);
            Player1Label.ForeColor = Color.Khaki;
            Player1Label.Location = new Point(139, 113);
            Player1Label.Name = "Player1Label";
            Player1Label.Size = new Size(227, 54);
            Player1Label.TabIndex = 4;
            Player1Label.Text = "Player1";
            // 
            // VSLabel
            // 
            VSLabel.AutoSize = true;
            VSLabel.Font = new Font("Ravie", 48F);
            VSLabel.ForeColor = Color.PapayaWhip;
            VSLabel.Location = new Point(487, 74);
            VSLabel.Name = "VSLabel";
            VSLabel.Size = new Size(186, 107);
            VSLabel.TabIndex = 3;
            VSLabel.Text = "VS";
            // 
            // GamePanel
            // 
            GamePanel.BackColor = Color.Transparent;
            GamePanel.BackgroundImage = (Image)resources.GetObject("GamePanel.BackgroundImage");
            GamePanel.BackgroundImageLayout = ImageLayout.Stretch;
            GamePanel.Controls.Add(LeaveGameButton);
            GamePanel.Controls.Add(XExitLabel4);
            GamePanel.Controls.Add(PlayerTurnLabel);
            GamePanel.Controls.Add(DashLabel);
            GamePanel.Controls.Add(QButton);
            GamePanel.Controls.Add(EButton);
            GamePanel.Controls.Add(RButton);
            GamePanel.Controls.Add(TButton);
            GamePanel.Controls.Add(PButton);
            GamePanel.Controls.Add(KButton);
            GamePanel.Controls.Add(AButton);
            GamePanel.Controls.Add(LButton);
            GamePanel.Controls.Add(IButton);
            GamePanel.Controls.Add(OButton);
            GamePanel.Controls.Add(VButton);
            GamePanel.Controls.Add(NButton);
            GamePanel.Controls.Add(BButton);
            GamePanel.Controls.Add(MButton);
            GamePanel.Controls.Add(UButton);
            GamePanel.Controls.Add(DButton);
            GamePanel.Controls.Add(FButton);
            GamePanel.Controls.Add(GButton);
            GamePanel.Controls.Add(HButton);
            GamePanel.Controls.Add(JButton);
            GamePanel.Controls.Add(XButton);
            GamePanel.Controls.Add(CButton);
            GamePanel.Controls.Add(SButton);
            GamePanel.Controls.Add(YButton);
            GamePanel.Controls.Add(WButton);
            GamePanel.Controls.Add(ZButton);
            GamePanel.Dock = DockStyle.Fill;
            GamePanel.Location = new Point(0, 0);
            GamePanel.Name = "GamePanel";
            GamePanel.Size = new Size(1159, 573);
            GamePanel.TabIndex = 6;
            // 
            // LeaveGameButton
            // 
            LeaveGameButton.Cursor = Cursors.Hand;
            LeaveGameButton.DisabledState.BorderColor = Color.DarkGray;
            LeaveGameButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LeaveGameButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LeaveGameButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LeaveGameButton.FillColor = Color.Red;
            LeaveGameButton.Font = new Font("Segoe UI", 9F);
            LeaveGameButton.ForeColor = Color.White;
            LeaveGameButton.Image = (Image)resources.GetObject("LeaveGameButton.Image");
            LeaveGameButton.ImageSize = new Size(40, 40);
            LeaveGameButton.Location = new Point(24, 442);
            LeaveGameButton.Name = "LeaveGameButton";
            LeaveGameButton.ShadowDecoration.CustomizableEdges = customizableEdges15;
            LeaveGameButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            LeaveGameButton.Size = new Size(101, 97);
            LeaveGameButton.TabIndex = 29;
            LeaveGameButton.Click += LeaveGameButton_Click;
            // 
            // PlayerTurnLabel
            // 
            PlayerTurnLabel.AutoSize = true;
            PlayerTurnLabel.Font = new Font("Ravie", 25.8000011F);
            PlayerTurnLabel.ForeColor = Color.PapayaWhip;
            PlayerTurnLabel.Location = new Point(423, 113);
            PlayerTurnLabel.Name = "PlayerTurnLabel";
            PlayerTurnLabel.Size = new Size(380, 59);
            PlayerTurnLabel.TabIndex = 28;
            PlayerTurnLabel.Text = "Player Turn";
            // 
            // DashLabel
            // 
            DashLabel.AutoSize = true;
            DashLabel.Font = new Font("Segoe UI", 24F);
            DashLabel.ForeColor = Color.PapayaWhip;
            DashLabel.Location = new Point(546, 186);
            DashLabel.Name = "DashLabel";
            DashLabel.Size = new Size(135, 54);
            DashLabel.TabIndex = 27;
            DashLabel.Text = "-------";
            // 
            // QButton
            // 
            QButton.BackColor = Color.PapayaWhip;
            QButton.Cursor = Cursors.Hand;
            QButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            QButton.ForeColor = Color.Teal;
            QButton.Location = new Point(325, 361);
            QButton.Name = "QButton";
            QButton.Size = new Size(55, 50);
            QButton.TabIndex = 26;
            QButton.Text = "Q";
            QButton.UseVisualStyleBackColor = false;
            // 
            // EButton
            // 
            EButton.BackColor = Color.PapayaWhip;
            EButton.Cursor = Cursors.Hand;
            EButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            EButton.ForeColor = Color.Teal;
            EButton.Location = new Point(441, 361);
            EButton.Name = "EButton";
            EButton.Size = new Size(55, 50);
            EButton.TabIndex = 25;
            EButton.Text = "E";
            EButton.UseVisualStyleBackColor = false;
            // 
            // RButton
            // 
            RButton.BackColor = Color.PapayaWhip;
            RButton.Cursor = Cursors.Hand;
            RButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            RButton.ForeColor = Color.Teal;
            RButton.Location = new Point(499, 361);
            RButton.Name = "RButton";
            RButton.Size = new Size(55, 50);
            RButton.TabIndex = 24;
            RButton.Text = "R";
            RButton.UseVisualStyleBackColor = false;
            // 
            // TButton
            // 
            TButton.BackColor = Color.PapayaWhip;
            TButton.Cursor = Cursors.Hand;
            TButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            TButton.ForeColor = Color.Teal;
            TButton.Location = new Point(557, 361);
            TButton.Name = "TButton";
            TButton.Size = new Size(55, 50);
            TButton.TabIndex = 23;
            TButton.Text = "T";
            TButton.UseVisualStyleBackColor = false;
            // 
            // PButton
            // 
            PButton.BackColor = Color.PapayaWhip;
            PButton.Cursor = Cursors.Hand;
            PButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            PButton.ForeColor = Color.Teal;
            PButton.Location = new Point(847, 361);
            PButton.Name = "PButton";
            PButton.Size = new Size(55, 50);
            PButton.TabIndex = 22;
            PButton.Text = "P";
            PButton.UseVisualStyleBackColor = false;
            // 
            // KButton
            // 
            KButton.BackColor = Color.PapayaWhip;
            KButton.Cursor = Cursors.Hand;
            KButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            KButton.ForeColor = Color.Teal;
            KButton.Location = new Point(757, 414);
            KButton.Name = "KButton";
            KButton.Size = new Size(55, 50);
            KButton.TabIndex = 21;
            KButton.Text = "K";
            KButton.UseVisualStyleBackColor = false;
            // 
            // AButton
            // 
            AButton.BackColor = Color.PapayaWhip;
            AButton.Cursor = Cursors.Hand;
            AButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            AButton.ForeColor = Color.Teal;
            AButton.Location = new Point(358, 414);
            AButton.Name = "AButton";
            AButton.Size = new Size(55, 50);
            AButton.TabIndex = 20;
            AButton.Text = "A";
            AButton.UseVisualStyleBackColor = false;
            // 
            // LButton
            // 
            LButton.BackColor = Color.PapayaWhip;
            LButton.Cursor = Cursors.Hand;
            LButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            LButton.ForeColor = Color.Teal;
            LButton.Location = new Point(814, 414);
            LButton.Name = "LButton";
            LButton.Size = new Size(55, 50);
            LButton.TabIndex = 19;
            LButton.Text = "L";
            LButton.UseVisualStyleBackColor = false;
            // 
            // IButton
            // 
            IButton.BackColor = Color.PapayaWhip;
            IButton.Cursor = Cursors.Hand;
            IButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            IButton.ForeColor = Color.Teal;
            IButton.Location = new Point(731, 361);
            IButton.Name = "IButton";
            IButton.Size = new Size(55, 50);
            IButton.TabIndex = 18;
            IButton.Text = "I";
            IButton.UseVisualStyleBackColor = false;
            // 
            // OButton
            // 
            OButton.BackColor = Color.PapayaWhip;
            OButton.Cursor = Cursors.Hand;
            OButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            OButton.ForeColor = Color.Teal;
            OButton.Location = new Point(789, 361);
            OButton.Name = "OButton";
            OButton.Size = new Size(55, 50);
            OButton.TabIndex = 17;
            OButton.Text = "O";
            OButton.UseVisualStyleBackColor = false;
            // 
            // VButton
            // 
            VButton.BackColor = Color.PapayaWhip;
            VButton.Cursor = Cursors.Hand;
            VButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            VButton.ForeColor = Color.Teal;
            VButton.Location = new Point(586, 467);
            VButton.Name = "VButton";
            VButton.Size = new Size(55, 50);
            VButton.TabIndex = 16;
            VButton.Text = "V";
            VButton.UseVisualStyleBackColor = false;
            // 
            // NButton
            // 
            NButton.BackColor = Color.PapayaWhip;
            NButton.Cursor = Cursors.Hand;
            NButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            NButton.ForeColor = Color.Teal;
            NButton.Location = new Point(700, 466);
            NButton.Name = "NButton";
            NButton.Size = new Size(55, 50);
            NButton.TabIndex = 15;
            NButton.Text = "N";
            NButton.UseVisualStyleBackColor = false;
            // 
            // BButton
            // 
            BButton.BackColor = Color.PapayaWhip;
            BButton.Cursor = Cursors.Hand;
            BButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            BButton.ForeColor = Color.Teal;
            BButton.Location = new Point(643, 467);
            BButton.Name = "BButton";
            BButton.Size = new Size(55, 50);
            BButton.TabIndex = 14;
            BButton.Text = "B";
            BButton.UseVisualStyleBackColor = false;
            // 
            // MButton
            // 
            MButton.BackColor = Color.PapayaWhip;
            MButton.Cursor = Cursors.Hand;
            MButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            MButton.ForeColor = Color.Teal;
            MButton.Location = new Point(757, 467);
            MButton.Name = "MButton";
            MButton.Size = new Size(55, 50);
            MButton.TabIndex = 13;
            MButton.Text = "M";
            MButton.UseVisualStyleBackColor = false;
            // 
            // UButton
            // 
            UButton.BackColor = Color.PapayaWhip;
            UButton.Cursor = Cursors.Hand;
            UButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            UButton.ForeColor = Color.Teal;
            UButton.Location = new Point(673, 361);
            UButton.Name = "UButton";
            UButton.Size = new Size(55, 50);
            UButton.TabIndex = 12;
            UButton.Text = "U";
            UButton.UseVisualStyleBackColor = false;
            // 
            // DButton
            // 
            DButton.BackColor = Color.PapayaWhip;
            DButton.Cursor = Cursors.Hand;
            DButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            DButton.ForeColor = Color.Teal;
            DButton.Location = new Point(472, 414);
            DButton.Name = "DButton";
            DButton.Size = new Size(55, 50);
            DButton.TabIndex = 11;
            DButton.Text = "D";
            DButton.UseVisualStyleBackColor = false;
            // 
            // FButton
            // 
            FButton.BackColor = Color.PapayaWhip;
            FButton.Cursor = Cursors.Hand;
            FButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            FButton.ForeColor = Color.Teal;
            FButton.Location = new Point(529, 414);
            FButton.Name = "FButton";
            FButton.Size = new Size(55, 50);
            FButton.TabIndex = 10;
            FButton.Text = "F";
            FButton.UseVisualStyleBackColor = false;
            // 
            // GButton
            // 
            GButton.BackColor = Color.PapayaWhip;
            GButton.Cursor = Cursors.Hand;
            GButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            GButton.ForeColor = Color.Teal;
            GButton.Location = new Point(586, 414);
            GButton.Name = "GButton";
            GButton.Size = new Size(55, 50);
            GButton.TabIndex = 9;
            GButton.Text = "G";
            GButton.UseVisualStyleBackColor = false;
            // 
            // HButton
            // 
            HButton.BackColor = Color.PapayaWhip;
            HButton.Cursor = Cursors.Hand;
            HButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            HButton.ForeColor = Color.Teal;
            HButton.Location = new Point(643, 413);
            HButton.Name = "HButton";
            HButton.Size = new Size(55, 50);
            HButton.TabIndex = 8;
            HButton.Text = "H";
            HButton.UseVisualStyleBackColor = false;
            // 
            // JButton
            // 
            JButton.BackColor = Color.PapayaWhip;
            JButton.Cursor = Cursors.Hand;
            JButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            JButton.ForeColor = Color.Teal;
            JButton.Location = new Point(700, 414);
            JButton.Name = "JButton";
            JButton.Size = new Size(55, 50);
            JButton.TabIndex = 7;
            JButton.Text = "J";
            JButton.UseVisualStyleBackColor = false;
            // 
            // XButton
            // 
            XButton.BackColor = Color.PapayaWhip;
            XButton.Cursor = Cursors.Hand;
            XButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            XButton.ForeColor = Color.Teal;
            XButton.Location = new Point(472, 467);
            XButton.Name = "XButton";
            XButton.Size = new Size(55, 50);
            XButton.TabIndex = 6;
            XButton.Text = "X";
            XButton.UseVisualStyleBackColor = false;
            // 
            // CButton
            // 
            CButton.BackColor = Color.PapayaWhip;
            CButton.Cursor = Cursors.Hand;
            CButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            CButton.ForeColor = Color.Teal;
            CButton.Location = new Point(529, 467);
            CButton.Name = "CButton";
            CButton.Size = new Size(55, 50);
            CButton.TabIndex = 5;
            CButton.Text = "C";
            CButton.UseVisualStyleBackColor = false;
            // 
            // SButton
            // 
            SButton.BackColor = Color.PapayaWhip;
            SButton.Cursor = Cursors.Hand;
            SButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            SButton.ForeColor = Color.Teal;
            SButton.Location = new Point(415, 414);
            SButton.Name = "SButton";
            SButton.Size = new Size(55, 50);
            SButton.TabIndex = 4;
            SButton.Text = "S";
            SButton.UseVisualStyleBackColor = false;
            // 
            // YButton
            // 
            YButton.BackColor = Color.PapayaWhip;
            YButton.Cursor = Cursors.Hand;
            YButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            YButton.ForeColor = Color.Teal;
            YButton.Location = new Point(615, 361);
            YButton.Name = "YButton";
            YButton.Size = new Size(55, 50);
            YButton.TabIndex = 3;
            YButton.Text = "Y";
            YButton.UseVisualStyleBackColor = false;
            // 
            // WButton
            // 
            WButton.BackColor = Color.PapayaWhip;
            WButton.Cursor = Cursors.Hand;
            WButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            WButton.ForeColor = Color.Teal;
            WButton.Location = new Point(383, 361);
            WButton.Name = "WButton";
            WButton.Size = new Size(55, 50);
            WButton.TabIndex = 2;
            WButton.Text = "W";
            WButton.UseVisualStyleBackColor = false;
            // 
            // ZButton
            // 
            ZButton.BackColor = Color.PapayaWhip;
            ZButton.Cursor = Cursors.Hand;
            ZButton.Font = new Font("Gill Sans Ultra Bold", 16.2F);
            ZButton.ForeColor = Color.Teal;
            ZButton.Location = new Point(415, 467);
            ZButton.Name = "ZButton";
            ZButton.Size = new Size(55, 50);
            ZButton.TabIndex = 1;
            ZButton.Text = "Z";
            ZButton.UseVisualStyleBackColor = false;
            // 
            // StartPanel
            // 
            StartPanel.Controls.Add(label1);
            StartPanel.Controls.Add(pictureBox1);
            StartPanel.Dock = DockStyle.Fill;
            StartPanel.Location = new Point(0, 0);
            StartPanel.Name = "StartPanel";
            StartPanel.Size = new Size(1164, 620);
            StartPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 41, 56);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(470, 586);
            label1.Name = "label1";
            label1.Size = new Size(258, 32);
            label1.TabIndex = 1;
            label1.Text = "Press Here To Start";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1164, 620);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(23, 30, 46);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1164, 620);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            LoobyPanel.ResumeLayout(false);
            LoobyPanel.PerformLayout();
            RoomLoobyPanel.ResumeLayout(false);
            RoomLoobyPanel.PerformLayout();
            GamePanel.ResumeLayout(false);
            GamePanel.PerformLayout();
            StartPanel.ResumeLayout(false);
            StartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private Label UserNameLabel;
        private Panel LoobyPanel;
        private ListView listView1;
        private Panel RoomLoobyPanel;
        private Label Player1Label;
        private Label VSLabel;
        private Panel GamePanel;
        private Button UButton;
        private Button DButton;
        private Button FButton;
        private Button GButton;
        private Button HButton;
        private Button JButton;
        private Button SButton;
        private Button YButton;
        private Button WButton;
        private Label Player2Label;
        private Button QButton;
        private Button EButton;
        private Button RButton;
        private Button TButton;
        private Button PButton;
        private Button KButton;
        private Button AButton;
        private Button LButton;
        private Button IButton;
        private Button OButton;
        private Button VButton;
        private Button NButton;
        private Button BButton;
        private Button MButton;
        private Button XButton;
        private Button CButton;
        private Button ZButton;
        private Label DashLabel;
        private Label PlayerTurnLabel;
        private Label XExitLabel1;
        private Label XExitLabel2;
        private Label XExitLabel3;
        private Label XExitLabel4;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button WatchGameButton;
        private Guna.UI2.WinForms.Guna2Button JoinRoomButton;
        private Guna.UI2.WinForms.Guna2Button CreateRoomButton;
        private Guna.UI2.WinForms.Guna2Button StartButton;
        private Guna.UI2.WinForms.Guna2Button LeaveButton;
        private Guna.UI2.WinForms.Guna2CircleButton LeaveGameButton;
        private Panel StartPanel;
        private PictureBox pictureBox1;
        private Label label1;
    }
}