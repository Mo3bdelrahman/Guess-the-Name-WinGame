using static Guna.UI2.WinForms.Suite.Descriptions;

namespace Client_Application
{
    partial class Dialog
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog));
            OkButtonDialog = new Guna.UI2.WinForms.Guna2CircleButton();
            CategoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // OkButtonDialog
            // 
            OkButtonDialog.BackColor = Color.Transparent;
            OkButtonDialog.Cursor = Cursors.Hand;
            OkButtonDialog.DisabledState.BorderColor = Color.DarkGray;
            OkButtonDialog.DisabledState.CustomBorderColor = Color.DarkGray;
            OkButtonDialog.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OkButtonDialog.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OkButtonDialog.FillColor = Color.ForestGreen;
            OkButtonDialog.Font = new Font("Ravie", 9F);
            OkButtonDialog.ForeColor = Color.White;
            OkButtonDialog.Location = new Point(169, 157);
            OkButtonDialog.Name = "OkButtonDialog";
            OkButtonDialog.ShadowDecoration.CustomizableEdges = customizableEdges1;
            OkButtonDialog.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            OkButtonDialog.Size = new Size(87, 77);
            OkButtonDialog.TabIndex = 1;
            OkButtonDialog.Text = "Ok";
            OkButtonDialog.Click += OkButtonDialog_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.BackColor = Color.Transparent;
            CategoryComboBox.BorderRadius = 15;
            CategoryComboBox.Cursor = Cursors.Hand;
            CategoryComboBox.CustomizableEdges = customizableEdges2;
            CategoryComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            CategoryComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CategoryComboBox.Font = new Font("Segoe UI", 10F);
            CategoryComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            CategoryComboBox.ItemHeight = 30;
            CategoryComboBox.Location = new Point(234, 79);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.ShadowDecoration.CustomizableEdges = customizableEdges3;
            CategoryComboBox.Size = new Size(175, 36);
            CategoryComboBox.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Ravie", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Gold;
            guna2HtmlLabel1.Location = new Point(13, 84);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(200, 26);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Choose Category";
            // 
            // Dialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(438, 247);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(CategoryComboBox);
            Controls.Add(OkButtonDialog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dialog";
            Load += Dialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton OkButtonDialog;
        private Guna.UI2.WinForms.Guna2ComboBox CategoryComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}