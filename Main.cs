using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;

namespace StandaloneSDKDemo
{
    public partial class Main : Form
    {
        String demoVersion = "1.9";//Please set correct demo version when code be changed; 
        bool notifyCheck = false;
        private NotifyIcon notifyIcon = new NotifyIcon();

        public Main()
        {
            InitializeComponent();
            string ver = null;
            SDK.axCZKEM1.GetSDKVersion(ref ver);
            lbVer.Text = "Software Version:" + demoVersion + "  SDK Version:" + ver;
        }

        //public bool connected = false;
        public SDKHelper SDK = new SDKHelper();

        FirstMenu firstMenu = new FirstMenu();

        Point mouseOffset;
        Point FormLocation;
        bool isMouseDown;
        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;
                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }

        private void PnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        private void firstMenu1_MouseSelected(object sender, EventArgs e)
        {
            firstMenu2.BackColor = Color.Transparent;
            firstMenu4.BackColor = Color.Transparent;
            firstMenu5.BackColor = Color.Transparent;
            firstMenu6.BackColor = Color.Transparent;

            firstMenu1.TextColor = Color.White;
            firstMenu2.TextColor = Color.Black;
            firstMenu4.TextColor = Color.Black;
            firstMenu5.TextColor = Color.Black;
            firstMenu6.TextColor = Color.Black;

            pnlTerminal.Visible = true;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;

            pnlTerminal.Dock = DockStyle.Fill;

            if (pnlTerminal.Controls.Count == 0)
            {
                TerminalForm terminalForm = new TerminalForm(this);
                terminalForm.TopLevel = false;
                this.pnlTerminal.Controls.Add(terminalForm);
                terminalForm.Show();
            }
        }

        private void firstMenu2_MouseSelected(object sender, EventArgs e)
        {
            firstMenu1.BackColor = Color.Transparent;
            firstMenu4.BackColor = Color.Transparent;
            firstMenu5.BackColor = Color.Transparent;
            firstMenu6.BackColor = Color.Transparent;

            firstMenu1.TextColor = Color.Black;
            firstMenu2.TextColor = Color.White;
            firstMenu4.TextColor = Color.Black;
            firstMenu5.TextColor = Color.Black;
            firstMenu6.TextColor = Color.Black;

            pnlTerminal.Visible = false;
            pnlUser.Visible = true;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;

            pnlUser.Dock = DockStyle.Fill;

            if (pnlUser.Controls.Count == 0)
            {
                UserMngForm UserMng = new UserMngForm(this);
                UserMng.TopLevel = false;
                this.pnlUser.Controls.Add(UserMng);
                UserMng.Show();
            }
        }

        private void firstMenu3_MouseSelected(object sender, EventArgs e)
        {
            firstMenu1.BackColor = Color.Transparent;
            firstMenu2.BackColor = Color.Transparent;
            firstMenu4.BackColor = Color.Transparent;
            firstMenu5.BackColor = Color.Transparent;
            firstMenu6.BackColor = Color.Transparent;

            firstMenu1.TextColor = Color.Black;
            firstMenu2.TextColor = Color.Black;
            firstMenu4.TextColor = Color.Black;
            firstMenu5.TextColor = Color.Black;
            firstMenu6.TextColor = Color.Black;

            pnlTerminal.Visible = false;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = true;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;

            pnlPersonalize.Dock = DockStyle.Fill;

            if (pnlPersonalize.Controls.Count == 0)
            {
                PersonalizeMngForm personalizeMng = new PersonalizeMngForm(this);
                personalizeMng.TopLevel = false;
                this.pnlPersonalize.Controls.Add(personalizeMng);
                personalizeMng.Show();
            }
        }

        private void PicSmall_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicClose_MouseClick(object sender, MouseEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Are you sure to exit system?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            DialogResult dr = ZKMessgeBox.Show("Exit the program?", "Warning!", ZKMessgeBox.I8Buttons.OKCancel);
           
            if (dr == DialogResult.OK)
            {
                SDK.sta_DisConnect();
                Application.Exit();
            }
        }

        private void PicHome_MouseClick(object sender, MouseEventArgs e)
        {
            firstMenu1.BackColor = Color.Transparent;
            firstMenu2.BackColor = Color.Transparent;
            firstMenu4.BackColor = Color.Transparent;
            firstMenu5.BackColor = Color.Transparent;
            firstMenu6.BackColor = Color.Transparent;

            firstMenu1.TextColor = Color.Black;
            firstMenu2.TextColor = Color.Black;
            firstMenu4.TextColor = Color.Black;
            firstMenu5.TextColor = Color.Black;
            firstMenu6.TextColor = Color.Black;

            pnlTerminal.Visible = false;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;

            //this.PnlMiddle.Controls.Add(labAD);
        }

        private void lbSysOutputInfo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                if (lbSysOutputInfo.Items[e.Index].ToString().Substring(0, 1) == "*")//if begin with *, the font color is red   
                {
                    e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Red), e.Bounds);
                }
                else
                {
                    e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                }
                e.DrawFocusRectangle();
            }
        }

        private void firstMenu4_MouseSelected(object sender, EventArgs e)
        {
            firstMenu1.BackColor = Color.Transparent;
            firstMenu2.BackColor = Color.Transparent;
            firstMenu5.BackColor = Color.Transparent;
            firstMenu6.BackColor = Color.Transparent;

            firstMenu1.TextColor = Color.Black;
            firstMenu2.TextColor = Color.Black;
            firstMenu4.TextColor = Color.White;
            firstMenu5.TextColor = Color.Black;
            firstMenu6.TextColor = Color.Black;

            pnlTerminal.Visible = false;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = false;
            pnlData.Visible = true;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;

            pnlData.Dock = DockStyle.Fill;

            if (pnlData.Controls.Count == 0)
            {
                DataMngForm dataMngFrom = new DataMngForm(this);
                dataMngFrom.TopLevel = false;
                this.pnlData.Controls.Add(dataMngFrom);
                dataMngFrom.Show();
            }
        }

        private void firstMenu5_MouseSelected(object sender, EventArgs e)
        {
            firstMenu1.BackColor = Color.Transparent;
            firstMenu2.BackColor = Color.Transparent;
            firstMenu4.BackColor = Color.Transparent;
            firstMenu6.BackColor = Color.Transparent;

            firstMenu1.TextColor = Color.Black;
            firstMenu2.TextColor = Color.Black;
            firstMenu4.TextColor = Color.Black;
            firstMenu5.TextColor = Color.White;
            firstMenu6.TextColor = Color.Black;

            pnlTerminal.Visible = false;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = true;
            pnlOther.Visible = false;

            pnlAccess.Dock = DockStyle.Fill;

            if (pnlAccess.Controls.Count == 0)
            {
                AccessMngForm accessMngFrom = new AccessMngForm(this);
                accessMngFrom.TopLevel = false;
                this.pnlAccess.Controls.Add(accessMngFrom);
                accessMngFrom.Show();
            }
        }

        private void firstMenu6_MouseSelected(object sender, EventArgs e)
        {
            firstMenu1.BackColor = Color.Transparent;
            firstMenu2.BackColor = Color.Transparent;
            firstMenu4.BackColor = Color.Transparent;
            firstMenu5.BackColor = Color.Transparent;

            firstMenu1.TextColor = Color.Black;
            firstMenu2.TextColor = Color.Black;
            firstMenu4.TextColor = Color.Black;
            firstMenu5.TextColor = Color.Black;
            firstMenu6.TextColor = Color.White;

            pnlTerminal.Visible = false;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = true;

            pnlOther.Dock = DockStyle.Fill;

            if (pnlOther.Controls.Count == 0)
            {
                OtherMngForm otherMngFrom = new OtherMngForm(this);
                otherMngFrom.TopLevel = false;
                this.pnlOther.Controls.Add(otherMngFrom);
                otherMngFrom.Show();
            }
        }

        public ListBox RealTimeEventListBox()
        {
            ListBox dtg = lbRTOutputInfo;
            return dtg;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            SDK.sta_SetRTLogListBox(RealTimeEventListBox);

            Cursor = Cursors.Default;
        }

        private void ClearInfoMenuItem_Click(object sender, EventArgs e)
        {
            this.lbSysOutputInfo.Items.Clear();
        }

        private void ClearInfoMenuItem1_Click(object sender, EventArgs e)
        {
            this.lbRTOutputInfo.Items.Clear();
        }

        private void firstMenu2_Load(object sender, EventArgs e)
        {

        }

        private void firstMenu1_Load(object sender, EventArgs e)
        {

        }

        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now; 
            TimeSpan startTime = new TimeSpan(18, 00, 0);
            TimeSpan endTime = new TimeSpan(18, 05, 0); 
            if (currentTime.TimeOfDay >= startTime && currentTime.TimeOfDay <= endTime && notifyCheck == false)
            {
                startProcess(sender, e);
            }
            TimeSpan startTime2 = new TimeSpan(09, 01, 0); 
            TimeSpan endTime2 = new TimeSpan(17, 0, 0); 
            if (currentTime.TimeOfDay >= startTime2 && currentTime.TimeOfDay <= endTime2 && notifyCheck == true)
            {
                notifyCheck = false;
            }
        }

        private void startProcess(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            notifyCheck = true;
            getAttLogs(sender, e);
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.Text = "Students Attendance Report";
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(500000, "ALERT", "These Students have not Checked In Yet", ToolTipIcon.Warning);
            Cursor = Cursors.Default;
        }

        private void getAttLogs(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("dt");
            DataMngForm attFrom = new DataMngForm(this);        
            TerminalForm terminal = new TerminalForm(this);
            DataGridView dg = terminal.iterateMachineforAtt(sender, e);
            int i = 1;

            foreach (DataGridViewRow row in dg.Rows)
            {
                if (i < dg.RowCount)
                {
                    row.Selected = true;
                    string ipAddress = row.Cells["IP Address"].Value.ToString();
                    terminal.txtIP.Text = ipAddress;
                    terminal.btnTCPConnect_Click(sender, e);
                    attFrom.readAttendace(sender, e, dt);
                    terminal.btnTCPConnect_Click(sender, e);
                    i++;
                }
                
            }
            List<string> students = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string userID = (string)row["User ID"];
                //DateTime attendanceTime = (DateTime)row["Attendance Time"];

                if (!students.Contains(userID))
                {
                    students.Add(userID);
                }
                else if (students.Contains(userID))
                {
                    students.Remove(userID);
                }               
            }

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string fileName = currentDate + "StudentList.csv";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, fileName);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Student ID,User Name,Attendance Time,Verify Type,Verify State,WorkCode");
                foreach (string student in students)
                {
                    string searchExpression = "[User ID] LIKE '%" + student + "%'";
                    DataRow[] row = dt.Select(searchExpression);
                    sw.WriteLine(string.Join(",", row[0].ItemArray));
                }
            }
        }

        private void firstMenu4_Load(object sender, EventArgs e)
        {

        }

        private void firstMenu5_Load(object sender, EventArgs e)
        {

        }
    }
}
