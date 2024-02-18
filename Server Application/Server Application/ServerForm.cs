namespace Server_Application
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            ServerController.StartServer(btnStart);
        }
    }
}
