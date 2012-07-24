namespace PosterClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.connectButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.tabAntiCaptcha = new System.Windows.Forms.TabPage();
            this.captchaConnect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.captchaKeyTextBox = new System.Windows.Forms.TextBox();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.tabAdvert = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.btnPostAdv = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.floorNumberTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.squareTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.subwayTextBox = new System.Windows.Forms.TextBox();
            this.districtTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.RichTextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.tabAntiCaptcha.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            this.tabAdvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabServer);
            this.tabControl1.Controls.Add(this.tabAntiCaptcha);
            this.tabControl1.Controls.Add(this.tabAccounts);
            this.tabControl1.Controls.Add(this.tabAdvert);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 760);
            this.tabControl1.TabIndex = 0;
            // 
            // tabServer
            // 
            this.tabServer.Controls.Add(this.connectButton);
            this.tabServer.Controls.Add(this.label25);
            this.tabServer.Controls.Add(this.ipTextBox);
            this.tabServer.Location = new System.Drawing.Point(4, 22);
            this.tabServer.Name = "tabServer";
            this.tabServer.Size = new System.Drawing.Size(927, 734);
            this.tabServer.TabIndex = 3;
            this.tabServer.Text = "Сервер";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(353, 37);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(152, 44);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(45, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "IP:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(71, 50);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(257, 20);
            this.ipTextBox.TabIndex = 0;
            // 
            // tabAntiCaptcha
            // 
            this.tabAntiCaptcha.Controls.Add(this.captchaConnect);
            this.tabAntiCaptcha.Controls.Add(this.label8);
            this.tabAntiCaptcha.Controls.Add(this.label7);
            this.tabAntiCaptcha.Controls.Add(this.captchaKeyTextBox);
            this.tabAntiCaptcha.Location = new System.Drawing.Point(4, 22);
            this.tabAntiCaptcha.Name = "tabAntiCaptcha";
            this.tabAntiCaptcha.Size = new System.Drawing.Size(927, 734);
            this.tabAntiCaptcha.TabIndex = 2;
            this.tabAntiCaptcha.Text = "Антикаптча";
            this.tabAntiCaptcha.UseVisualStyleBackColor = true;
            // 
            // captchaConnect
            // 
            this.captchaConnect.Location = new System.Drawing.Point(364, 31);
            this.captchaConnect.Name = "captchaConnect";
            this.captchaConnect.Size = new System.Drawing.Size(122, 46);
            this.captchaConnect.TabIndex = 6;
            this.captchaConnect.Text = "Connect";
            this.captchaConnect.UseVisualStyleBackColor = true;
            this.captchaConnect.Click += new System.EventHandler(this.captchaConnect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Antigate.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Key:";
            // 
            // captchaKeyTextBox
            // 
            this.captchaKeyTextBox.Location = new System.Drawing.Point(68, 45);
            this.captchaKeyTextBox.Name = "captchaKeyTextBox";
            this.captchaKeyTextBox.Size = new System.Drawing.Size(257, 20);
            this.captchaKeyTextBox.TabIndex = 2;
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.label12);
            this.tabAccounts.Controls.Add(this.label9);
            this.tabAccounts.Controls.Add(this.label6);
            this.tabAccounts.Controls.Add(this.btnLogin);
            this.tabAccounts.Controls.Add(this.label3);
            this.tabAccounts.Controls.Add(this.label2);
            this.tabAccounts.Controls.Add(this.label1);
            this.tabAccounts.Controls.Add(this.passTextBox);
            this.tabAccounts.Controls.Add(this.loginTextBox);
            this.tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccounts.Size = new System.Drawing.Size(927, 734);
            this.tabAccounts.TabIndex = 0;
            this.tabAccounts.Text = "Аккаунты";
            this.tabAccounts.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Restate.ru";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Olx.ru";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Avito.ru";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(365, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 46);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slando.ru";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(84, 167);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(257, 20);
            this.passTextBox.TabIndex = 1;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(84, 141);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(257, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // tabAdvert
            // 
            this.tabAdvert.Controls.Add(this.label10);
            this.tabAdvert.Controls.Add(this.emailTextBox);
            this.tabAdvert.Controls.Add(this.label5);
            this.tabAdvert.Controls.Add(this.dateTextBox);
            this.tabAdvert.Controls.Add(this.label4);
            this.tabAdvert.Controls.Add(this.personTextBox);
            this.tabAdvert.Controls.Add(this.btnPostAdv);
            this.tabAdvert.Controls.Add(this.label24);
            this.tabAdvert.Controls.Add(this.phoneTextBox);
            this.tabAdvert.Controls.Add(this.label23);
            this.tabAdvert.Controls.Add(this.floorNumberTextBox);
            this.tabAdvert.Controls.Add(this.label22);
            this.tabAdvert.Controls.Add(this.floorTextBox);
            this.tabAdvert.Controls.Add(this.label21);
            this.tabAdvert.Controls.Add(this.nameTextBox);
            this.tabAdvert.Controls.Add(this.squareTextBox);
            this.tabAdvert.Controls.Add(this.label20);
            this.tabAdvert.Controls.Add(this.houseTextBox);
            this.tabAdvert.Controls.Add(this.streetTextBox);
            this.tabAdvert.Controls.Add(this.label19);
            this.tabAdvert.Controls.Add(this.label18);
            this.tabAdvert.Controls.Add(this.subwayTextBox);
            this.tabAdvert.Controls.Add(this.districtTextBox);
            this.tabAdvert.Controls.Add(this.label17);
            this.tabAdvert.Controls.Add(this.label16);
            this.tabAdvert.Controls.Add(this.button5);
            this.tabAdvert.Controls.Add(this.label15);
            this.tabAdvert.Controls.Add(this.descTextBox);
            this.tabAdvert.Controls.Add(this.priceTextBox);
            this.tabAdvert.Controls.Add(this.label14);
            this.tabAdvert.Controls.Add(this.label13);
            this.tabAdvert.Controls.Add(this.roomNumberTextBox);
            this.tabAdvert.Location = new System.Drawing.Point(4, 22);
            this.tabAdvert.Name = "tabAdvert";
            this.tabAdvert.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvert.Size = new System.Drawing.Size(927, 734);
            this.tabAdvert.TabIndex = 1;
            this.tabAdvert.Text = "Объявление";
            this.tabAdvert.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 528);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(521, 525);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(257, 20);
            this.emailTextBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Дата (ДД-ММ-ГГ)";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(521, 477);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(257, 20);
            this.dateTextBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Имя";
            // 
            // personTextBox
            // 
            this.personTextBox.Location = new System.Drawing.Point(522, 438);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(257, 20);
            this.personTextBox.TabIndex = 27;
            // 
            // btnPostAdv
            // 
            this.btnPostAdv.Location = new System.Drawing.Point(526, 586);
            this.btnPostAdv.Name = "btnPostAdv";
            this.btnPostAdv.Size = new System.Drawing.Size(252, 100);
            this.btnPostAdv.TabIndex = 26;
            this.btnPostAdv.Text = "Разместить объявление";
            this.btnPostAdv.UseVisualStyleBackColor = true;
            this.btnPostAdv.Click += new System.EventHandler(this.btnPostAdv_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(413, 398);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Контактный номер";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(522, 395);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(257, 20);
            this.phoneTextBox.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(433, 349);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "Этажей в доме";
            // 
            // floorNumberTextBox
            // 
            this.floorNumberTextBox.Location = new System.Drawing.Point(522, 346);
            this.floorNumberTextBox.Name = "floorNumberTextBox";
            this.floorNumberTextBox.Size = new System.Drawing.Size(257, 20);
            this.floorNumberTextBox.TabIndex = 22;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(461, 303);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Этаж";
            // 
            // floorTextBox
            // 
            this.floorTextBox.Location = new System.Drawing.Point(522, 300);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(257, 20);
            this.floorTextBox.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Название объявления";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(131, 152);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(257, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // squareTextBox
            // 
            this.squareTextBox.Location = new System.Drawing.Point(522, 252);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(257, 20);
            this.squareTextBox.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(461, 255);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Площадь";
            // 
            // houseTextBox
            // 
            this.houseTextBox.Location = new System.Drawing.Point(522, 202);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(257, 20);
            this.houseTextBox.TabIndex = 15;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(522, 152);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(257, 20);
            this.streetTextBox.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(461, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Дом";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(461, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Улица";
            // 
            // subwayTextBox
            // 
            this.subwayTextBox.Location = new System.Drawing.Point(522, 101);
            this.subwayTextBox.Name = "subwayTextBox";
            this.subwayTextBox.Size = new System.Drawing.Size(257, 20);
            this.subwayTextBox.TabIndex = 11;
            // 
            // districtTextBox
            // 
            this.districtTextBox.Location = new System.Drawing.Point(522, 47);
            this.districtTextBox.Name = "districtTextBox";
            this.districtTextBox.Size = new System.Drawing.Size(257, 20);
            this.districtTextBox.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(461, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Метро";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(461, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Район";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(22, 480);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 45);
            this.button5.TabIndex = 7;
            this.button5.Text = "Прикрепить картинки";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Описание";
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(131, 202);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(257, 247);
            this.descTextBox.TabIndex = 5;
            this.descTextBox.Text = "";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(131, 101);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(257, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Цена";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Количество комнат";
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(131, 47);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(257, 20);
            this.roomNumberTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 753);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Poster";
            this.tabControl1.ResumeLayout(false);
            this.tabServer.ResumeLayout(false);
            this.tabServer.PerformLayout();
            this.tabAntiCaptcha.ResumeLayout(false);
            this.tabAntiCaptcha.PerformLayout();
            this.tabAccounts.ResumeLayout(false);
            this.tabAccounts.PerformLayout();
            this.tabAdvert.ResumeLayout(false);
            this.tabAdvert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAccounts;
        private System.Windows.Forms.TabPage tabAdvert;
        private System.Windows.Forms.TabPage tabAntiCaptcha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox descTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox squareTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox subwayTextBox;
        private System.Windows.Forms.TextBox districtTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnPostAdv;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox floorNumberTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox captchaKeyTextBox;
        private System.Windows.Forms.Button captchaConnect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}

