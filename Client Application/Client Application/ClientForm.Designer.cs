using System.Windows.Forms;
using System.Xml.Linq;

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
            LoginPanel = new Panel();
            LoobyPanel = new Panel();
            RoomLoobyPanel = new Panel();
            GamePanel = new Panel();
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
            Player2Label = new Label();
            Player1Label = new Label();
            VSLabel = new Label();
            StartButton = new Button();
            LeaveButton = new Button();
            listView1 = new ListView();
            WatchGameButton = new Button();
            JoinRoomButton = new Button();
            CreateRoomButton = new Button();
            LoginButton = new Button();
            UserNameTextBox = new TextBox();
            UserNameLabel = new Label();
            LoginPanel.SuspendLayout();
            LoobyPanel.SuspendLayout();
            RoomLoobyPanel.SuspendLayout();
            GamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.BackColor = SystemColors.GradientActiveCaption;
            LoginPanel.Controls.Add(LoobyPanel);
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Controls.Add(UserNameTextBox);
            LoginPanel.Controls.Add(UserNameLabel);
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(800, 450);
            LoginPanel.TabIndex = 0;
            // 
            // LoobyPanel
            // 
            LoobyPanel.Anchor = AnchorStyles.None;
            LoobyPanel.Controls.Add(RoomLoobyPanel);
            LoobyPanel.Controls.Add(listView1);
            LoobyPanel.Controls.Add(WatchGameButton);
            LoobyPanel.Controls.Add(JoinRoomButton);
            LoobyPanel.Controls.Add(CreateRoomButton);
            LoobyPanel.Location = new Point(3, 3);
            LoobyPanel.Name = "LoobyPanel";
            LoobyPanel.Size = new Size(800, 449);
            LoobyPanel.TabIndex = 3;
            LoobyPanel.Visible = false;
            // 
            // RoomLoobyPanel
            // 
            RoomLoobyPanel.Anchor = AnchorStyles.None;
            RoomLoobyPanel.Controls.Add(GamePanel);
            RoomLoobyPanel.Controls.Add(Player2Label);
            RoomLoobyPanel.Controls.Add(Player1Label);
            RoomLoobyPanel.Controls.Add(VSLabel);
            RoomLoobyPanel.Controls.Add(StartButton);
            RoomLoobyPanel.Controls.Add(LeaveButton);
            RoomLoobyPanel.Location = new Point(0, 3);
            RoomLoobyPanel.Name = "RoomLoobyPanel";
            RoomLoobyPanel.Size = new Size(800, 461);
            RoomLoobyPanel.TabIndex = 4;
            RoomLoobyPanel.Visible = false;
            // 
            // GamePanel
            // 
            GamePanel.Anchor = AnchorStyles.None;
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
            GamePanel.Location = new Point(0, 3);
            GamePanel.Name = "GamePanel";
            GamePanel.Size = new Size(800, 484);
            GamePanel.TabIndex = 6;
            GamePanel.Visible = false;
            // 
            // PlayerTurnLabel
            // 
            PlayerTurnLabel.AutoSize = true;
            PlayerTurnLabel.Font = new Font("Segoe UI", 16.2F);
            PlayerTurnLabel.Location = new Point(313, 53);
            PlayerTurnLabel.Name = "PlayerTurnLabel";
            PlayerTurnLabel.Size = new Size(158, 38);
            PlayerTurnLabel.TabIndex = 28;
            PlayerTurnLabel.Text = "Player Turn";
            // 
            // DashLabel
            // 
            DashLabel.AutoSize = true;
            DashLabel.Font = new Font("Segoe UI", 13.8F);
            DashLabel.Location = new Point(352, 150);
            DashLabel.Name = "DashLabel";
            DashLabel.Size = new Size(77, 31);
            DashLabel.TabIndex = 27;
            DashLabel.Text = "-------";
            // 
            // QButton
            // 
            QButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            QButton.Location = new Point(102, 258);
            QButton.Name = "QButton";
            QButton.Size = new Size(51, 47);
            QButton.TabIndex = 26;
            QButton.Text = "Q";
            QButton.UseVisualStyleBackColor = true;
            // 
            // EButton
            // 
            EButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            EButton.Location = new Point(218, 258);
            EButton.Name = "EButton";
            EButton.Size = new Size(51, 47);
            EButton.TabIndex = 25;
            EButton.Text = "E";
            EButton.UseVisualStyleBackColor = true;
            // 
            // RButton
            // 
            RButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            RButton.Location = new Point(276, 258);
            RButton.Name = "RButton";
            RButton.Size = new Size(51, 47);
            RButton.TabIndex = 24;
            RButton.Text = "R";
            RButton.UseVisualStyleBackColor = true;
            // 
            // TButton
            // 
            TButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            TButton.Location = new Point(334, 258);
            TButton.Name = "TButton";
            TButton.Size = new Size(51, 47);
            TButton.TabIndex = 23;
            TButton.Text = "T";
            TButton.UseVisualStyleBackColor = true;
            // 
            // PButton
            // 
            PButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            PButton.Location = new Point(624, 258);
            PButton.Name = "PButton";
            PButton.Size = new Size(51, 47);
            PButton.TabIndex = 22;
            PButton.Text = "P";
            PButton.UseVisualStyleBackColor = true;
            // 
            // KButton
            // 
            KButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            KButton.Location = new Point(534, 311);
            KButton.Name = "KButton";
            KButton.Size = new Size(51, 47);
            KButton.TabIndex = 21;
            KButton.Text = "K";
            KButton.UseVisualStyleBackColor = true;
            // 
            // AButton
            // 
            AButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            AButton.Location = new Point(135, 311);
            AButton.Name = "AButton";
            AButton.Size = new Size(51, 47);
            AButton.TabIndex = 20;
            AButton.Text = "A";
            AButton.UseVisualStyleBackColor = true;
            // 
            // LButton
            // 
            LButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            LButton.Location = new Point(591, 311);
            LButton.Name = "LButton";
            LButton.Size = new Size(51, 47);
            LButton.TabIndex = 19;
            LButton.Text = "L";
            LButton.UseVisualStyleBackColor = true;
            // 
            // IButton
            // 
            IButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            IButton.Location = new Point(508, 258);
            IButton.Name = "IButton";
            IButton.Size = new Size(51, 47);
            IButton.TabIndex = 18;
            IButton.Text = "I";
            IButton.UseVisualStyleBackColor = true;
            // 
            // OButton
            // 
            OButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            OButton.Location = new Point(566, 258);
            OButton.Name = "OButton";
            OButton.Size = new Size(51, 47);
            OButton.TabIndex = 17;
            OButton.Text = "O";
            OButton.UseVisualStyleBackColor = true;
            // 
            // VButton
            // 
            VButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            VButton.Location = new Point(363, 364);
            VButton.Name = "VButton";
            VButton.Size = new Size(51, 47);
            VButton.TabIndex = 16;
            VButton.Text = "V";
            VButton.UseVisualStyleBackColor = true;
            // 
            // NButton
            // 
            NButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            NButton.Location = new Point(477, 363);
            NButton.Name = "NButton";
            NButton.Size = new Size(51, 47);
            NButton.TabIndex = 15;
            NButton.Text = "N";
            NButton.UseVisualStyleBackColor = true;
            // 
            // BButton
            // 
            BButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            BButton.Location = new Point(420, 364);
            BButton.Name = "BButton";
            BButton.Size = new Size(51, 47);
            BButton.TabIndex = 14;
            BButton.Text = "B";
            BButton.UseVisualStyleBackColor = true;
            // 
            // MButton
            // 
            MButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            MButton.Location = new Point(534, 364);
            MButton.Name = "MButton";
            MButton.Size = new Size(51, 47);
            MButton.TabIndex = 13;
            MButton.Text = "M";
            MButton.UseVisualStyleBackColor = true;
            // 
            // UButton
            // 
            UButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            UButton.Location = new Point(450, 258);
            UButton.Name = "UButton";
            UButton.Size = new Size(51, 47);
            UButton.TabIndex = 12;
            UButton.Text = "U";
            UButton.UseVisualStyleBackColor = true;
            // 
            // DButton
            // 
            DButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            DButton.Location = new Point(249, 311);
            DButton.Name = "DButton";
            DButton.Size = new Size(51, 47);
            DButton.TabIndex = 11;
            DButton.Text = "D";
            DButton.UseVisualStyleBackColor = true;
            // 
            // FButton
            // 
            FButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            FButton.Location = new Point(306, 311);
            FButton.Name = "FButton";
            FButton.Size = new Size(51, 47);
            FButton.TabIndex = 10;
            FButton.Text = "F";
            FButton.UseVisualStyleBackColor = true;
            // 
            // GButton
            // 
            GButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            GButton.Location = new Point(363, 311);
            GButton.Name = "GButton";
            GButton.Size = new Size(51, 47);
            GButton.TabIndex = 9;
            GButton.Text = "G";
            GButton.UseVisualStyleBackColor = true;
            // 
            // HButton
            // 
            HButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            HButton.Location = new Point(420, 310);
            HButton.Name = "HButton";
            HButton.Size = new Size(51, 47);
            HButton.TabIndex = 8;
            HButton.Text = "H";
            HButton.UseVisualStyleBackColor = true;
            // 
            // JButton
            // 
            JButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            JButton.Location = new Point(477, 311);
            JButton.Name = "JButton";
            JButton.Size = new Size(51, 47);
            JButton.TabIndex = 7;
            JButton.Text = "J";
            JButton.UseVisualStyleBackColor = true;
            // 
            // XButton
            // 
            XButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            XButton.Location = new Point(249, 364);
            XButton.Name = "XButton";
            XButton.Size = new Size(51, 47);
            XButton.TabIndex = 6;
            XButton.Text = "X";
            XButton.UseVisualStyleBackColor = true;
            // 
            // CButton
            // 
            CButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            CButton.Location = new Point(306, 364);
            CButton.Name = "CButton";
            CButton.Size = new Size(51, 47);
            CButton.TabIndex = 5;
            CButton.Text = "C";
            CButton.UseVisualStyleBackColor = true;
            // 
            // SButton
            // 
            SButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            SButton.Location = new Point(192, 311);
            SButton.Name = "SButton";
            SButton.Size = new Size(51, 47);
            SButton.TabIndex = 4;
            SButton.Text = "S";
            SButton.UseVisualStyleBackColor = true;
            // 
            // YButton
            // 
            YButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            YButton.Location = new Point(392, 258);
            YButton.Name = "YButton";
            YButton.Size = new Size(51, 47);
            YButton.TabIndex = 3;
            YButton.Text = "Y";
            YButton.UseVisualStyleBackColor = true;
            // 
            // WButton
            // 
            WButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            WButton.Location = new Point(160, 258);
            WButton.Name = "WButton";
            WButton.Size = new Size(51, 47);
            WButton.TabIndex = 2;
            WButton.Text = "W";
            WButton.UseVisualStyleBackColor = true;
            // 
            // ZButton
            // 
            ZButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            ZButton.Location = new Point(192, 364);
            ZButton.Name = "ZButton";
            ZButton.Size = new Size(51, 47);
            ZButton.TabIndex = 1;
            ZButton.Text = "Z";
            ZButton.UseVisualStyleBackColor = true;
            // 
            // Player2Label
            // 
            Player2Label.AutoSize = true;
            Player2Label.Location = new Point(638, 76);
            Player2Label.Name = "Player2Label";
            Player2Label.Size = new Size(57, 20);
            Player2Label.TabIndex = 5;
            Player2Label.Text = "Player2";
            // 
            // Player1Label
            // 
            Player1Label.AutoSize = true;
            Player1Label.Location = new Point(87, 67);
            Player1Label.Name = "Player1Label";
            Player1Label.Size = new Size(57, 20);
            Player1Label.TabIndex = 4;
            Player1Label.Text = "Player1";
            // 
            // VSLabel
            // 
            VSLabel.AutoSize = true;
            VSLabel.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            VSLabel.Location = new Point(327, 34);
            VSLabel.Name = "VSLabel";
            VSLabel.Size = new Size(142, 106);
            VSLabel.TabIndex = 3;
            VSLabel.Text = "VS";
            // 
            // StartButton
            // 
            StartButton.Location = new Point(159, 249);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // LeaveButton
            // 
            LeaveButton.Location = new Point(482, 249);
            LeaveButton.Name = "LeaveButton";
            LeaveButton.Size = new Size(94, 29);
            LeaveButton.TabIndex = 2;
            LeaveButton.Text = "Leave";
            LeaveButton.UseVisualStyleBackColor = true;
            LeaveButton.Click += LeaveButton_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(352, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(424, 560);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // WatchGameButton
            // 
            WatchGameButton.Location = new Point(41, 214);
            WatchGameButton.Name = "WatchGameButton";
            WatchGameButton.Size = new Size(133, 29);
            WatchGameButton.TabIndex = 2;
            WatchGameButton.Text = "Watch Game";
            WatchGameButton.UseVisualStyleBackColor = true;
            WatchGameButton.Click += WatchGameButton_Click;
            // 
            // JoinRoomButton
            // 
            JoinRoomButton.Location = new Point(41, 325);
            JoinRoomButton.Name = "JoinRoomButton";
            JoinRoomButton.Size = new Size(133, 29);
            JoinRoomButton.TabIndex = 1;
            JoinRoomButton.Text = "Join Room";
            JoinRoomButton.UseVisualStyleBackColor = true;
            JoinRoomButton.Click += JoinRoomButton_Click;
            // 
            // CreateRoomButton
            // 
            CreateRoomButton.Location = new Point(41, 100);
            CreateRoomButton.Name = "CreateRoomButton";
            CreateRoomButton.Size = new Size(133, 29);
            CreateRoomButton.TabIndex = 0;
            CreateRoomButton.Text = "Create Room";
            CreateRoomButton.UseVisualStyleBackColor = true;
            CreateRoomButton.Click += CreateRoomButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(337, 325);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(352, 184);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(303, 27);
            UserNameTextBox.TabIndex = 1;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(116, 191);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(82, 20);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "User Name";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginPanel);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += ClientForm_FormClosing;
            Load += Form1_Load;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            LoobyPanel.ResumeLayout(false);
            RoomLoobyPanel.ResumeLayout(false);
            RoomLoobyPanel.PerformLayout();
            GamePanel.ResumeLayout(false);
            GamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private TextBox UserNameTextBox;
        private Label UserNameLabel;
        private Panel LoobyPanel;
        private Button LoginButton;
        private Button WatchGameButton;
        private Button JoinRoomButton;
        private Button CreateRoomButton;
        private ListView listView1;
        private Panel RoomLoobyPanel;
        private Button StartButton;
        private Button LeaveButton;
        private Label Player1Label;
        private Label VSLabel;
        private Label Player2Label;
        private Panel GamePanel;
        private Label PlayerTurnLabel;
        private Label DashLabel;
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
        private Button UButton;
        private Button DButton;
        private Button FButton;
        private Button GButton;
        private Button HButton;
        private Button JButton;
        private Button XButton;
        private Button CButton;
        private Button SButton;
        private Button YButton;
        private Button WButton;
        private Button ZButton;
    }
}