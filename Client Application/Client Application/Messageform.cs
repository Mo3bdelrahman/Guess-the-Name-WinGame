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
    public partial class Messageform : Form
    {
        public Messageform()
        {
            InitializeComponent();
        }

        public string Message
        {
            set { MessageLabel.Text = value; }

            get
            {

                return MessageLabel.Text;
            }

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
