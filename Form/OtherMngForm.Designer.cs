namespace StandaloneSDKDemo
{
    partial class OtherMngForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBrowser1 = new System.Windows.Forms.Button();
            this.txtFirmwareFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdateFirmware = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReadFileName = new System.Windows.Forms.TextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnBrowser2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSendFileName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.btnPowerOffDevice = new System.Windows.Forms.Button();
            this.btnRestartDevice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbWavIndex = new System.Windows.Forms.ComboBox();
            this.btnPlayWavByIndex = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDeviceTime = new System.Windows.Forms.DateTimePicker();
            this.btnSetDeviceTime = new System.Windows.Forms.Button();
            this.lbDeviceTime = new System.Windows.Forms.Label();
            this.btnGetDeviceTime = new System.Windows.Forms.Button();
            this.btnSYNCTime = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Advanced settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnBrowser1);
            this.groupBox6.Controls.Add(this.txtFirmwareFile);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.btnUpdateFirmware);
            this.groupBox6.Location = new System.Drawing.Point(372, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(537, 64);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Update firmware";
            // 
            // btnBrowser1
            // 
            this.btnBrowser1.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBrowser1.Location = new System.Drawing.Point(362, 28);
            this.btnBrowser1.Name = "btnBrowser1";
            this.btnBrowser1.Size = new System.Drawing.Size(55, 25);
            this.btnBrowser1.TabIndex = 27;
            this.btnBrowser1.Text = "Browse";
            this.btnBrowser1.UseVisualStyleBackColor = true;
            this.btnBrowser1.Click += new System.EventHandler(this.btnBrowser1_Click);
            // 
            // txtFirmwareFile
            // 
            this.txtFirmwareFile.Location = new System.Drawing.Point(100, 28);
            this.txtFirmwareFile.Name = "txtFirmwareFile";
            this.txtFirmwareFile.Size = new System.Drawing.Size(256, 20);
            this.txtFirmwareFile.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "FirmwareFile";
            // 
            // btnUpdateFirmware
            // 
            this.btnUpdateFirmware.Location = new System.Drawing.Point(434, 28);
            this.btnUpdateFirmware.Name = "btnUpdateFirmware";
            this.btnUpdateFirmware.Size = new System.Drawing.Size(97, 25);
            this.btnUpdateFirmware.TabIndex = 24;
            this.btnUpdateFirmware.Text = "UpdateFirmware";
            this.btnUpdateFirmware.UseVisualStyleBackColor = true;
            this.btnUpdateFirmware.Click += new System.EventHandler(this.btnUpdateFirmware_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtReadFileName);
            this.groupBox5.Controls.Add(this.btnReadFile);
            this.groupBox5.Controls.Add(this.txtFilePath);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnSendFile);
            this.groupBox5.Controls.Add(this.btnBrowser2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtSendFileName);
            this.groupBox5.Location = new System.Drawing.Point(372, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(537, 152);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Send/Read file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(17, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Send file to /mnt/mtdblock\r\nRead file from /mnt/mtdblock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "FileName";
            // 
            // txtReadFileName
            // 
            this.txtReadFileName.Location = new System.Drawing.Point(76, 81);
            this.txtReadFileName.Name = "txtReadFileName";
            this.txtReadFileName.Size = new System.Drawing.Size(100, 20);
            this.txtReadFileName.TabIndex = 15;
            this.txtReadFileName.Text = "LANGUAGE.E";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(434, 81);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(97, 25);
            this.btnReadFile.TabIndex = 17;
            this.btnReadFile.Text = "ReadFile";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(265, 81);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(157, 20);
            this.txtFilePath.TabIndex = 16;
            this.txtFilePath.Text = "D:\\";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "SaveFilePath";
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(434, 37);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(97, 25);
            this.btnSendFile.TabIndex = 12;
            this.btnSendFile.Text = "SendFile";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnBrowser2
            // 
            this.btnBrowser2.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBrowser2.Location = new System.Drawing.Point(362, 40);
            this.btnBrowser2.Name = "btnBrowser2";
            this.btnBrowser2.Size = new System.Drawing.Size(55, 25);
            this.btnBrowser2.TabIndex = 11;
            this.btnBrowser2.Text = "Browse";
            this.btnBrowser2.UseVisualStyleBackColor = true;
            this.btnBrowser2.Click += new System.EventHandler(this.btnBrowser2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "FileName";
            // 
            // txtSendFileName
            // 
            this.txtSendFileName.Location = new System.Drawing.Point(76, 40);
            this.txtSendFileName.Name = "txtSendFileName";
            this.txtSendFileName.Size = new System.Drawing.Size(280, 20);
            this.txtSendFileName.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.btnPowerOffDevice);
            this.groupBox4.Controls.Add(this.btnRestartDevice);
            this.groupBox4.Location = new System.Drawing.Point(8, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 119);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(21, 31);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(154, 13);
            this.label33.TabIndex = 82;
            this.label33.Text = "Restart or Poweroff the device.";
            // 
            // btnPowerOffDevice
            // 
            this.btnPowerOffDevice.Location = new System.Drawing.Point(167, 69);
            this.btnPowerOffDevice.Name = "btnPowerOffDevice";
            this.btnPowerOffDevice.Size = new System.Drawing.Size(111, 25);
            this.btnPowerOffDevice.TabIndex = 80;
            this.btnPowerOffDevice.Text = "PowerOffDevice";
            this.btnPowerOffDevice.UseVisualStyleBackColor = true;
            this.btnPowerOffDevice.Click += new System.EventHandler(this.btnPowerOffDevice_Click);
            // 
            // btnRestartDevice
            // 
            this.btnRestartDevice.Location = new System.Drawing.Point(21, 69);
            this.btnRestartDevice.Name = "btnRestartDevice";
            this.btnRestartDevice.Size = new System.Drawing.Size(109, 25);
            this.btnRestartDevice.TabIndex = 78;
            this.btnRestartDevice.Text = "RestartDevice";
            this.btnRestartDevice.UseVisualStyleBackColor = true;
            this.btnRestartDevice.Click += new System.EventHandler(this.btnRestartDevice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbWavIndex);
            this.groupBox2.Controls.Add(this.btnPlayWavByIndex);
            this.groupBox2.Location = new System.Drawing.Point(372, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Play wav";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Index";
            // 
            // cbWavIndex
            // 
            this.cbWavIndex.FormattingEnabled = true;
            this.cbWavIndex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cbWavIndex.Location = new System.Drawing.Point(142, 25);
            this.cbWavIndex.Name = "cbWavIndex";
            this.cbWavIndex.Size = new System.Drawing.Size(41, 21);
            this.cbWavIndex.TabIndex = 83;
            // 
            // btnPlayWavByIndex
            // 
            this.btnPlayWavByIndex.Location = new System.Drawing.Point(23, 22);
            this.btnPlayWavByIndex.Name = "btnPlayWavByIndex";
            this.btnPlayWavByIndex.Size = new System.Drawing.Size(103, 25);
            this.btnPlayWavByIndex.TabIndex = 79;
            this.btnPlayWavByIndex.Text = "PlayWavByIndex";
            this.btnPlayWavByIndex.UseVisualStyleBackColor = true;
            this.btnPlayWavByIndex.Click += new System.EventHandler(this.btnPlayWavByIndex_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtDeviceTime);
            this.groupBox1.Controls.Add(this.btnSetDeviceTime);
            this.groupBox1.Controls.Add(this.lbDeviceTime);
            this.groupBox1.Controls.Add(this.btnGetDeviceTime);
            this.groupBox1.Controls.Add(this.btnSYNCTime);
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SYNC Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "SYNC the PC\'s time to device";
            // 
            // dtDeviceTime
            // 
            this.dtDeviceTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtDeviceTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeviceTime.Location = new System.Drawing.Point(126, 98);
            this.dtDeviceTime.Name = "dtDeviceTime";
            this.dtDeviceTime.Size = new System.Drawing.Size(152, 20);
            this.dtDeviceTime.TabIndex = 102;
            // 
            // btnSetDeviceTime
            // 
            this.btnSetDeviceTime.Location = new System.Drawing.Point(23, 95);
            this.btnSetDeviceTime.Name = "btnSetDeviceTime";
            this.btnSetDeviceTime.Size = new System.Drawing.Size(95, 25);
            this.btnSetDeviceTime.TabIndex = 10;
            this.btnSetDeviceTime.Text = "SetDeviceTime";
            this.btnSetDeviceTime.UseVisualStyleBackColor = true;
            this.btnSetDeviceTime.Click += new System.EventHandler(this.btnSetDeviceTime_Click);
            // 
            // lbDeviceTime
            // 
            this.lbDeviceTime.AutoSize = true;
            this.lbDeviceTime.ForeColor = System.Drawing.Color.Red;
            this.lbDeviceTime.Location = new System.Drawing.Point(124, 63);
            this.lbDeviceTime.Name = "lbDeviceTime";
            this.lbDeviceTime.Size = new System.Drawing.Size(54, 13);
            this.lbDeviceTime.TabIndex = 3;
            this.lbDeviceTime.Text = "show time";
            // 
            // btnGetDeviceTime
            // 
            this.btnGetDeviceTime.Location = new System.Drawing.Point(23, 57);
            this.btnGetDeviceTime.Name = "btnGetDeviceTime";
            this.btnGetDeviceTime.Size = new System.Drawing.Size(95, 25);
            this.btnGetDeviceTime.TabIndex = 2;
            this.btnGetDeviceTime.Text = "GetDeviceTime";
            this.btnGetDeviceTime.UseVisualStyleBackColor = true;
            this.btnGetDeviceTime.Click += new System.EventHandler(this.btnGetDeviceTime_Click);
            // 
            // btnSYNCTime
            // 
            this.btnSYNCTime.Location = new System.Drawing.Point(23, 26);
            this.btnSYNCTime.Name = "btnSYNCTime";
            this.btnSYNCTime.Size = new System.Drawing.Size(95, 25);
            this.btnSYNCTime.TabIndex = 1;
            this.btnSYNCTime.Text = "SYNCTime";
            this.btnSYNCTime.UseVisualStyleBackColor = true;
            this.btnSYNCTime.Click += new System.EventHandler(this.btnSYNCTime_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add System Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.pass2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.pass1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.username);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(201, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 278);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update firmware";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(160, 31);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(256, 20);
            this.username.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "User Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 25);
            this.button2.TabIndex = 24;
            this.button2.Text = "Add User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(160, 82);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(256, 20);
            this.pass1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Password";
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(160, 135);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(256, 20);
            this.pass2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Confirm Password";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(160, 199);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(362, 199);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Admin";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Role";
            // 
            // OtherMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 425);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OtherMngForm";
            this.Text = "OtherMngForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetDeviceTime;
        private System.Windows.Forms.Label lbDeviceTime;
        private System.Windows.Forms.Button btnGetDeviceTime;
        private System.Windows.Forms.Button btnSYNCTime;
        private System.Windows.Forms.DateTimePicker dtDeviceTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbWavIndex;
        private System.Windows.Forms.Button btnPlayWavByIndex;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnPowerOffDevice;
        private System.Windows.Forms.Button btnRestartDevice;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBrowser1;
        private System.Windows.Forms.TextBox txtFirmwareFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdateFirmware;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnBrowser2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSendFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReadFileName;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}