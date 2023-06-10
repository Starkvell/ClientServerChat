using System;
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
using static kurs4sem.MainForm;

namespace kurs4sem
{
    public partial class LoginForm : Form
    {
        private MyClient obj;
        static public string username = "";

        public LoginForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                alertlabel.Text = "Ошибка 2023: Введите имя пользователя!";
            }
            else if (textBox1.Text.Contains("/") || textBox1.Text.Contains(".") || textBox1.Text.Contains(",") || textBox1.Text.Contains(";") || textBox1.Text.Contains(":") || textBox1.Text.Contains("!"))
            {
                alertlabel.Text = "Ошибка 2022: Использованы недопустимые символы!";
            }
            else
            {
                username = textBox1.Text;
                string address = "127.0.0.1";
                int port = 9000;
                IPAddress ip = null;
                ip = Dns.Resolve(address).AddressList[0];
                try
                {
                    obj = new MyClient();
                    obj.username = username;
                    obj.client = new TcpClient();
                    obj.client.Connect(ip, port);

                    MainForm mainForm = new MainForm(obj,ip,port,username);
                    this.Hide();
                    mainForm.ShowDialog();
                }
                catch
                {
                    alertlabel.Text = "Ошибка 228: Проблема с соединением к серверу";
                    return;
                }

            }

        }
    }
}
