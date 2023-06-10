using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kurs4sem
{
    public partial class MainForm : Form
    {
        private bool connected = true;
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
        public struct CursClient
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

        private CursClient obj;
        private Task send = null;
        private bool exit = false;
        public MainForm(CursClient obj1, IPAddress i, int p, string un)
        {
            InitializeComponent();
            label2.Text = LoginForm.username + "@bobkin.ru";
            Text+=" пользователя " + label2.Text;
            obj = obj1;
            client = new Thread(() => Connection(i, p, un))
            {
                IsBackground = true
            };
            client.Start();
        }


        private string ErrorMsg(string msg)
        {
            return string.Format("Ошибка: {0}", msg);
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
                    alertlabel.Invoke((MethodInvoker)delegate
                    {
                        alertlabel.Text = ex.Message;
                    });
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
                        JavaScriptSerializer json = new JavaScriptSerializer();
                        Mail data = json.Deserialize<Mail>(obj.data.ToString());

                        if (data.from == "NULL")
                        {
                            alertlabel.Invoke((MethodInvoker)delegate
                            {
                                alertlabel.Text = "Ошибка: Пользователя с таким именем в сети не нашлось";
                            });
                        }

                        else
                            AddToGrid(mailindex++, data.theme, data.from,data.msg);

                        obj.data.Clear();
                        obj.handle.Set();
                    }
                }
                catch (Exception ex)
                {
                    obj.data.Clear();
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
                    alertlabel.Invoke((MethodInvoker)delegate
                    {
                        alertlabel.Invoke((MethodInvoker)delegate
                        {
                            alertlabel.Text = ex.Message;
                        });
                    });
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
                        JavaScriptSerializer json = new JavaScriptSerializer();
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
                    alertlabel.Invoke((MethodInvoker)delegate
                    {
                        alertlabel.Text = ex.Message;
                    });
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
                    alertlabel.Invoke((MethodInvoker)delegate
                    {
                        alertlabel.Text = ex.Message;
                    });
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
                    alertlabel.Invoke((MethodInvoker)delegate
                    {
                        alertlabel.Text = ex.Message;
                    });
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
                    alertlabel.Invoke((MethodInvoker)delegate
                    {
                        alertlabel.Text = ex.Message;
                    });
                }
            }
            if (!connected)
            {
                alertlabel.Text = "Не авторизован";
            }
            return success;
        }


        private void Connection(IPAddress ip, int port, string username)
        {
            try
            {
                obj = new CursClient();
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
                            alertlabel.Text = ErrorMsg(ex.Message);
                        }
                    }
                    obj.client.Close();
                }
            }
            catch (Exception ex)
            {
                alertlabel.Invoke((MethodInvoker)delegate
                {
                    alertlabel.Text = ex.Message;
                });
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
                    if (WhotextBox.Text.Length > 0)
            {
                alertlabel.Text = "";
                string msg = (MessageTextBox.Text.Length > 0)?MessageTextBox.Text:"Пустое сообщение"; 
                if (WhotextBox.Text.Contains("/") || WhotextBox.Text.Contains(".") || WhotextBox.Text.Contains(",") || WhotextBox.Text.Contains(";") || WhotextBox.Text.Contains(":") || WhotextBox.Text.Contains("!"))
                {
                    alertlabel.Text = "Ошибка 2022: Использованы недопустимые символы!";
                    return;
                }
                string who = WhotextBox.Text;
                string theme = (ThemetextBox.Text.Length > 0)?ThemetextBox.Text:"Без темы";
                MessageTextBox.Clear();
                WhotextBox.Clear();
                ThemetextBox.Clear();
                if (connected)
                {
                    Mail mail = new Mail();
                    mail.msg = msg;
                    mail.who = who;
                    mail.theme = theme;
                    JavaScriptSerializer json = new JavaScriptSerializer();
                    try
                    {
                        Send(json.Serialize(mail));
                    }
                    catch (Exception ex)
                    {
                        alertlabel.Text = ErrorMsg(ex.Message);
                    }
                }
            }
                    else alertlabel.Text = "Ошибка: Для отправки письма введите почту получателя";
        }


        ///////// Таблица с письмами

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
