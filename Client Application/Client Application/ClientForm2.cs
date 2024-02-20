using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Application
{
    internal partial class ClientForm
    {

        //request handlers
        private void SetPlayerData(List<string> para)
        {
            try
            {
                if (para[0].GetOriginalData<bool>())
                {
                    player = para[1].GetOriginalData<Player>();
                    Invoke(() => {
                        panelList[++index].BringToFront();
                        panelList[index].Visible = true;
                        MessageBox.Show($"{player.Name}, {player.State}");
                    });

                }
                else
                {
                    MessageBox.Show("Couldn't connect To the Server, Please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("from Method " + ex.Message);
            }

        }
    }
}
