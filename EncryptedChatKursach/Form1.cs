using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace EncryptedChatKursach
{
    public partial class Form1 : Form
    {

        private bool connected = false;
        private Thread client = null;
        private struct MyClient
        {
            public TcpClient client;
            public NetworkStream stream;
            public byte[] buffer;
            public StringBuilder data;
            public EventWaitHandle handle;
        };
        private struct file
        {
            public byte[] value;
            public string extension;
        }
        public int selectedfile = -1;
        private MyClient obj;
        private Task send = null;
        private bool exit = false;
        public bool nickflag = false;
        private string temps;
        private ConcurrentDictionary<long, file> files = new ConcurrentDictionary<long, file>();
        public long filescount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LogWrite(string msg = null)
        {
            if (!exit)
            {
                logTextBox.Invoke((MethodInvoker)delegate
                {
                    if (msg == null)
                    {
                        logTextBox.Clear();
                    }
                    else
                    {
                        if (logTextBox.Text.Length > 0)
                        {
                            logTextBox.AppendText(Environment.NewLine);
                        }
                        logTextBox.AppendText(DateTime.Now.ToString("HH:mm") + " " + msg);
                    }
                });
            }
        }

        private void Connected(bool status)
        {
            if (!exit)
            {
                connectButton.Invoke((MethodInvoker)delegate
                {
                    connected = status;
                    if (status)
                    {
                        connectButton.Text = "Disconnect";
                        LogWrite($"[/ You are now connected as {nickTextbox.Text} /]");
                        TaskSend(nickTextbox.Text);
                        
                    }
                    else
                    {
                        connectButton.Text = "Connect";
                        LogWrite("[/ You are now disconnected /]");
                    }
                });
            }
        }

        private void Read(IAsyncResult result)
        {
            int bytes = 0;
            if (obj.client.Connected)
            {
                try
                {
                    bytes = obj.stream.EndRead(result);
                }
                catch (Exception ex)
                {
                    LogWrite(string.Format("[/ {0} /]", ex.Message));
                }
            }
            if (bytes > 0)
            {
                obj.data.AppendFormat("{0}", Encoding.UTF8.GetString(obj.buffer, 0, bytes));
                try
                {
                    if (obj.stream.DataAvailable)
                    {
                        obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(Read), obj);
                    }
                    else
                    {
                        string tempostring = obj.data.ToString();
                        bool kek = tempostring.Contains("File");
                        if (obj.data.ToString().Contains("connected") || obj.data.ToString().Contains("Client"))
                        {
                            LogWrite(obj.data.ToString());
                        }
                        
                        else if (kek)
                        {
                            string fullb64message = obj.data.ToString();
                            int extlenght = fullb64message.IndexOf("File");
                            string extension = fullb64message.Substring(0, extlenght);
                            string temp = fullb64message.Remove(0, extension.Length + 4);
                            byte[] utf8bytes = Encoding.UTF8.GetBytes(temp);
                            string utf8stringwhy = Encoding.UTF8.GetString(utf8bytes);
                            string decodedmsg = Encryption.Decrypt(utf8stringwhy, passwordTextbox.Text);
                            byte[] check = Convert.FromBase64String(decodedmsg);

                            file filee = new file();
                            filee.value = check;
                            filee.extension = extension;
                            files.TryAdd(filescount,filee);
                            this.filesList.BeginInvoke((MethodInvoker)(() => this.filesList.Items.Add($"{extension} File")));
                            LogWrite("[System]: new file arrived, double click on it to perform local save.");
                            
                        }
                        else
                        {
                            if(obj.data.ToString().Contains("Server"))
                            {
                               
                                LogWrite(obj.data.ToString().Split(':')[0] + ": " + obj.data.ToString().Split(':')[1]);
                            }
                            else 
                            {
                                if (aesRadio.Checked)
                                {
                                    
                                    string[] parts = obj.data.ToString().Split(':');
                                    byte[] buffer;
                                    buffer = Encoding.UTF8.GetBytes(parts[1]);
                                    string keko = Encoding.UTF8.GetString(buffer);
                                    LogWrite(parts[0] + ": " + Encryption.Decrypt(keko, passwordTextbox.Text));
                                }
                                
                            }
                        }
                        obj.data.Clear();
                        obj.handle.Set();
                    }
                }
                catch (Exception ex)
                {
                    obj.data.Clear();
                    LogWrite(string.Format("[/ {0} /]", ex.Message));
                    obj.handle.Set();
                }
            }
            else
            {
                obj.client.Close();
                obj.handle.Set();
            }
        }

        private void Connection(IPAddress localaddr, int port)
        {
            try
            {
                obj = new MyClient();
                obj.client = new TcpClient();
                obj.client.Connect(localaddr, port);
                obj.stream = obj.client.GetStream();
                obj.buffer = new byte[obj.client.ReceiveBufferSize];
                obj.data = new StringBuilder();
                obj.handle = new EventWaitHandle(false, EventResetMode.AutoReset);
                Connected(true);
                while (obj.client.Connected)
                {
                    try
                    {
                        obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(Read), null);
                        obj.handle.WaitOne();
                    }
                    catch (Exception ex)
                    {
                        LogWrite(string.Format("[/ {0} /]", ex.Message));
                    }
                }
                obj.client.Close();
                Connected(false);
            }
            catch (Exception ex)
            {
                LogWrite(string.Format("[/ {0} /]", ex.Message));
            }
        }


        private void Write(IAsyncResult result)
        {
            if (obj.client.Connected)
            {
                try
                {
                    obj.stream.EndWrite(result);
                }
                catch (Exception ex)
                {
                    LogWrite(string.Format("[/ {0} /]", ex.Message));
                }
            }
        }

        private void Send(string msg,bool flag)
        {
            byte[] buffer;
            
            buffer = Encoding.UTF8.GetBytes(msg);
            
            if (obj.client.Connected)
            {
                try
                {
                    obj.stream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(Write), null);
                }
                catch (Exception ex)
                {
                    LogWrite(string.Format("[/ {0} /]", ex.Message));
                }
            }
        }
        

        private void TaskSend(string msg,bool file)
        {
            if (send == null || send.IsCompleted)
            {
                send = Task.Factory.StartNew(() => Send(msg,file));
            }
            else
            {
                send.ContinueWith(antecendent => Send(msg,file));
            }
        }

        private void Send(string msg)
        {
            byte[] buffer;
            if (nickflag == false)
            {
                temps = nickTextbox.Text;
                nickflag = true;
            }
            else
            {
                if (aesRadio.Checked)
                {
                    temps = Encryption.Encrypt(msg, passwordTextbox.Text);
                }

            }

            buffer = Encoding.UTF8.GetBytes(temps);

            if (obj.client.Connected)
            {
                try
                {
                    obj.stream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(Write), null);
                }
                catch (Exception ex)
                {
                    LogWrite(string.Format("[/ {0} /]", ex.Message));
                }
            }
        }


        private void TaskSend(string msg)
        {
            if (send == null || send.IsCompleted)
            {
                send = Task.Factory.StartNew(() => Send(msg));
            }
            else
            {
                send.ContinueWith(antecendent => Send(msg));
            }
        }


        private void sendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (sendTextBox.Text.Length > 0)
                {
                    string msg = sendTextBox.Text;
                    sendTextBox.Clear();
                    LogWrite("You: " + msg);
                    if (connected)
                    {
                        TaskSend(msg);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connected)
            {
                exit = true;
                obj.client.Close();
            }
        }

        private void sendTextBox_Click(object sender, EventArgs e)
        {
            sendTextBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            LogWrite();
        }

        private void nickTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            nickTextbox.Text = "";
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                obj.client.Close();
            }
            else if (client == null || !client.IsAlive)
            {
                bool localaddrResult = IPAddress.TryParse(addressTextbox.Text, out IPAddress localaddr);
                if (!localaddrResult)
                {
                    LogWrite("Address is not valid");
                }
                bool portResult = int.TryParse(portTextbox.Text, out int port);
                if (!portResult)
                {
                    LogWrite("Port is not valid");
                }
                else if (port < 0 || port > 65535)
                {
                    portResult = false;
                    LogWrite("Port is out of range 0<=port<=65535");
                }
                if (localaddrResult && portResult)
                {
                    client = new Thread(() => Connection(localaddr, port))
                    {
                        IsBackground = true
                    };
                    client.Start();
                }
            }
        }

       

        

        private void sendFile_Click(object sender, EventArgs e)
        {
            if (fileNameTextbox.Text != "")
            {
                bool flag = true;
                byte[] msg = File.ReadAllBytes(fileNameTextbox.Text);
                string ext = Path.GetExtension(fileNameTextbox.Text);
                string tempmessage = Convert.ToBase64String(msg);
                string encodedpart = Encryption.Encrypt(tempmessage, passwordTextbox.Text);
                string encodedmessage = ext + "File" + encodedpart;
                TaskSend(encodedmessage,flag);
                
            }
            else
            {
                MessageBox.Show("Choose file","Error");
            }
            
        }


        private void sendMsg_Click(object sender, EventArgs e)
        {
            if (sendTextBox.Text.Length > 0)
            {
                string msg = sendTextBox.Text;
                sendTextBox.Clear();
                LogWrite("You: " + msg);
                if (connected)
                {
                    TaskSend(msg);
                }
            }
        }

        private void chooseFilebtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dg = new OpenFileDialog())
            {
                var result = dg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fileNameTextbox.Text = dg.FileName;
                }
                else
                {
                    fileNameTextbox.Text = "";
                }
            }
        }

        private void filesList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (filesList.SelectedIndex != -1)
            {
                selectedfile = filesList.SelectedIndex;
            }
            else
            {
                selectedfile = -1;
            }
        }

        private void filesList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (selectedfile != -1)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = $"(*{files[selectedfile].extension})|*{files[selectedfile].extension}";
                        DialogResult sfdresult = sfd.ShowDialog();
                        if (sfdresult == DialogResult.OK)
                        {
                            if (sfd.FileName != "" || sfd.FileName != null)
                            {
                                try
                                {
                                    File.WriteAllBytes(sfd.FileName + files[selectedfile].extension, files[selectedfile].value);
                                }
                                catch (Exception exx)
                                {
                                    LogWrite(String.Format("[/ {0} /]", exx.Message));
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("No files to save found", "Error");
            }

        }

        private void clearFilesList_Click(object sender, EventArgs e)
        {
            files.Clear();
            filesList.Items.Clear();
        }
    }
}
