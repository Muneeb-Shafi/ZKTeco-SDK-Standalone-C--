using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace StandaloneSDKDemo
{
    public partial class PersonalizeMngForm : Form
    {
        public PersonalizeMngForm(Main Parent)
        {
            InitializeComponent();
        }

        public PersonalizeMngForm(string name, string contact, string cnic, string name2, string contact2, string cnic2, string startTime, string endTime)
        {
            InitializeComponent();

            // Set guest details

            visitorName.Text ="Name : " + name;
            visitorcnic.Text = "CNIC : " + cnic;
            visitorcontact.Text = "Contact : " + contact;
            visiteename.Text = "Visitee Name : " + name2;
            date.Text = "This Pass is only valid From : " + startTime + " To : " + endTime;

        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            // Print form contents
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, new Point(100, 100));
        }

        private void RotateLabel(Label label, float angle)
        {
            // Create a bitmap to draw the rotated label
            Bitmap bmp = new Bitmap(label.Width, label.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Clear the bitmap with a transparent color
                g.Clear(Color.Transparent);

                // Set the rotation angle
                g.RotateTransform(angle);

                // Draw the label's text on the bitmap
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                g.DrawString(label.Text, label.Font, Brushes.Black, label.ClientRectangle, format);
            }

            // Set the bitmap as the label's background image
            label.BackgroundImage = bmp;
        }

        private void PersonalizeMngForm_Load(object sender, EventArgs e)
        {
            RotateLabel(label1, 90);
            // Print pass automatically when form loads
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;

             PrintDialog printDialog = new PrintDialog { Document = printDocument };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            else
            {
                Close();
            }

            Close();
        }

        private Bitmap bitmap = new Bitmap(550, 250); // Adjust size as needed

        private void visiteename_Click(object sender, EventArgs e)
        {

        }

        private void visitorcontact_Click(object sender, EventArgs e)
        {

        }

        private void visitorcnic_Click(object sender, EventArgs e)
        {

        }

        private void visitorName_Click(object sender, EventArgs e)
        {

        }
    }
}
