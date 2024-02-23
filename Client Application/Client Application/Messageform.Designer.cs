namespace Client_Application
{
    partial class Messageform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messageform));
            MessageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            SuspendLayout();
            // 
            // MessageLabel
            // 
            MessageLabel.BackColor = Color.Transparent;
            MessageLabel.Font = new Font("Ravie", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageLabel.ForeColor = Color.FromArgb(0, 0, 64);
            MessageLabel.Location = new Point(197, 104);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(190, 34);
            MessageLabel.TabIndex = 0;
            MessageLabel.Text = "MessageOne";
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.BackColor = Color.Transparent;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.DarkOrange;
            guna2CircleButton1.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(259, 165);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(60, 58);
            guna2CircleButton1.TabIndex = 1;
            guna2CircleButton1.Text = "OK";
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // Messageform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(625, 475);
            Controls.Add(guna2CircleButton1);
            Controls.Add(MessageLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Messageform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message_form";
            TransparencyKey = Color.Black;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel MessageLabel;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}