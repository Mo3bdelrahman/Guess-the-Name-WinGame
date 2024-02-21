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
            TabData.Location = new Point(27, 18);
            TabData.Margin = new Padding(3, 2, 3, 2);
            TabData.Name = "TabData";
            TabData.SelectedIndex = 0;
            TabData.Size = new Size(646, 284);
            TabData.TabIndex = 0;
            // 
            // tabPlayers
            // 
            tabPlayers.Controls.Add(listPlayers);
            tabPlayers.Location = new Point(4, 24);
            tabPlayers.Margin = new Padding(3, 2, 3, 2);
            tabPlayers.Name = "tabPlayers";
            tabPlayers.Padding = new Padding(3, 2, 3, 2);
            tabPlayers.Size = new Size(638, 256);
            tabPlayers.TabIndex = 0;
            tabPlayers.Text = "Active Players";
            tabPlayers.UseVisualStyleBackColor = true;
            // 
            // listPlayers
            // 
            listPlayers.Location = new Point(5, 4);
            listPlayers.Margin = new Padding(3, 2, 3, 2);
            listPlayers.Name = "listPlayers";
            listPlayers.Size = new Size(629, 252);
            listPlayers.TabIndex = 0;
            listPlayers.UseCompatibleStateImageBehavior = false;
            listPlayers.View = View.List;
            // 
            // tabRooms
            // 
            tabRooms.Controls.Add(listRooms);
            tabRooms.Location = new Point(4, 24);
            tabRooms.Margin = new Padding(3, 2, 3, 2);
            tabRooms.Name = "tabRooms";
            tabRooms.Padding = new Padding(3, 2, 3, 2);
            tabRooms.RightToLeft = RightToLeft.Yes;
            tabRooms.Size = new Size(638, 256);
            tabRooms.TabIndex = 1;
            tabRooms.Text = "All Rooms";
            tabRooms.UseVisualStyleBackColor = true;
            // 
            // listRooms
            // 
            listRooms.Location = new Point(5, 4);
            listRooms.Margin = new Padding(3, 2, 3, 2);
            listRooms.Name = "listRooms";
            listRooms.Size = new Size(629, 252);
            listRooms.TabIndex = 0;
            listRooms.UseCompatibleStateImageBehavior = false;
            listRooms.View = View.List;
            // 
            // tabResults
            // 
            tabResults.Controls.Add(listResults);
            tabResults.Location = new Point(4, 24);
            tabResults.Margin = new Padding(3, 2, 3, 2);
            tabResults.Name = "tabResults";
            tabResults.Padding = new Padding(3, 2, 3, 2);
            tabResults.Size = new Size(638, 256);
            tabResults.TabIndex = 2;
            tabResults.Text = "Game Results";
            tabResults.UseVisualStyleBackColor = true;
            // 
            // listResults
            // 
            listResults.Location = new Point(5, 4);
            listResults.Margin = new Padding(3, 2, 3, 2);
            listResults.Name = "listResults";
            listResults.Size = new Size(629, 252);
            listResults.TabIndex = 0;
            listResults.UseCompatibleStateImageBehavior = false;
            listResults.View = View.List;
            // 
            // LogPage
            // 
            LogPage.Location = new Point(4, 24);
            LogPage.Name = "LogPage";
            LogPage.Padding = new Padding(3);
            LogPage.Size = new Size(638, 256);
            LogPage.TabIndex = 3;
            LogPage.Text = "Logs";
            LogPage.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(286, 307);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(129, 22);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start The Server";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnStart);
            Controls.Add(TabData);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
