using System.Drawing;

namespace StandaloneSDKDemo
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbSysOutputInfo = new System.Windows.Forms.ListBox();
            this.cmsDemoEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbVer = new System.Windows.Forms.Label();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.firstMenu6 = new StandaloneSDKDemo.FirstMenu();
            this.firstMenu5 = new StandaloneSDKDemo.FirstMenu();
            this.firstMenu4 = new StandaloneSDKDemo.FirstMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicSmall = new System.Windows.Forms.PictureBox();
            this.firstMenu2 = new StandaloneSDKDemo.FirstMenu();
            this.firstMenu1 = new StandaloneSDKDemo.FirstMenu();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRTOutputInfo = new System.Windows.Forms.ListBox();
            this.cmsDeviceRTEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearInfoMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PrgSTA = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlPersonalize = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.pnlAccess = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlTerminal = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationTimer = new System.Windows.Forms.Timer(this.components);
            this.cmsDemoEvent.SuspendLayout();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.PnlBottom.SuspendLayout();
            this.cmsDeviceRTEvent.SuspendLayout();
            this.PnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSysOutputInfo
            // 
            this.lbSysOutputInfo.ContextMenuStrip = this.cmsDemoEvent;
            this.lbSysOutputInfo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSysOutputInfo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSysOutputInfo.FormattingEnabled = true;
            this.lbSysOutputInfo.ItemHeight = 12;
            this.lbSysOutputInfo.Location = new System.Drawing.Point(2, 17);
            this.lbSysOutputInfo.Name = "lbSysOutputInfo";
            this.lbSysOutputInfo.Size = new System.Drawing.Size(439, 160);
            this.lbSysOutputInfo.TabIndex = 77;
            this.lbSysOutputInfo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbSysOutputInfo_DrawItem);
            // 
            // cmsDemoEvent
            // 
            this.cmsDemoEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInfoMenuItem});
            this.cmsDemoEvent.Name = "contextMenuStripDevice";
            this.cmsDemoEvent.Size = new System.Drawing.Size(102, 26);
            // 
            // ClearInfoMenuItem
            // 
            this.ClearInfoMenuItem.Name = "ClearInfoMenuItem";
            this.ClearInfoMenuItem.Size = new System.Drawing.Size(101, 22);
            this.ClearInfoMenuItem.Text = "Clear";
            this.ClearInfoMenuItem.Click += new System.EventHandler(this.ClearInfoMenuItem_Click);
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVer.ForeColor = System.Drawing.Color.Black;
            this.lbVer.Location = new System.Drawing.Point(298, 186);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(198, 14);
            this.lbVer.TabIndex = 80;
            this.lbVer.Text = "Demo Version:     SDK Version:";
            // 
            // PnlTop
            // 
            this.PnlTop.AutoSize = true;
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.PnlTop.Controls.Add(this.firstMenu6);
            this.PnlTop.Controls.Add(this.firstMenu5);
            this.PnlTop.Controls.Add(this.firstMenu4);
            this.PnlTop.Controls.Add(this.pictureBox1);
            this.PnlTop.Controls.Add(this.PicSmall);
            this.PnlTop.Controls.Add(this.firstMenu2);
            this.PnlTop.Controls.Add(this.firstMenu1);
            this.PnlTop.Controls.Add(this.PicClose);
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(935, 48);
            this.PnlTop.TabIndex = 83;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.PnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // firstMenu6
            // 
            this.firstMenu6.ActiveColor = System.Drawing.Color.Transparent;
            this.firstMenu6.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu6.Caption = "Misc";
            this.firstMenu6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstMenu6.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu6.ForeColor = System.Drawing.SystemColors.Control;
            this.firstMenu6.Location = new System.Drawing.Point(576, 0);
            this.firstMenu6.Name = "firstMenu6";
            this.firstMenu6.Size = new System.Drawing.Size(110, 44);
            this.firstMenu6.TabIndex = 10;
            this.firstMenu6.TextFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu6.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu6_MouseSelected);
            // 
            // firstMenu5
            // 
            this.firstMenu5.ActiveColor = System.Drawing.Color.Transparent;
            this.firstMenu5.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu5.Caption = "Guests";
            this.firstMenu5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstMenu5.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstMenu5.Location = new System.Drawing.Point(475, 0);
            this.firstMenu5.Name = "firstMenu5";
            this.firstMenu5.Size = new System.Drawing.Size(110, 44);
            this.firstMenu5.TabIndex = 9;
            this.firstMenu5.TextFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu5.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu5_MouseSelected);
            this.firstMenu5.Load += new System.EventHandler(this.firstMenu5_Load);
            // 
            // firstMenu4
            // 
            this.firstMenu4.ActiveColor = System.Drawing.Color.Transparent;
            this.firstMenu4.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu4.Caption = "Data";
            this.firstMenu4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstMenu4.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstMenu4.Location = new System.Drawing.Point(378, 0);
            this.firstMenu4.Name = "firstMenu4";
            this.firstMenu4.Size = new System.Drawing.Size(98, 44);
            this.firstMenu4.TabIndex = 8;
            this.firstMenu4.TextFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu4.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu4_MouseSelected);
            this.firstMenu4.Load += new System.EventHandler(this.firstMenu4_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicHome_MouseClick);
            // 
            // PicSmall
            // 
            this.PicSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSmall.Image = ((System.Drawing.Image)(resources.GetObject("PicSmall.Image")));
            this.PicSmall.Location = new System.Drawing.Point(857, 5);
            this.PicSmall.Name = "PicSmall";
            this.PicSmall.Size = new System.Drawing.Size(30, 32);
            this.PicSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSmall.TabIndex = 6;
            this.PicSmall.TabStop = false;
            this.PicSmall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicSmall_MouseClick);
            // 
            // firstMenu2
            // 
            this.firstMenu2.ActiveColor = System.Drawing.Color.Transparent;
            this.firstMenu2.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu2.Caption = "User";
            this.firstMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstMenu2.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstMenu2.Location = new System.Drawing.Point(271, 0);
            this.firstMenu2.Name = "firstMenu2";
            this.firstMenu2.Size = new System.Drawing.Size(110, 44);
            this.firstMenu2.TabIndex = 4;
            this.firstMenu2.TextFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu2.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu2_MouseSelected);
            this.firstMenu2.Load += new System.EventHandler(this.firstMenu2_Load);
            // 
            // firstMenu1
            // 
            this.firstMenu1.ActiveColor = System.Drawing.Color.Transparent;
            this.firstMenu1.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu1.Caption = "Devices";
            this.firstMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstMenu1.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstMenu1.Location = new System.Drawing.Point(175, 0);
            this.firstMenu1.Name = "firstMenu1";
            this.firstMenu1.Size = new System.Drawing.Size(96, 44);
            this.firstMenu1.TabIndex = 3;
            this.firstMenu1.TextFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu1.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu1_MouseSelected);
            this.firstMenu1.Load += new System.EventHandler(this.firstMenu1_Load);
            // 
            // PicClose
            // 
            this.PicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClose.Image = ((System.Drawing.Image)(resources.GetObject("PicClose.Image")));
            this.PicClose.Location = new System.Drawing.Point(898, 5);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(30, 32);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 2;
            this.PicClose.TabStop = false;
            this.PicClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicClose_MouseClick);
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PnlBottom.Controls.Add(this.label2);
            this.PnlBottom.Controls.Add(this.label1);
            this.PnlBottom.Controls.Add(this.lbRTOutputInfo);
            this.PnlBottom.Controls.Add(this.PrgSTA);
            this.PnlBottom.Controls.Add(this.label3);
            this.PnlBottom.Controls.Add(this.lbSysOutputInfo);
            this.PnlBottom.Controls.Add(this.lbVer);
            this.PnlBottom.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlBottom.Location = new System.Drawing.Point(0, 492);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(934, 189);
            this.PnlBottom.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 14);
            this.label2.TabIndex = 85;
            this.label2.Text = "Device Real-Time Event:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 84;
            this.label1.Text = "Output:";
            // 
            // lbRTOutputInfo
            // 
            this.lbRTOutputInfo.ContextMenuStrip = this.cmsDeviceRTEvent;
            this.lbRTOutputInfo.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRTOutputInfo.FormattingEnabled = true;
            this.lbRTOutputInfo.ItemHeight = 12;
            this.lbRTOutputInfo.Location = new System.Drawing.Point(447, 17);
            this.lbRTOutputInfo.Name = "lbRTOutputInfo";
            this.lbRTOutputInfo.Size = new System.Drawing.Size(484, 160);
            this.lbRTOutputInfo.TabIndex = 83;
            // 
            // cmsDeviceRTEvent
            // 
            this.cmsDeviceRTEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInfoMenuItem1});
            this.cmsDeviceRTEvent.Name = "contextMenuStripDevice";
            this.cmsDeviceRTEvent.Size = new System.Drawing.Size(102, 26);
            // 
            // ClearInfoMenuItem1
            // 
            this.ClearInfoMenuItem1.Name = "ClearInfoMenuItem1";
            this.ClearInfoMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.ClearInfoMenuItem1.Text = "Clear";
            this.ClearInfoMenuItem1.Click += new System.EventHandler(this.ClearInfoMenuItem1_Click);
            // 
            // PrgSTA
            // 
            this.PrgSTA.Location = new System.Drawing.Point(1, 186);
            this.PrgSTA.Name = "PrgSTA";
            this.PrgSTA.Size = new System.Drawing.Size(282, 15);
            this.PrgSTA.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 14);
            this.label3.TabIndex = 81;
            this.label3.Text = "Copyright © 2024 Optimum Tech, All Rights Reserved.";
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlMiddle.Controls.Add(this.button1);
            this.PnlMiddle.Controls.Add(this.password);
            this.PnlMiddle.Controls.Add(this.username);
            this.PnlMiddle.Controls.Add(this.label8);
            this.PnlMiddle.Controls.Add(this.label7);
            this.PnlMiddle.Controls.Add(this.label6);
            this.PnlMiddle.Controls.Add(this.pictureBox3);
            this.PnlMiddle.Controls.Add(this.pnlPersonalize);
            this.PnlMiddle.Controls.Add(this.pnlUser);
            this.PnlMiddle.Controls.Add(this.pnlOther);
            this.PnlMiddle.Controls.Add(this.pnlAccess);
            this.PnlMiddle.Controls.Add(this.pnlData);
            this.PnlMiddle.Controls.Add(this.pnlTerminal);
            this.PnlMiddle.Controls.Add(this.pictureBox2);
            this.PnlMiddle.Location = new System.Drawing.Point(0, 44);
            this.PnlMiddle.Name = "PnlMiddle";
            this.PnlMiddle.Size = new System.Drawing.Size(934, 423);
            this.PnlMiddle.TabIndex = 86;
            this.PnlMiddle.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMiddle_Paint);
            this.PnlMiddle.Enter += new System.EventHandler(this.PnlMiddle_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 95;
            this.button1.Text = "Login";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(402, 361);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(160, 23);
            this.password.TabIndex = 94;
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // username
            // 
            // 
            // 
            // 
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(402, 332);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.ShortcutsEnabled = true;
            this.username.Size = new System.Drawing.Size(160, 23);
            this.username.TabIndex = 93;
            this.username.UseSelectable = true;
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 87;
            this.label6.Text = "Login";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StandaloneSDKDemo.Properties.Resources.sgri;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(934, 289);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pnlPersonalize
            // 
            this.pnlPersonalize.Location = new System.Drawing.Point(857, 9);
            this.pnlPersonalize.Name = "pnlPersonalize";
            this.pnlPersonalize.Size = new System.Drawing.Size(16, 17);
            this.pnlPersonalize.TabIndex = 3;
            // 
            // pnlUser
            // 
            this.pnlUser.Location = new System.Drawing.Point(842, 9);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(16, 17);
            this.pnlUser.TabIndex = 2;
            // 
            // pnlOther
            // 
            this.pnlOther.Location = new System.Drawing.Point(901, 9);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(16, 17);
            this.pnlOther.TabIndex = 6;
            // 
            // pnlAccess
            // 
            this.pnlAccess.Location = new System.Drawing.Point(886, 9);
            this.pnlAccess.Name = "pnlAccess";
            this.pnlAccess.Size = new System.Drawing.Size(16, 17);
            this.pnlAccess.TabIndex = 5;
            // 
            // pnlData
            // 
            this.pnlData.Location = new System.Drawing.Point(871, 9);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(16, 17);
            this.pnlData.TabIndex = 4;
            // 
            // pnlTerminal
            // 
            this.pnlTerminal.Location = new System.Drawing.Point(827, 9);
            this.pnlTerminal.Name = "pnlTerminal";
            this.pnlTerminal.Size = new System.Drawing.Size(16, 17);
            this.pnlTerminal.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(311, 329);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "+92 313 6650965";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TheOptimumtech.com";
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propertyToolStripMenuItem.Text = "Property";
            // 
            // notificationTimer
            // 
            this.notificationTimer.Enabled = true;
            this.notificationTimer.Interval = 1000;
            this.notificationTimer.Tick += new System.EventHandler(this.notificationTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 685);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PnlMiddle);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StandaloneSDKDemoV1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.cmsDemoEvent.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            this.cmsDeviceRTEvent.ResumeLayout(false);
            this.PnlMiddle.ResumeLayout(false);
            this.PnlMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlMiddle;
        private System.Windows.Forms.PictureBox PicClose;
        private FirstMenu firstMenu1;
        private FirstMenu firstMenu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicSmall;
        private System.Windows.Forms.PictureBox pictureBox1;
        public  System.Windows.Forms.ListBox lbSysOutputInfo;
        public  System.Windows.Forms.ProgressBar PrgSTA;
        private FirstMenu firstMenu4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRTOutputInfo;
        private System.Windows.Forms.Label label2;
        private FirstMenu firstMenu5;
        private FirstMenu firstMenu6;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.Panel pnlAccess;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlPersonalize;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlTerminal;
        private System.Windows.Forms.ContextMenuStrip cmsDemoEvent;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDeviceRTEvent;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer notificationTimer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroButton button1;
    }
}

