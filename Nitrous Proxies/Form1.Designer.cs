namespace Nitrous_Proxies
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatGroupBox6 = new FlatUI.FlatGroupBox();
            this.flatGroupBox7 = new FlatUI.FlatGroupBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatGroupBox5 = new FlatUI.FlatGroupBox();
            this.LB_Logs = new System.Windows.Forms.ListBox();
            this.flatGroupBox4 = new FlatUI.FlatGroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.flatRadioButton3 = new FlatUI.FlatRadioButton();
            this.flatGroupBox3 = new FlatUI.FlatGroupBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.flatRadioButton1 = new FlatUI.FlatRadioButton();
            this.flatRadioButton2 = new FlatUI.FlatRadioButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.NUD_ThreadCount = new FlatUI.FlatNumeric();
            this.flatToggle3 = new FlatUI.FlatToggle();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatStatusBar1 = new FlatUI.FlatStatusBar();
            this.backgroundGatherer = new System.ComponentModel.BackgroundWorker();
            this.formSkin1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flatGroupBox6.SuspendLayout();
            this.flatGroupBox5.SuspendLayout();
            this.flatGroupBox4.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.flatGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatLabel3);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.flatStatusBar1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.formSkin1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.formSkin1.ForeColor = System.Drawing.Color.White;
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(800, 450);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Nitrous Proxies";
            this.formSkin1.Click += new System.EventHandler(this.formSkin1_Click);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(163, 9);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(50, 17);
            this.flatLabel3.TabIndex = 29;
            this.flatLabel3.Text = "Scrape";
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 36);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(800, 391);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.tabPage1.Controls.Add(this.flatButton2);
            this.tabPage1.Controls.Add(this.flatGroupBox6);
            this.tabPage1.Controls.Add(this.flatGroupBox5);
            this.tabPage1.Controls.Add(this.flatGroupBox4);
            this.tabPage1.Controls.Add(this.flatGroupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scraper";
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.flatButton2.Location = new System.Drawing.Point(30, 300);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(208, 30);
            this.flatButton2.TabIndex = 5;
            this.flatButton2.Text = "Remove Dupes";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatGroupBox6
            // 
            this.flatGroupBox6.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatGroupBox6.Controls.Add(this.flatGroupBox7);
            this.flatGroupBox6.Controls.Add(this.flatButton1);
            this.flatGroupBox6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatGroupBox6.Location = new System.Drawing.Point(9, 203);
            this.flatGroupBox6.Name = "flatGroupBox6";
            this.flatGroupBox6.ShowText = true;
            this.flatGroupBox6.Size = new System.Drawing.Size(248, 91);
            this.flatGroupBox6.TabIndex = 29;
            this.flatGroupBox6.Text = "Export";
            this.flatGroupBox6.Click += new System.EventHandler(this.flatGroupBox6_Click);
            // 
            // flatGroupBox7
            // 
            this.flatGroupBox7.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatGroupBox7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatGroupBox7.Location = new System.Drawing.Point(254, 12);
            this.flatGroupBox7.Name = "flatGroupBox7";
            this.flatGroupBox7.ShowText = true;
            this.flatGroupBox7.Size = new System.Drawing.Size(240, 319);
            this.flatGroupBox7.TabIndex = 2;
            this.flatGroupBox7.Text = "flatGroupBox7";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.flatButton1.Location = new System.Drawing.Point(21, 41);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(208, 30);
            this.flatButton1.TabIndex = 4;
            this.flatButton1.Text = "Export";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatGroupBox5
            // 
            this.flatGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatGroupBox5.Controls.Add(this.LB_Logs);
            this.flatGroupBox5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatGroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(95)))), ((int)(((byte)(97)))));
            this.flatGroupBox5.Location = new System.Drawing.Point(503, 6);
            this.flatGroupBox5.Name = "flatGroupBox5";
            this.flatGroupBox5.ShowText = true;
            this.flatGroupBox5.Size = new System.Drawing.Size(240, 328);
            this.flatGroupBox5.TabIndex = 3;
            this.flatGroupBox5.Text = "Scraper Log";
            // 
            // LB_Logs
            // 
            this.LB_Logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.LB_Logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Logs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.LB_Logs.FormattingEnabled = true;
            this.LB_Logs.ItemHeight = 16;
            this.LB_Logs.Location = new System.Drawing.Point(21, 36);
            this.LB_Logs.Name = "LB_Logs";
            this.LB_Logs.Size = new System.Drawing.Size(196, 258);
            this.LB_Logs.TabIndex = 6;
            // 
            // flatGroupBox4
            // 
            this.flatGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatGroupBox4.Controls.Add(this.listBox1);
            this.flatGroupBox4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatGroupBox4.ForeColor = System.Drawing.Color.White;
            this.flatGroupBox4.Location = new System.Drawing.Point(257, 6);
            this.flatGroupBox4.Name = "flatGroupBox4";
            this.flatGroupBox4.ShowText = true;
            this.flatGroupBox4.Size = new System.Drawing.Size(240, 328);
            this.flatGroupBox4.TabIndex = 2;
            this.flatGroupBox4.Text = "Scraped Proxies";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 258);
            this.listBox1.TabIndex = 5;
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatGroupBox1.Controls.Add(this.flatRadioButton3);
            this.flatGroupBox1.Controls.Add(this.flatGroupBox3);
            this.flatGroupBox1.Controls.Add(this.flatLabel2);
            this.flatGroupBox1.Controls.Add(this.flatGroupBox2);
            this.flatGroupBox1.Controls.Add(this.flatLabel1);
            this.flatGroupBox1.Controls.Add(this.NUD_ThreadCount);
            this.flatGroupBox1.Controls.Add(this.flatToggle3);
            this.flatGroupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatGroupBox1.Location = new System.Drawing.Point(6, 6);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(248, 195);
            this.flatGroupBox1.TabIndex = 0;
            this.flatGroupBox1.Text = "Proxy Control";
            // 
            // flatRadioButton3
            // 
            this.flatRadioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatRadioButton3.Checked = false;
            this.flatRadioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatRadioButton3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatRadioButton3.Location = new System.Drawing.Point(156, 157);
            this.flatRadioButton3.Name = "flatRadioButton3";
            this.flatRadioButton3.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.flatRadioButton3.Size = new System.Drawing.Size(76, 22);
            this.flatRadioButton3.TabIndex = 27;
            this.flatRadioButton3.Text = "SOCKS4";
            // 
            // flatGroupBox3
            // 
            this.flatGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatGroupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatGroupBox3.Location = new System.Drawing.Point(254, 12);
            this.flatGroupBox3.Name = "flatGroupBox3";
            this.flatGroupBox3.ShowText = true;
            this.flatGroupBox3.Size = new System.Drawing.Size(240, 319);
            this.flatGroupBox3.TabIndex = 2;
            this.flatGroupBox3.Text = "flatGroupBox3";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(21, 88);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(50, 17);
            this.flatLabel2.TabIndex = 28;
            this.flatLabel2.Text = "Scrape";
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatGroupBox2.Controls.Add(this.flatRadioButton1);
            this.flatGroupBox2.Controls.Add(this.flatRadioButton2);
            this.flatGroupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatGroupBox2.Location = new System.Drawing.Point(3, 120);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(175, 71);
            this.flatGroupBox2.TabIndex = 24;
            this.flatGroupBox2.Text = "Proxy Type";
            // 
            // flatRadioButton1
            // 
            this.flatRadioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatRadioButton1.Checked = true;
            this.flatRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatRadioButton1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatRadioButton1.Location = new System.Drawing.Point(21, 37);
            this.flatRadioButton1.Name = "flatRadioButton1";
            this.flatRadioButton1.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.flatRadioButton1.Size = new System.Drawing.Size(54, 22);
            this.flatRadioButton1.TabIndex = 25;
            this.flatRadioButton1.Text = "HTTP";
            // 
            // flatRadioButton2
            // 
            this.flatRadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.flatRadioButton2.Checked = false;
            this.flatRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatRadioButton2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatRadioButton2.Location = new System.Drawing.Point(81, 37);
            this.flatRadioButton2.Name = "flatRadioButton2";
            this.flatRadioButton2.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.flatRadioButton2.Size = new System.Drawing.Size(76, 22);
            this.flatRadioButton2.TabIndex = 26;
            this.flatRadioButton2.Text = "SOCKS4";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(21, 50);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(57, 17);
            this.flatLabel1.TabIndex = 23;
            this.flatLabel1.Text = "Threads";
            // 
            // NUD_ThreadCount
            // 
            this.NUD_ThreadCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.NUD_ThreadCount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.NUD_ThreadCount.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.NUD_ThreadCount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.NUD_ThreadCount.ForeColor = System.Drawing.Color.White;
            this.NUD_ThreadCount.Location = new System.Drawing.Point(135, 45);
            this.NUD_ThreadCount.Maximum = ((long)(1000));
            this.NUD_ThreadCount.Minimum = ((long)(1));
            this.NUD_ThreadCount.Name = "NUD_ThreadCount";
            this.NUD_ThreadCount.Size = new System.Drawing.Size(75, 30);
            this.NUD_ThreadCount.TabIndex = 1;
            this.NUD_ThreadCount.Text = "flatNumeric1";
            this.NUD_ThreadCount.Value = ((long)(1));
            // 
            // flatToggle3
            // 
            this.flatToggle3.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle3.Checked = false;
            this.flatToggle3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flatToggle3.Location = new System.Drawing.Point(135, 81);
            this.flatToggle3.Name = "flatToggle3";
            this.flatToggle3.Options = FlatUI.FlatToggle._Options.Style1;
            this.flatToggle3.Size = new System.Drawing.Size(76, 33);
            this.flatToggle3.TabIndex = 22;
            this.flatToggle3.Text = "flatToggle3";
            this.flatToggle3.CheckedChanged += new FlatUI.FlatToggle.CheckedChangedEventHandler(this.flatToggle3_CheckedChanged);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 14F);
            this.flatMini1.Location = new System.Drawing.Point(746, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 12;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(203)))), ((int)(((byte)(31)))));
            this.flatMini1.Click += new System.EventHandler(this.flatMini1_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 14F);
            this.flatClose1.Location = new System.Drawing.Point(770, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 11;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            // 
            // flatStatusBar1
            // 
            this.flatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.flatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBar1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.flatStatusBar1.ForeColor = System.Drawing.Color.White;
            this.flatStatusBar1.Location = new System.Drawing.Point(0, 427);
            this.flatStatusBar1.Name = "flatStatusBar1";
            this.flatStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.flatStatusBar1.ShowTimeDate = false;
            this.flatStatusBar1.Size = new System.Drawing.Size(800, 23);
            this.flatStatusBar1.TabIndex = 3;
            this.flatStatusBar1.Text = "Currently idle...";
            this.flatStatusBar1.TextColor = System.Drawing.Color.White;
            // 
            // backgroundGatherer
            // 
            this.backgroundGatherer.WorkerReportsProgress = true;
            this.backgroundGatherer.WorkerSupportsCancellation = true;
            this.backgroundGatherer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundGatherer_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flatGroupBox6.ResumeLayout(false);
            this.flatGroupBox5.ResumeLayout(false);
            this.flatGroupBox4.ResumeLayout(false);
            this.flatGroupBox1.ResumeLayout(false);
            this.flatGroupBox1.PerformLayout();
            this.flatGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatStatusBar flatStatusBar1;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private FlatUI.FlatNumeric NUD_ThreadCount;
        private FlatUI.FlatToggle flatToggle3;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FlatUI.FlatGroupBox flatGroupBox4;
        private FlatUI.FlatGroupBox flatGroupBox3;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatGroupBox flatGroupBox2;
        private FlatUI.FlatRadioButton flatRadioButton1;
        private FlatUI.FlatRadioButton flatRadioButton2;
        private FlatUI.FlatLabel flatLabel1;
        private System.ComponentModel.BackgroundWorker backgroundGatherer;
        private FlatUI.FlatGroupBox flatGroupBox5;
        private FlatUI.FlatButton flatButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox LB_Logs;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatGroupBox flatGroupBox6;
        private FlatUI.FlatGroupBox flatGroupBox7;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatRadioButton flatRadioButton3;
    }
}

