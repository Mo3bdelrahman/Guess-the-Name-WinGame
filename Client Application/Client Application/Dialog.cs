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
    public partial class Dialog : Form
    {
        public string cat;
        public Dialog()
        {
            InitializeComponent();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("1", "Food");
            test.Add("2", "Sports");
            test.Add("3", "Languages");

            CategoryComboBox.DataSource = new BindingSource(test, null);
            CategoryComboBox.DisplayMember = "Value";
            CategoryComboBox.ValueMember = "Key";


            // Get combobox selection (in handler)
            string value = ((KeyValuePair<string, string>)CategoryComboBox.SelectedItem).Value;
        }

        private void OkButtonDialog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CategoryComboBox.Text))
            {
                string message = "Please Choose Your Category";
                MessageBox.Show(message, " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cat = CategoryComboBox.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
