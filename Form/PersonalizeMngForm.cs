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
            visiteecnic.Text = "Visitee CNIC : " + cnic2;
            visiteecontact.Text = "Visitee Contact: " + contact2;
            date.Text = "From : " + startTime + " To : " + endTime;

        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            // Print form contents
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, new Point(100, 100));
        }

        private void PersonalizeMngForm_Load(object sender, EventArgs e)
        {
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
    }
}
