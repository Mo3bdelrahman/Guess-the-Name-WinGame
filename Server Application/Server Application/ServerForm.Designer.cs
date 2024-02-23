namespace Server_Application
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            TabData = new TabControl();
            tabPlayers = new TabPage();
            listPlayers = new ListView();
            tabRooms = new TabPage();
            listRooms = new ListView();
            LogPage = new TabPage();
            LogsListBox = new ListBox();
            ExportBtn = new Button();
            LogsComboBox = new ComboBox();
            btnStart = new Button();
            button1 = new Button();
            TabData.SuspendLayout();
            tabPlayers.SuspendLayout();
            tabRooms.SuspendLayout();
            LogPage.SuspendLayout();
            SuspendLayout();
            // 
            // TabData
            // 
            TabData.Controls.Add(tabPlayers);
            TabData.Controls.Add(tabRooms);
            TabData.Controls.Add(LogPage);
            TabData.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabData.Location = new Point(31, 24);
            TabData.Name = "TabData";
            TabData.SelectedIndex = 0;
            TabData.Size = new Size(745, 380);
            TabData.TabIndex = 0;
            // 
            // tabPlayers
            // 
            tabPlayers.BackColor = Color.FromArgb(23, 30, 64);
            tabPlayers.Controls.Add(listPlayers);
            tabPlayers.Location = new Point(4, 31);
            tabPlayers.Name = "tabPlayers";
            tabPlayers.Padding = new Padding(3);
            tabPlayers.Size = new Size(730, 344);
            tabPlayers.TabIndex = 0;
            tabPlayers.Text = "Active Players";
            // 
            // listPlayers
            // 
            listPlayers.BackColor = SystemColors.InactiveCaption;
            listPlayers.Location = new Point(6, 5);
            listPlayers.Name = "listPlayers";
            listPlayers.Size = new Size(718, 335);
            listPlayers.TabIndex = 0;
            listPlayers.UseCompatibleStateImageBehavior = false;
            listPlayers.View = View.List;
            // 
            // tabRooms
            // 
            tabRooms.BackColor = Color.FromArgb(23, 30, 64);
            tabRooms.Controls.Add(listRooms);
            tabRooms.Location = new Point(4, 31);
            tabRooms.Name = "tabRooms";
            tabRooms.Padding = new Padding(3);
            tabRooms.RightToLeft = RightToLeft.Yes;
            tabRooms.Size = new Size(737, 345);
            tabRooms.TabIndex = 1;
            tabRooms.Text = "All Rooms";
            // 
            // listRooms
            // 
            listRooms.BackColor = SystemColors.InactiveCaption;
            listRooms.Location = new Point(6, 5);
            listRooms.Name = "listRooms";
            listRooms.Size = new Size(718, 335);
            listRooms.TabIndex = 0;
            listRooms.UseCompatibleStateImageBehavior = false;
            listRooms.View = View.List;
            // 
            // LogPage
            // 
            LogPage.BackColor = Color.FromArgb(23, 30, 64);
            LogPage.Controls.Add(LogsListBox);
            LogPage.Controls.Add(ExportBtn);
            LogPage.Controls.Add(LogsComboBox);
            LogPage.Location = new Point(4, 31);
            LogPage.Margin = new Padding(3, 4, 3, 4);
            LogPage.Name = "LogPage";
            LogPage.Padding = new Padding(3, 4, 3, 4);
            LogPage.Size = new Size(737, 345);
            LogPage.TabIndex = 3;
            LogPage.Text = "Logs";
            // 
            // LogsListBox
            // 
            LogsListBox.BackColor = SystemColors.InactiveCaption;
            LogsListBox.FormattingEnabled = true;
            LogsListBox.HorizontalScrollbar = true;
            LogsListBox.ItemHeight = 22;
            LogsListBox.Location = new Point(4, 48);
            LogsListBox.Name = "LogsListBox";
            LogsListBox.Size = new Size(728, 290);
            LogsListBox.TabIndex = 2;
            // 
            // ExportBtn
            // 
            ExportBtn.BackColor = SystemColors.InactiveCaption;
            ExportBtn.FlatStyle = FlatStyle.Popup;
            ExportBtn.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExportBtn.Location = new Point(446, 8);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(161, 36);
            ExportBtn.TabIndex = 1;
            ExportBtn.Text = "Export";
            ExportBtn.UseVisualStyleBackColor = false;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // LogsComboBox
            // 
            LogsComboBox.BackColor = SystemColors.InactiveCaption;
            LogsComboBox.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogsComboBox.FormattingEnabled = true;
            LogsComboBox.Location = new Point(71, 8);
            LogsComboBox.Name = "LogsComboBox";
            LogsComboBox.Size = new Size(161, 34);
            LogsComboBox.TabIndex = 0;
            LogsComboBox.SelectedIndexChanged += LogsComboBox_SelectedIndexChanged;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.InactiveCaption;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(115, 409);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(161, 36);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start The Server";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(481, 409);
            button1.Name = "button1";
            button1.Size = new Size(161, 36);
            button1.TabIndex = 2;
            button1.Text = "Upload Category";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Test_Click;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 30, 64);
            ClientSize = new Size(800, 451);
            Controls.Add(button1);
            Controls.Add(btnStart);
            Controls.Add(TabData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServerForm";
            Text = "Server";
            FormClosing += ServerForm_FormClosing;
            TabData.ResumeLayout(false);
            tabPlayers.ResumeLayout(false);
            tabRooms.ResumeLayout(false);
            LogPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabData;
        private TabPage tabPlayers;
        private TabPage tabRooms;
        private Button btnStart;
        private ListView listPlayers;
        private ListView listRooms;
        private TabPage LogPage;
        private Button button1;
        private ComboBox LogsComboBox;
        private Button ExportBtn;
        private ListBox LogsListBox;
    }
}
