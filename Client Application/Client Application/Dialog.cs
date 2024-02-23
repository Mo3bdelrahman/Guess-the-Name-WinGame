using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Client_Application
{
    public partial class Dialog : Form
    {
        public string cat;
        private string[] categories;
        public Dialog(string[] categories)
        {
            InitializeComponent();
            this.categories = categories;
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> categoryDictionary = new Dictionary<string, string>();

            for(int i = 0; i < categories.Length; i++) 
            {
                categoryDictionary.Add($"{i}", categories[i]);
            }

            CategoryComboBox.DataSource = new BindingSource(categoryDictionary, null);
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
