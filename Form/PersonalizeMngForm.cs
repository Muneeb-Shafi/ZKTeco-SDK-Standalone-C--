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

        public PersonalizeMngForm(string name, string contact, string startTime, string endTime)
        {
            InitializeComponent();

            // Set guest details
            nameLabel.Text = "Name: " + name;
            contactLabel.Text = "Contact: " + contact;
            startLabel.Text = "Start Time: " + startTime;
            endLabel.Text = "End Time: " + endTime;
        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            // Print form contents
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, new Point(100, 100));
        }

        private void PassForm_Load(object sender, EventArgs e)
        {
            // Print pass automatically when form loads
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;

            // Uncomment below line if you want to display the print dialog before printing
            // PrintDialog printDialog = new PrintDialog {Document = printDocument};
            // if (printDialog.ShowDialog() == DialogResult.OK)
            // {
            //    printDocument.Print();
            // }
            // else
            // {
            //    Close();
            // }

            printDocument.Print(); // Uncomment if you don't want to display the print dialog
            Close();
        }

        private Label nameLabel;
        private Label contactLabel;
        private Label startLabel;
        private Label endLabel;
        private Bitmap bitmap = new Bitmap(600, 600); // Adjust size as needed
    }
}
