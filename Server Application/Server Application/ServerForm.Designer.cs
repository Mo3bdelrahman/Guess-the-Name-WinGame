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
            TabData = new TabControl();
            tabPlayers = new TabPage();
            listPlayers = new ListView();
            tabRooms = new TabPage();
            listRooms = new ListView();
            tabResults = new TabPage();
            listResults = new ListView();
            LogPage = new TabPage();
            btnStart = new Button();
            button1 = new Button();
            TabData.SuspendLayout();
            tabPlayers.SuspendLayout();
            tabRooms.SuspendLayout();
            tabResults.SuspendLayout();
            SuspendLayout();
            // 
            // TabData
            // 
            TabData.Controls.Add(tabPlayers);
            TabData.Controls.Add(tabRooms);
            TabData.Controls.Add(tabResults);
            TabData.Controls.Add(LogPage);
            TabData.Location = new Point(31, 24);
            TabData.Name = "TabData";
            TabData.SelectedIndex = 0;
            TabData.Size = new Size(738, 379);
            TabData.TabIndex = 0;
            // 
            // tabPlayers
            // 
            tabPlayers.Controls.Add(listPlayers);
            tabPlayers.Location = new Point(4, 29);
            tabPlayers.Name = "tabPlayers";
            tabPlayers.Padding = new Padding(3, 3, 3, 3);
            tabPlayers.Size = new Size(730, 346);
            tabPlayers.TabIndex = 0;
            tabPlayers.Text = "Active Players";
            tabPlayers.UseVisualStyleBackColor = true;
            // 
            // listPlayers
            // 
            listPlayers.Location = new Point(6, 5);
            listPlayers.Name = "listPlayers";
            listPlayers.Size = new Size(718, 335);
            listPlayers.TabIndex = 0;
            listPlayers.UseCompatibleStateImageBehavior = false;
            listPlayers.View = View.List;
            // 
            // tabRooms
            // 
            tabRooms.Controls.Add(listRooms);
            tabRooms.Location = new Point(4, 29);
            tabRooms.Name = "tabRooms";
            tabRooms.Padding = new Padding(3, 3, 3, 3);
            tabRooms.RightToLeft = RightToLeft.Yes;
            tabRooms.Size = new Size(730, 346);
            tabRooms.TabIndex = 1;
            tabRooms.Text = "All Rooms";
            tabRooms.UseVisualStyleBackColor = true;
            // 
            // listRooms
            // 
            listRooms.Location = new Point(6, 5);
            listRooms.Name = "listRooms";
            listRooms.Size = new Size(718, 335);
            listRooms.TabIndex = 0;
            listRooms.UseCompatibleStateImageBehavior = false;
            listRooms.View = View.List;
            // 
            // tabResults
            // 
            tabResults.Controls.Add(listResults);
            tabResults.Location = new Point(4, 29);
            tabResults.Name = "tabResults";
            tabResults.Padding = new Padding(3, 3, 3, 3);
            tabResults.Size = new Size(730, 346);
            tabResults.TabIndex = 2;
            tabResults.Text = "Game Results";
            tabResults.UseVisualStyleBackColor = true;
            // 
            // listResults
            // 
            listResults.Location = new Point(6, 5);
            listResults.Name = "listResults";
            listResults.Size = new Size(718, 335);
            listResults.TabIndex = 0;
            listResults.UseCompatibleStateImageBehavior = false;
            listResults.View = View.List;
            // 
            // LogPage
            // 
            LogPage.Location = new Point(4, 29);
            LogPage.Margin = new Padding(3, 4, 3, 4);
            LogPage.Name = "LogPage";
            LogPage.Padding = new Padding(3, 4, 3, 4);
            LogPage.Size = new Size(730, 346);
            LogPage.TabIndex = 3;
            LogPage.Text = "Logs";
            LogPage.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(327, 409);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start The Server";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // button1
            // 
            button1.Location = new Point(611, 410);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Test_Click;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button1);
            Controls.Add(btnStart);
            Controls.Add(TabData);
            Name = "ServerForm";
            Text = "Server";
            FormClosing += ServerForm_FormClosing;
            TabData.ResumeLayout(false);
            tabPlayers.ResumeLayout(false);
            tabRooms.ResumeLayout(false);
            tabResults.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabData;
        private TabPage tabPlayers;
        private TabPage tabRooms;
        private TabPage tabResults;
        private Button btnStart;
        private ListView listPlayers;
        private ListView listRooms;
        private ListView listResults;
        private TabPage LogPage;
        private Button button1;
    }
}
