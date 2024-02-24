using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Application
{
    
    public partial class Loser : Form
    {
        public DialogResult Result { get; set; }
        public Loser()
        {
            InitializeComponent();
            Show();
            Result = MessageBox.Show("Do You Want To Play Again ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void ExitWinnerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
