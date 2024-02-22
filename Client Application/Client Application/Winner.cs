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
    public partial class Winner : Form
    {
        public Winner()
        {
            InitializeComponent();
        }

        private void ExitWinnerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Play Again ?"," ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);                     
        }
    }
}
