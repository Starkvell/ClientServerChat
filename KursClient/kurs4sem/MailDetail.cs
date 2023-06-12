﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs4sem
{
    public partial class MailDetail : Form
    {
        public MailDetail(string from, string theme, string msg)
        {
            InitializeComponent();

            whoTextBox.Text = from + "@bobkin.ru";
            Text = "Подробности письма от пользователя " + whoTextBox.Text;
            themeTextBox.Text = theme;
            messageTextBox.Text = msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
