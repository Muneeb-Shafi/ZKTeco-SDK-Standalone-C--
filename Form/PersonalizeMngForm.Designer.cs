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
            this.label1 = new System.Windows.Forms.Label();
            this.visitorName = new System.Windows.Forms.Label();
            this.visitorcnic = new System.Windows.Forms.Label();
            this.visitorcontact = new System.Windows.Forms.Label();
            this.visiteename = new System.Windows.Forms.Label();
            this.visiteecnic = new System.Windows.Forms.Label();
            this.visiteecontact = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitor Pass";
            // 
            // visitorName
            // 
            this.visitorName.AutoSize = true;
            this.visitorName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorName.Location = new System.Drawing.Point(12, 93);
            this.visitorName.Name = "visitorName";
            this.visitorName.Size = new System.Drawing.Size(68, 21);
            this.visitorName.TabIndex = 1;
            this.visitorName.Text = "Name : ";
            // 
            // visitorcnic
            // 
            this.visitorcnic.AutoSize = true;
            this.visitorcnic.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorcnic.Location = new System.Drawing.Point(12, 135);
            this.visitorcnic.Name = "visitorcnic";
            this.visitorcnic.Size = new System.Drawing.Size(60, 21);
            this.visitorcnic.TabIndex = 2;
            this.visitorcnic.Text = "CNIC :";
            // 
            // visitorcontact
            // 
            this.visitorcontact.AutoSize = true;
            this.visitorcontact.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorcontact.Location = new System.Drawing.Point(12, 176);
            this.visitorcontact.Name = "visitorcontact";
            this.visitorcontact.Size = new System.Drawing.Size(82, 21);
            this.visitorcontact.TabIndex = 3;
            this.visitorcontact.Text = "Contact : ";
            // 
            // visiteename
            // 
            this.visiteename.AutoSize = true;
            this.visiteename.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteename.Location = new System.Drawing.Point(280, 93);
            this.visiteename.Name = "visiteename";
            this.visiteename.Size = new System.Drawing.Size(73, 21);
            this.visiteename.TabIndex = 4;
            this.visiteename.Text = "Visitee :";
            // 
            // visiteecnic
            // 
            this.visiteecnic.AutoSize = true;
            this.visiteecnic.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteecnic.Location = new System.Drawing.Point(280, 135);
            this.visiteecnic.Name = "visiteecnic";
            this.visiteecnic.Size = new System.Drawing.Size(65, 21);
            this.visiteecnic.TabIndex = 5;
            this.visiteecnic.Text = "CNIC : ";
            // 
            // visiteecontact
            // 
            this.visiteecontact.AutoSize = true;
            this.visiteecontact.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteecontact.Location = new System.Drawing.Point(280, 176);
            this.visiteecontact.Name = "visiteecontact";
            this.visiteecontact.Size = new System.Drawing.Size(82, 21);
            this.visiteecontact.TabIndex = 6;
            this.visiteecontact.Text = "Contact : ";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(64, 219);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(48, 15);
            this.date.TabIndex = 7;
            this.date.Text = "Name : ";
            // 
            // PersonalizeMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.date);
            this.Controls.Add(this.visiteecontact);
            this.Controls.Add(this.visiteecnic);
            this.Controls.Add(this.visiteename);
            this.Controls.Add(this.visitorcontact);
            this.Controls.Add(this.visitorcnic);
            this.Controls.Add(this.visitorName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalizeMngForm";
            this.Text = "PersonalizeMngForm";
            this.Load += new System.EventHandler(this.PersonalizeMngForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label visitorName;
        private System.Windows.Forms.Label visitorcnic;
        private System.Windows.Forms.Label visitorcontact;
        private System.Windows.Forms.Label visiteename;
        private System.Windows.Forms.Label visiteecnic;
        private System.Windows.Forms.Label visiteecontact;
        private System.Windows.Forms.Label date;
    }
}