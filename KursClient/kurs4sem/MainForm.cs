﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace kurs4sem
{
    public partial class MainForm : Form
    {
        private bool connected = false;
        private Thread client = null;
        private int mailindex = 0;

        private struct Mail
        {
            public int id;
            public string from;
            public string msg;
            public string who;
            public string theme;
        }

        private struct MyClient
        {
            public int id;
            public string key;
            public string username;
            public TcpClient client;
            public NetworkStream stream;
            public byte[] buffer;
            public StringBuilder data;
            public EventWaitHandle handle;
        };
        private ConcurrentDictionary<int, Mail> mails = new ConcurrentDictionary<int, Mail>();

        private MyClient obj;
        private Task send = null;
        private bool exit = false;
        public MainForm()
        {
            InitializeComponent();
            label2.Text = LoginForm.username + "@bobkin.ru";
            ConnectToServer();
        }


        private string ErrorMsg(string msg)
        {
            return string.Format("ERROR: {0}", msg);
        }

        private string SystemMsg(string msg)
        {
            return string.Format("SYSTEM: {0}", msg);
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
                   // Log(ErrorMsg(ex.Message));
                }
            }
            if (bytes > 0)
            {
                obj.data.AppendFormat("{0}", Encoding.UTF8.GetString(obj.buffer, 0, bytes));
                try
                {
                    if (obj.stream.DataAvailable)
                    {
                        obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(Read), null);
                    }
                    else
                    {
                        // Log(obj.data.ToString());

                        JavaScriptSerializer json = new JavaScriptSerializer(); // feel free to use JSON serializer
                        Mail data = json.Deserialize<Mail>(obj.data.ToString());
                        AddToGrid(mailindex++, data.theme, data.from,data.msg);

                        obj.data.Clear();
                        obj.handle.Set();
                    }
                }
                catch (Exception ex)
                {
                    obj.data.Clear();
                   // Log(ErrorMsg(ex.Message));
                    obj.handle.Set();
                }
            }
            else
            {
                obj.client.Close();
                obj.handle.Set();
            }
        }

        private void ReadAuth(IAsyncResult result)
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
                  //  Log(ErrorMsg(ex.Message));
                }
            }
            if (bytes > 0)
            {
                obj.data.AppendFormat("{0}", Encoding.UTF8.GetString(obj.buffer, 0, bytes));
                try
                {
                    if (obj.stream.DataAvailable)
                    {
                        obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(ReadAuth), null);
                    }
                    else
                    {
                        JavaScriptSerializer json = new JavaScriptSerializer(); // feel free to use JSON serializer
                        Dictionary<string, string> data = json.Deserialize<Dictionary<string, string>>(obj.data.ToString());
                        if (data.ContainsKey("status") && data["status"].Equals("authorized"))
                        {
                            Connected(true);
                        }
                        obj.data.Clear();
                        obj.handle.Set();
                    }
                }
                catch (Exception ex)
                {
                    obj.data.Clear();
                  //  Log(ErrorMsg(ex.Message));
                    obj.handle.Set();
                }
            }
            else
            {
                obj.client.Close();
                obj.handle.Set();
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
                   // Log(ErrorMsg(ex.Message));
                }
            }
        }

        private void BeginWrite(string msg)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            if (obj.client.Connected)
            {
                try
                {
                    obj.stream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(Write), null);
                }
                catch (Exception ex)
                {
                   // Log(ErrorMsg(ex.Message));
                }
            }
        }

        private void Send(string msg)
        {
            if (send == null || send.IsCompleted)
            {
                send = Task.Factory.StartNew(() => BeginWrite(msg));
            }
            else
            {
                send.ContinueWith(antecendent => BeginWrite(msg));
            }
        }

        private bool Authorize()
        {
            bool success = false;
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("username", obj.username);
            data.Add("key", obj.key);
            JavaScriptSerializer json = new JavaScriptSerializer(); // feel free to use JSON serializer
            Send(json.Serialize(data));
            while (obj.client.Connected)
            {
                //AddToGrid(obj.id, obj.username.ToString());
                try
                {
                    obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(ReadAuth), null);
                    obj.handle.WaitOne();
                    if (connected)
                    {
                        success = true;
                        break;
                    }
                }
                catch (Exception ex)
                {
                  //  Log(ErrorMsg(ex.Message));
                }
            }
            if (!connected)
            {
               // Log(SystemMsg("Unauthorized"));
            }
            return success;
        }

        private void Connection(IPAddress ip, int port, string username)
        {
            try
            {
                obj = new MyClient();
                obj.username = username;
                obj.client = new TcpClient();
                obj.client.Connect(ip, port);
                obj.stream = obj.client.GetStream();
                obj.buffer = new byte[obj.client.ReceiveBufferSize];
                obj.data = new StringBuilder();
                obj.handle = new EventWaitHandle(false, EventResetMode.AutoReset);
                if (Authorize())
                {
                    while (obj.client.Connected)
                    {
                        try
                        {
                            obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(Read), null);
                            obj.handle.WaitOne();
                        }
                        catch (Exception ex)
                        {
                           // Log(ErrorMsg(ex.Message));
                        }
                    }
                    obj.client.Close();
                }
            }
            catch (Exception ex)
            {
                //Log(ErrorMsg(ex.Message));
            }
        }

        [Obsolete]
        private void ConnectToServer() // подключение к серверу
        {
            if (connected)
            {
                obj.client.Close();
            }
            else if (client == null || !client.IsAlive)
            {
                string address = "127.0.0.1";
                int port = 9000;
                string username = LoginForm.username;
                IPAddress ip = null;
                ip = Dns.Resolve(address).AddressList[0];

                client = new Thread(() => Connection(ip, port, username))
                {
                    IsBackground = true
                };
                client.Start();
            }
        }


        private void exitbutton_Click(object sender, EventArgs e)
        {
            exit = true;
            if (connected)
            {
                obj.client.Close();
            }
            Environment.Exit(0);

        }



        private void Connected(bool status)
        {
            if (!exit)
            {
                connected = status;
            }
        }

        private void SendMailBtn_Click(object sender, EventArgs e)
        {
                    if (MessageTextBox.Text.Length > 0 && WhotextBox.Text.Length > 0 && ThemetextBox.Text.Length > 0)
                    {
                        string msg = MessageTextBox.Text;
                        string who = WhotextBox.Text;
                        string theme = ThemetextBox.Text;
                        
                        MessageTextBox.Clear();
                        WhotextBox.Clear();
                        ThemetextBox.Clear();
                        
                      //  Log(string.Format("{0} (You): {1}", obj.username, msg));
                        if (connected)
                        {
                            Mail mail = new Mail();
                            mail.msg = msg;
                            mail.who = who;
                            mail.theme = theme;
                            JavaScriptSerializer json = new JavaScriptSerializer(); // feel free to use JSON serializer
                            Send(json.Serialize(mail));
                        }
                    }
        }


        ///////// grid 
        ///

        private void AddToGrid(int id, string theme, string from, string msg)
        {
            if (!exit)
            {
                mailDataGridView.Invoke((MethodInvoker)delegate
                {
                    Mail mail = new Mail();
                    mail.id = id;
                    mail.from = from;
                    mail.theme = theme;
                    mail.msg = msg;
                    mails.TryAdd(mail.id, mail);
                    string[] row = new string[] { id.ToString(), theme, from + "@bobkin.ru" };
                    mailDataGridView.Rows.Add(row);
                    totalLabel.Text = string.Format("Всего писем: {0}", mailDataGridView.Rows.Count);
                });
            }
        }

        private void RemoveFromGrid(int id)
        {

                mailDataGridView.Invoke((MethodInvoker)delegate
                {
                    foreach (DataGridViewRow row in mailDataGridView.Rows)
                    {
                        if (row.Cells["identifier"].Value.ToString() == id.ToString())
                        {
                            mailDataGridView.Rows.RemoveAt(row.Index);
                            break;
                        }
                    }
                    mails.TryRemove(id, out Mail tmp);
                    totalLabel.Text = string.Format("Всего писем: {0}", mailDataGridView.Rows.Count);
                });
        }


        private void mailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == mailDataGridView.Columns["disconnect"].Index)
            {
                int.TryParse(mailDataGridView.Rows[e.RowIndex].Cells["identifier"].Value.ToString(), out int id);
                mails.TryGetValue(id, out Mail obj1);
                RemoveFromGrid(obj1.id);
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == mailDataGridView.Columns["ReadButton"].Index)
                {
                    int.TryParse(mailDataGridView.Rows[e.RowIndex].Cells["identifier"].Value.ToString(), out int id);
                    mails.TryGetValue(id, out Mail obj1);
                    MailDetail form = new MailDetail(obj1.from,obj1.theme,obj1.msg);
                    form.ShowDialog();
            }
        }
    }
}
