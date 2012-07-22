using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PosterClient
{
    public partial class Form1 : Form
    {
        public TcpClient tcpclnt;
        private NetworkStream _strm;

        public Form1()
        {
            tcpclnt = new TcpClient();
            InitializeComponent();

            ((Control)tabAntiCaptcha).Enabled = false;
            ((Control)tabAdvert).Enabled = false;
            ((Control)tabAccounts).Enabled = false;
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

            tcpclnt.Connect(ip, 5050);

            MessageBox.Show("Соединение установлено");

            ((Control)tabAntiCaptcha).Enabled = true;
            tabControl1.SelectedTab = tabAntiCaptcha;
        }

        public int encodeBytes(String str, ref byte[] buf, int code)
        {            
            buf[0] = (byte)code;

            int length = str.Length;

            int length1 = length % 10,
                length2 = (length / 10) % 10,
                length3 = (length / 100) % 10,
                length4 = (length / 1000) % 10;

            buf[1] = (byte)(length1);
            buf[2] = (byte)(length2);
            buf[3] = (byte)(length3);
            buf[4] = (byte)(length4);

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(str);

            for (int i = 5; i < bytes.Length + 5; i++)
                buf[i] = bytes[i - 5];

            return bytes.Length + 5;
        }

        private void captchaConnect_Click( object sender, EventArgs e )
        {
            String key = captchaKeyTextBox.Text;
            byte[] buf = new byte[4096];
            int length = encodeBytes(key, ref buf, 13);

            _strm = tcpclnt.GetStream();

            _strm.Write(buf, 0, length);

            tabControl1.Enabled = false;
            _strm.Read(buf, 0, 1);
            tabControl1.Enabled = true;

            if (buf[0] == 1)
            {
                MessageBox.Show("Соединение с antigate установлено. Ключ правильный.");
                ((Control)tabAccounts).Enabled = true;
                tabControl1.SelectedTab = tabAccounts;
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, попробуйте еще раз.");
                ((Control)tabAccounts).Enabled = true;
                tabControl1.SelectedTab = tabAntiCaptcha;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[4096];

            int length = encodeBytes(loginTextBox.Text, ref buf, 12);

            _strm.Write(buf, 0, length);

            length = encodeBytes(passTextBox.Text, ref buf, 11);

            _strm.Write(buf, 0, length);

            ((Control)tabAdvert).Enabled = true;
            tabControl1.SelectedTab = tabAdvert;
        }

        private void btnPostAdv_Click(object sender, EventArgs e)
        {
            String adv = descTextBox.Text + "\n" + priceTextBox.Text + "\n" +  
                         roomNumberTextBox.Text + "\n" + nameTextBox.Text + "\n" +
                         squareTextBox.Text + "\n" + houseTextBox.Text + "\n" +
                         streetTextBox.Text + "\n" + subwayTextBox.Text + "\n" +
                         districtTextBox.Text + "\n" + phoneTextBox.Text + "\n" +
                         floorNumberTextBox.Text + "\n" + floorTextBox.Text + "\n" +
                         personTextBox.Text + "\n" + dateTextBox.Text + "\n" + emailTextBox.Text;

            byte[] buf = new byte[4096];

            int length = encodeBytes(adv, ref buf, 10);

            _strm.Write(buf, 0, length);
        }

    }
}