﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        private bool active = false;
        private Thread listener = null;
        private long id = 0;
        private struct Mail
        {
            public string from;
            public string msg;
            public string who;
            public string theme;
        }
        private struct CursClient
        {
            public long id;
            public StringBuilder username;
            public TcpClient client;
            public NetworkStream stream;
            public byte[] buffer;
            public StringBuilder data;
            public StringBuilder who;
            public StringBuilder theme;
            public EventWaitHandle handle;
        };
        private ConcurrentDictionary<long, CursClient> clients = new ConcurrentDictionary<long, CursClient>();
        private Task send = null;
        private Thread disconnect = null;
        private bool exit = false;

        public Server()
        {
            InitializeComponent();
        }

        private void Log(string msg = "")
        {
            if (!exit)
            {
                logTextBox.Invoke((MethodInvoker)delegate
                {
                    if (msg.Length > 0)
                    {
                        logTextBox.AppendText(string.Format("[ {0} ] {1}{2}", DateTime.Now.ToString("HH:mm"), msg, Environment.NewLine));
                    }
                    else
                    {
                        logTextBox.Clear();
                    }
                });
            }
        }

        private string ErrorMsg(string msg)
        {
            return string.Format("Ошибка: {0}", msg);
        }
        private string SystemMsg(string msg)
        {
            return string.Format("Система: {0}", msg);
        }

        private void Active(bool status)
        {
            if (!exit)
            {
                startButton.Invoke((MethodInvoker)delegate
                {
                    active = status;
                    if (status)
                    {
                        startButton.Text = "Остановить";
                        Log(SystemMsg("Сервер включен"));
                    }
                    else
                    {
                        startButton.Text = "Включить";
                        Log(SystemMsg("Сервер остановлен"));
                    }
                });
            }
        }
        private void AddToGrid(long id, string name)
        {
            if (!exit)
            {
                clientsDataGridView.Invoke((MethodInvoker)delegate
                {
                    string[] row = new string[] { id.ToString(), name + "@bobkin.ru" };
                    clientsDataGridView.Rows.Add(row);
                    totalLabel.Text = string.Format("Пользователей в сети: {0}", clientsDataGridView.Rows.Count);
                });
            }
        }
        private void RemoveFromGrid(long id)
        {
            if (!exit)
            {
                clientsDataGridView.Invoke((MethodInvoker)delegate
                {
                    foreach (DataGridViewRow row in clientsDataGridView.Rows)
                    {
                        if (row.Cells["identifier"].Value.ToString() == id.ToString())
                        {
                            clientsDataGridView.Rows.RemoveAt(row.Index);
                            break;
                        }
                    }
                    totalLabel.Text = string.Format("Пользователей в сети: {0}", clientsDataGridView.Rows.Count);
                });
            }
        }
        private void Read(IAsyncResult result)
        {
            CursClient fromwho = (CursClient)result.AsyncState;
            int bytes = 0;
            if (fromwho.client.Connected)
            {
                try
                {
                    bytes = fromwho.stream.EndRead(result);
                }
                catch (Exception ex)
                {
                    Log(ErrorMsg(ex.Message));
                }
            }
            if (bytes > 0)
            {
                fromwho.data.AppendFormat("{0}", Encoding.UTF8.GetString(fromwho.buffer, 0, bytes));
                try
                {
                    if (fromwho.stream.DataAvailable)
                    {
                        fromwho.stream.BeginRead(fromwho.buffer, 0, fromwho.buffer.Length, new AsyncCallback(Read), fromwho);
                    }
                    else
                    {
                        JavaScriptSerializer json = new JavaScriptSerializer();
                        Mail data = json.Deserialize<Mail>(fromwho.data.ToString());
                        bool key = false;

                        foreach (KeyValuePair<long, CursClient> obj2 in clients)
                        {
                            if (obj2.Value.username.ToString() == data.who)
                            {
                                data.from = fromwho.username.ToString();
                                JavaScriptSerializer newjson = new JavaScriptSerializer(); 
                                Send(newjson.Serialize(data), obj2.Value);
                                string logstr = string.Format("Пользователь *{0}* послал письмо пользователю *{1}* на тему *{2}*: *{3}*", fromwho.username, data.who, data.theme, data.msg);
                                Log(logstr);
                                fromwho.data.Clear();
                                fromwho.handle.Set();
                                key = true;
                                break;
                            }
                        }
                        if (key == false) {
                            data.from = "NULL";
                            JavaScriptSerializer newjson = new JavaScriptSerializer();
                            Send(newjson.Serialize(data), fromwho);
                            string logstr = string.Format("Пользователь *{0}* собирался послать письмо пользователю *{1}* на тему *{2}*: *{3}*, но такого пользователя в сети не нашлось", fromwho.username, data.who, data.theme, data.msg);
                            Log(logstr);
                            fromwho.data.Clear();
                            fromwho.handle.Set();
                        }

                    }
                }
                catch (Exception ex)
                {
                    fromwho.data.Clear();
                    Log(ErrorMsg(ex.Message));
                    fromwho.handle.Set();
                }
            }
            else
            {
                fromwho.client.Close();
                fromwho.handle.Set();
            }
        }
        private void ReadAuth(IAsyncResult result)
        {
            CursClient obj = (CursClient)result.AsyncState;
            int bytes = 0;
            if (obj.client.Connected)
            {
                try
                {
                    bytes = obj.stream.EndRead(result);
                }
                catch (Exception ex)
                {
                    Log(ErrorMsg(ex.Message));
                }
            }
            if (bytes > 0)
            {
                obj.data.AppendFormat("{0}", Encoding.UTF8.GetString(obj.buffer, 0, bytes));
                try
                {
                    if (obj.stream.DataAvailable)
                    {
                        obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(ReadAuth), obj);
                    }
                    else
                    {
                        JavaScriptSerializer json = new JavaScriptSerializer(); // feel free to use JSON serializer
                        Dictionary<string, string> data = json.Deserialize<Dictionary<string, string>>(obj.data.ToString());
                        obj.username.Append(data["username"].Length > 200 ? data["username"].Substring(0, 200) : data["username"]);
                        Send("{\"status\": \"authorized\"}", obj);
                        obj.data.Clear();
                        obj.handle.Set();
                    }
                }
                catch (Exception ex)
                {
                    obj.data.Clear();
                    Log(ErrorMsg(ex.Message));
                    obj.handle.Set();
                }
            }
            else
            {
                obj.client.Close();
                obj.handle.Set();
            }
        }
        private bool Authorize(CursClient obj)
        {
            bool success = false;
            while (obj.client.Connected)
            {
                try
                {
                    obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(ReadAuth), obj);
                    obj.handle.WaitOne();
                    if (obj.username.Length > 0)
                    {
                        success = true;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Log(ErrorMsg(ex.Message));
                }
            }
            return success;
        }
        private void Connection(CursClient obj)
        {
            if (Authorize(obj))
            {
                clients.TryAdd(obj.id, obj);
                AddToGrid(obj.id, obj.username.ToString());
                string msg = string.Format("{0} зашел в сеть", obj.username);
                Log(SystemMsg(msg));
                while (obj.client.Connected)
                {
                    try
                    {
                        obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(Read), obj);
                        obj.handle.WaitOne();
                    }
                    catch (Exception ex)
                    {
                        Log(ErrorMsg(ex.Message));
                    }
                }
                obj.client.Close();
                clients.TryRemove(obj.id, out CursClient tmp);
                RemoveFromGrid(tmp.id);
                msg = string.Format("{0} вышел из сети", tmp.username);
                Log(SystemMsg(msg));
            }
        }
        private void Listener(IPAddress ip, int port)
        {
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(ip, port);
                listener.Start();
                Active(true);
                while (active)
                {
                    if (listener.Pending())
                    {
                        try
                        {
                            CursClient obj = new CursClient();
                            obj.id = id;
                            obj.username = new StringBuilder();
                            obj.client = listener.AcceptTcpClient();
                            obj.stream = obj.client.GetStream();
                            obj.buffer = new byte[obj.client.ReceiveBufferSize];
                            obj.data = new StringBuilder();
                            obj.handle = new EventWaitHandle(false, EventResetMode.AutoReset);
                            Thread th = new Thread(() => Connection(obj))
                            {
                                IsBackground = true
                            };
                            th.Start();
                            id++;
                        }
                        catch (Exception ex)
                        {
                            Log(ErrorMsg(ex.Message));
                        }
                    }
                    else
                    {
                        Thread.Sleep(500);
                    }
                }
                Active(false);
            }
            catch (Exception ex)
            {
                Log(ErrorMsg(ex.Message));
            }
            finally
            {
                if (listener != null)
                {
                    listener.Server.Close();
                }
            }
        }
        private void Write(IAsyncResult result)
        {
            CursClient obj = (CursClient)result.AsyncState;
            if (obj.client.Connected)
            {
                try
                {
                    obj.stream.EndWrite(result);
                }
                catch (Exception ex)
                {
                    Log(ErrorMsg(ex.Message));
                }
            }
        }
        private void BeginWrite(string msg, CursClient obj) // отправление письма клиенту
        {
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            if (obj.client.Connected)
            {
                try
                {
                    obj.stream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(Write), obj);
                }
                catch (Exception ex)
                {
                    Log(ErrorMsg(ex.Message));
                }
            }
        }
        private void Send(string msg, CursClient obj)
        {
            if (send == null || send.IsCompleted)
            {
                send = Task.Factory.StartNew(() => BeginWrite(msg, obj));
            }
            else
            {
                send.ContinueWith(antecendent => BeginWrite(msg, obj));
            }
        }
        private void Disconnect()
        {
            if (disconnect == null || !disconnect.IsAlive)
            {
                disconnect = new Thread(() =>
                {
                    if (id >= 0)
                    {
                        clients.TryGetValue(id, out CursClient obj);
                        if (obj.client!=null)
                            obj.client.Close();
                        RemoveFromGrid(obj.id);
                    }
                    else
                    {
                        foreach (KeyValuePair<long, CursClient> obj in clients)
                        {
                            obj.Value.client.Close();
                            RemoveFromGrid(obj.Value.id);
                        }
                    }
                })
                {
                    IsBackground = true
                };
                disconnect.Start();
            }
        }
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            exit = true;
            active = false;
            Disconnect();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Log();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (active)
            {
                active = false;
            }
            else if (listener == null || !listener.IsAlive)
            {
                string address = "127.0.0.1";
                int port = 9000;
                bool error = false;
                IPAddress ip = null;
                ip = Dns.Resolve(address).AddressList[0];

                if (!error)
                {
                    listener = new Thread(() => Listener(ip, port))
                    {
                        IsBackground = true
                    };
                    listener.Start();
                }
            }
        }
    }
}
