using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    internal class Logger
    {
        private static readonly object lockObject = new object();
        static List<string> GeneralLogs;
        static List<string> ServerErrorLogs;
        static List<string> ClientErrorLogs;
        static List<string> GameResultLogs;
        static List<string> AllLogs;
        static Logger()
        {
            GeneralLogs = new List<string>();
            ServerErrorLogs = new List<string>();
            ClientErrorLogs = new List<string>();
            GameResultLogs = new List<string>();
            AllLogs = new List<string>();
        }
        public static void Write(Log logCategory, string message)
        {
            DateTime currentDateTime = DateTime.Now;

            string fullMessage = $"{logCategory} at {currentDateTime} => {message}. ";
            lock (lockObject)
            {
                switch (logCategory)
                {
                    case Log.General: GeneralLogs.Add(fullMessage); AllLogs.Add(fullMessage); break;
                    case Log.ServerError: ServerErrorLogs.Add(fullMessage); AllLogs.Add(fullMessage); break;
                    case Log.ClientError: ClientErrorLogs.Add(fullMessage); AllLogs.Add(fullMessage); break;
                    case Log.GameResult: GameResultLogs.Add(fullMessage); AllLogs.Add(fullMessage); break;
                }
            }           
        }
        public static List<string> Read(Log logCategory)
        {
            List<string> logs;
            lock (lockObject)
            {
                switch (logCategory)
                {
                    case Log.General: logs= GeneralLogs; break;
                    case Log.ServerError: logs = ServerErrorLogs; break;
                    case Log.ClientError: logs = ClientErrorLogs; break;
                    case Log.GameResult: logs = GameResultLogs; break;
                    case Log.All: logs = AllLogs; break;
                    default: logs = AllLogs; break;
                }
            }
            return logs;
        }
        public static bool ExportLogs(Log logCategory)
        {
            bool retval = false;
            try
            {
                lock (lockObject)
                {
                    List<string> logs = new List<string>();
                    switch (logCategory)
                    {
                        case Log.General: logs.AddRange(GeneralLogs); ; break;
                        case Log.ServerError: logs.AddRange(ServerErrorLogs); break;
                        case Log.ClientError: logs.AddRange(ClientErrorLogs); break;
                        case Log.GameResult: logs.AddRange(GameResultLogs); break;
                        case Log.All:
                            logs.AddRange(GeneralLogs); logs.AddRange(ServerErrorLogs);
                            logs.AddRange(ClientErrorLogs); logs.AddRange(GameResultLogs); break;

                        default: logs = GeneralLogs; break;
                    }
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            retval = true;
                            string filePath = saveFileDialog.FileName;
                            DateTime currentDateTime = DateTime.Now;
                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                writer.WriteLine($"*** Hello,That's {logCategory} Logs File ***");
                                writer.WriteLine($"*** Exported At {currentDateTime} by Server admin ***");
                                writer.WriteLine("");
                                if (logs.Count > 0)
                                {
                                    for (int i = 0; i < logs.Count; i++)
                                    {
                                        writer.WriteLine($"{i + 1}- {logs[i]}");
                                    }
                                }
                                writer.WriteLine("");
                                writer.WriteLine("************ End Of File ************");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { retval = false; Write(Log.ServerError,ex.Message); }
            return retval;
           
        }

    }
}
