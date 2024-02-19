using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client_Application
{
    public partial class ClientForm
    {
        private void RequestHandeller(NetworkStream networkStream, Request request)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);
                string jsonRequest = JsonSerializer.Serialize<Request>(request);
                List<string> jsonParams = new List<string>();
                binaryWriter.Write(jsonRequest);
                binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }

        }
        private void RequestHandeller<T1>(NetworkStream networkStream, Request request, T1 param1)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);
                string jsonRequest = JsonSerializer.Serialize<Request>(request);
                List<string> jsonParams = new List<string>();
                jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                binaryWriter.Write(jsonRequest);
                binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }

        }
        private void RequestHandeller<T1, T2>(NetworkStream networkStream, Request request, T1 param1, T2 param2)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);
                string jsonRequest = JsonSerializer.Serialize<Request>(request);
                List<string> jsonParams = new List<string>();
                jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                jsonParams.Add(JsonSerializer.Serialize<T2>(param2));
                binaryWriter.Write(jsonRequest);
                binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }

        }
        private void RequestHandeller<T1, T2, T3>(NetworkStream networkStream, Request request, T1 param1, T2 param2, T3 param3)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);
                string jsonRequest = JsonSerializer.Serialize<Request>(request);
                List<string> jsonParams = new List<string>();
                jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                jsonParams.Add(JsonSerializer.Serialize<T2>(param2));
                jsonParams.Add(JsonSerializer.Serialize<T3>(param3));
                binaryWriter.Write(jsonRequest);
                binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }


        }
        private void RequestHandeller<T1, T2, T3, T4>(NetworkStream networkStream, Request request, T1 param1, T2 param2, T3 param3, T4 param4)
        {
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);
                string jsonRequest = JsonSerializer.Serialize<Request>(request);
                List<string> jsonParams = new List<string>();
                jsonParams.Add(JsonSerializer.Serialize<T1>(param1));
                jsonParams.Add(JsonSerializer.Serialize<T2>(param2));
                jsonParams.Add(JsonSerializer.Serialize<T3>(param3));
                jsonParams.Add(JsonSerializer.Serialize<T4>(param4));
                binaryWriter.Write(jsonRequest);
                binaryWriter.Write(JsonSerializer.Serialize<List<string>>(jsonParams));
            }
            catch (Exception ex) { MessageBox.Show("From RequestHandeller " + ex.Message); }


        }
        private void ResponseHandeller(NetworkStream networkStream)
        {
            //try
            //{
                BinaryReader binaryReader = new BinaryReader(networkStream);
                string strReq = binaryReader.ReadString();
                string strPara = binaryReader.ReadString();
                Request request = JsonSerializer.Deserialize<Request>(strReq);
                List<string> para = JsonSerializer.Deserialize<List<string>>(strPara);
                Distributer(request, para!);
            //}
            //catch (Exception ex) { MessageBox.Show("From Client ResponseHandeller " + ex.Message); }
        }

        private void Distributer(Request req, List<string> para)
        {
            switch (req)
            {
                case Request.ServerToClientLogin: SetPlayerData(para); break;
                default: MessageBox.Show($"{req}"); break;
            }
        }
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
