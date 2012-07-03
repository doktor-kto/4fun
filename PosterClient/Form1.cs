﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace PosterClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click( object sender, EventArgs e )
        {
            IPAddress ip;

            try
            {
                ip = IPAddress.Parse(ipTextBox.Text);
            }
            catch ( FormatException ex )
            {
                MessageBox.Show("Неправильно введен IP сервера");
                return;
            }

            TcpClient tcpclnt = new TcpClient();
            tcpclnt.Connect(ip, 5050);

            MessageBox.Show("Соединение установлено");
        }
    }
}
