namespace Client_Application
{
    partial class Winner
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            ExitWinnerButton = new Guna.UI2.WinForms.Guna2CircleButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ExitWinnerButton
            // 
            ExitWinnerButton.BackColor = Color.White;
            ExitWinnerButton.Cursor = Cursors.Hand;
            ExitWinnerButton.DisabledState.BorderColor = Color.DarkGray;
            ExitWinnerButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ExitWinnerButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExitWinnerButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExitWinnerButton.FillColor = Color.Red;
            ExitWinnerButton.Font = new Font("Ravie", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitWinnerButton.ForeColor = Color.White;
            ExitWinnerButton.Location = new Point(512, 4);
            ExitWinnerButton.Name = "ExitWinnerButton";
            ExitWinnerButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ExitWinnerButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ExitWinnerButton.Size = new Size(34, 37);
            ExitWinnerButton.TabIndex = 2;
            ExitWinnerButton.Text = "X";
            ExitWinnerButton.Click += ExitWinnerButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(556, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Winner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(556, 479);
            Controls.Add(ExitWinnerButton);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Winner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Winner";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton ExitWinnerButton;
        private PictureBox pictureBox1;
    }
}