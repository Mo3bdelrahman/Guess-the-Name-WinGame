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
            tabsData = new TabControl();
            tabPlayers = new TabPage();
            listPlayers = new ListView();
            tabRooms = new TabPage();
            listRooms = new ListView();
            tabResults = new TabPage();
            listResults = new ListView();
            btnStart = new Button();
            tabsData.SuspendLayout();
            tabPlayers.SuspendLayout();
            tabRooms.SuspendLayout();
            tabResults.SuspendLayout();
            SuspendLayout();
            // 
            // tabsData
            // 
            tabsData.Controls.Add(tabPlayers);
            tabsData.Controls.Add(tabRooms);
            tabsData.Controls.Add(tabResults);
            tabsData.Location = new Point(31, 24);
            tabsData.Name = "tabsData";
            tabsData.SelectedIndex = 0;
            tabsData.Size = new Size(738, 379);
            tabsData.TabIndex = 0;
            // 
            // tabPlayers
            // 
            tabPlayers.Controls.Add(listPlayers);
            tabPlayers.Location = new Point(4, 29);
            tabPlayers.Name = "tabPlayers";
            tabPlayers.Padding = new Padding(3);
            tabPlayers.Size = new Size(730, 346);
            tabPlayers.TabIndex = 0;
            tabPlayers.Text = "Active Players";
            tabPlayers.UseVisualStyleBackColor = true;
            // 
            // listPlayers
            // 
            listPlayers.Location = new Point(6, 6);
            listPlayers.Name = "listPlayers";
            listPlayers.Size = new Size(718, 334);
            listPlayers.TabIndex = 0;
            listPlayers.UseCompatibleStateImageBehavior = false;
            listPlayers.View = View.List;
            // 
            // tabRooms
            // 
            tabRooms.Controls.Add(listRooms);
            tabRooms.Location = new Point(4, 29);
            tabRooms.Name = "tabRooms";
            tabRooms.Padding = new Padding(3);
            tabRooms.RightToLeft = RightToLeft.Yes;
            tabRooms.Size = new Size(730, 346);
            tabRooms.TabIndex = 1;
            tabRooms.Text = "All Rooms";
            tabRooms.UseVisualStyleBackColor = true;
            // 
            // listRooms
            // 
            listRooms.Location = new Point(6, 6);
            listRooms.Name = "listRooms";
            listRooms.Size = new Size(718, 334);
            listRooms.TabIndex = 0;
            listRooms.UseCompatibleStateImageBehavior = false;
            listRooms.View = View.List;
            // 
            // tabResults
            // 
            tabResults.Controls.Add(listResults);
            tabResults.Location = new Point(4, 29);
            tabResults.Name = "tabResults";
            tabResults.Padding = new Padding(3);
            tabResults.Size = new Size(730, 346);
            tabResults.TabIndex = 2;
            tabResults.Text = "Game Results";
            tabResults.UseVisualStyleBackColor = true;
            // 
            // listResults
            // 
            listResults.Location = new Point(6, 6);
            listResults.Name = "listResults";
            listResults.Size = new Size(718, 334);
            listResults.TabIndex = 0;
            listResults.UseCompatibleStateImageBehavior = false;
            listResults.View = View.List;
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
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(tabsData);
            Name = "Server";
            Text = "Server";
            tabsData.ResumeLayout(false);
            tabPlayers.ResumeLayout(false);
            tabRooms.ResumeLayout(false);
            tabResults.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabsData;
        private TabPage tabPlayers;
        private TabPage tabRooms;
        private TabPage tabResults;
        private Button btnStart;
        private ListView listPlayers;
        private ListView listRooms;
        private ListView listResults;
    }
}
