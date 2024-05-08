namespace StandaloneSDKDemo
{
    partial class PersonalizeMngForm
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
            this.visitorName = new System.Windows.Forms.Label();
            this.visitorcnic = new System.Windows.Forms.Label();
            this.visitorcontact = new System.Windows.Forms.Label();
            this.visiteename = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // visitorName
            // 
            this.visitorName.AutoSize = true;
            this.visitorName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorName.Location = new System.Drawing.Point(205, 81);
            this.visitorName.Name = "visitorName";
            this.visitorName.Size = new System.Drawing.Size(61, 19);
            this.visitorName.TabIndex = 1;
            this.visitorName.Text = "Name : ";
            this.visitorName.Click += new System.EventHandler(this.visitorName_Click);
            // 
            // visitorcnic
            // 
            this.visitorcnic.AutoSize = true;
            this.visitorcnic.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorcnic.Location = new System.Drawing.Point(205, 121);
            this.visitorcnic.Name = "visitorcnic";
            this.visitorcnic.Size = new System.Drawing.Size(51, 19);
            this.visitorcnic.TabIndex = 2;
            this.visitorcnic.Text = "CNIC :";
            this.visitorcnic.Click += new System.EventHandler(this.visitorcnic_Click);
            // 
            // visitorcontact
            // 
            this.visitorcontact.AutoSize = true;
            this.visitorcontact.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorcontact.Location = new System.Drawing.Point(205, 159);
            this.visitorcontact.Name = "visitorcontact";
            this.visitorcontact.Size = new System.Drawing.Size(73, 19);
            this.visitorcontact.TabIndex = 3;
            this.visitorcontact.Text = "Contact : ";
            this.visitorcontact.Click += new System.EventHandler(this.visitorcontact_Click);
            // 
            // visiteename
            // 
            this.visiteename.AutoSize = true;
            this.visiteename.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteename.Location = new System.Drawing.Point(205, 200);
            this.visiteename.Name = "visiteename";
            this.visiteename.Size = new System.Drawing.Size(63, 19);
            this.visiteename.TabIndex = 4;
            this.visiteename.Text = "Visitee :";
            this.visiteename.Click += new System.EventHandler(this.visiteename_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(135, 229);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(38, 12);
            this.date.TabIndex = 7;
            this.date.Text = "Name : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 66);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StandaloneSDKDemo.Properties.Resources.Agriculture_University_Faisalabad_emblem;
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visitor Pass";
            // 
            // PersonalizeMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.visiteename);
            this.Controls.Add(this.visitorcontact);
            this.Controls.Add(this.visitorcnic);
            this.Controls.Add(this.visitorName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalizeMngForm";
            this.Text = "PersonalizeMngForm";
            this.Load += new System.EventHandler(this.PersonalizeMngForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label visitorName;
        private System.Windows.Forms.Label visitorcnic;
        private System.Windows.Forms.Label visitorcontact;
        private System.Windows.Forms.Label visiteename;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}