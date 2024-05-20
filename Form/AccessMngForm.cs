using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StandaloneSDKDemo
{
    public partial class AccessMngForm : Form
    {
        string connectionString;

        public AccessMngForm(Main Parent)
        {
            InitializeComponent();
            AccesccMng = Parent;
            connectionString = AccesccMng.connectionString;
            loadUsers("");
        }

        private void loadUsers(string text)
        {
            userList.Items.Clear();
            string query = "";
            try
            {
                // SQL query to retrieve entries from the table
                if(text == "")
                {
                    query = "SELECT regNo, Name FROM user";
                }
                else
                {
                    query = $"SELECT regNo, Name FROM user WHERE Name LIKE '%{text}%' OR regNo LIKE '%{text}%'";
                }
                // Create connection and command
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Open connection
                        connection.Open();

                        // Execute the query and fill a DataTable
                        DataTable dataTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Populate the ComboBox with entries from the DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            userList.Items.Add(row["regNo"].ToString() + "," +row["Name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                ZKMessgeBox.Show("An error occurred: " + ex.Message);
            }
        }

        private Main AccesccMng;


        #region TimeZone
        //Get TimeZone infomation by TimeZone ID
        private void btnACGetTZInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_GetTZInfo(AccesccMng.lbSysOutputInfo, txtTZIndex, dtSUNs, dtMONs, dtTUEs, dtWENs, dtTHUs, dtFRIs, dtSTAs, dtSUNe, dtMONe, dtTUEe, dtWENe, dtTHUe, dtFRIe, dtSTAe);

            Cursor = Cursors.Default;
        }

        private void btnACSetTZInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_SetTZInfo(AccesccMng.lbSysOutputInfo, txtTZIndex, dtSUNs, dtMONs, dtTUEs, dtWENs, dtTHUs, dtFRIs, dtSTAs, dtSUNe, dtMONe, dtTUEe, dtWENe, dtTHUe, dtFRIe, dtSTAe);

            Cursor = Cursors.Default;
        }
        #endregion

        #region GroupTimeSchedule
        private void btnACSSR_GetGroupTZ_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_GetGroupTZ(AccesccMng.lbSysOutputInfo, txtACGroupNo, txtTZIndex1, txtTZIndex2, txtTZIndex3, cboACValidHoliday, cbVerifyStyle);

            Cursor = Cursors.Default;
        }

        private void btnACSSR_SetGroupTZ_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_SetGroupTZ(AccesccMng.lbSysOutputInfo, txtACGroupNo, txtTZIndex1, txtTZIndex2, txtTZIndex3, cboACValidHoliday, cbVerifyStyle);

            Cursor = Cursors.Default;
        }
        #endregion

        #region UnlockGroup info. Set and Get
        //Get the unlock groups combination information.
        private void btnACSSR_GetUnLockGroup_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_GetUnLockGroup(AccesccMng.lbSysOutputInfo, cboACComNo, cboACGroup1, cboACGroup2, cboACGroup3, cboACGroup4, cboACGroup5);

            Cursor = Cursors.Default;
        }

        private void btnACSSR_SetUnLockGroup_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_SetUnLockGroup(AccesccMng.lbSysOutputInfo, cboACComNo, cboACGroup1, cboACGroup2, cboACGroup3, cboACGroup4, cboACGroup5);

            Cursor = Cursors.Default;
        }
        #endregion

        #region UserGroup
        private void btnUASetUserGroup_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_SetUserGroup(AccesccMng.lbSysOutputInfo, cboUAUserIDGroup, txtGroupNo1);

            Cursor = Cursors.Default;
        }

        private void btnUAGetUserGroup_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_GetUserGroup(AccesccMng.lbSysOutputInfo, cboUAUserIDGroup, txtGroupNo1);

            Cursor = Cursors.Default;
        }
        #endregion

        #region UserTimeZone
        private void btnUASetUserTZStr_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_SetUserTZStr(AccesccMng.lbSysOutputInfo, cboUAUserIDTZ, cbUserTZtype, txtUTZIndex1, txtUTZIndex2, txtUTZIndex3);

            Cursor = Cursors.Default;
        }

        private void btnUAGetUserTZStr_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_GetUserTZStr(AccesccMng.lbSysOutputInfo, cboUAUserIDTZ, cbUserTZtype, txtUTZIndex1, txtUTZIndex2, txtUTZIndex3);

            Cursor = Cursors.Default;
        }

        private void btnUAUseGroupTimeZone_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_UseGroupTimeZone(AccesccMng.lbSysOutputInfo, cboUAUserIDTZ, lbUserTimezoneType);

            Cursor = Cursors.Default;
        }
        #endregion

        #region UserIDTimer,not the stander interface on SDK.
        private void UserIDTimer_Tick(object sender, EventArgs e)
        {
            UserIDTimer.Enabled = false;
            dataGridView1.Rows.Clear();
            while (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns.RemoveAt(0);
            }
            // Add a new DataGridViewButtonColumn
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Pass"; // Set the header text (optional)
            buttonColumn.Text = "Print Pass"; // Set the button text
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.FlatStyle = FlatStyle.Popup; // Set button style
            buttonColumn.DefaultCellStyle.ForeColor = Color.Black; // Set font color

            // Add columns to the DataGridView
            dataGridView1.Columns.Add("GuestID", "GuestID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Contact", "Contact");
            dataGridView1.Columns.Add("CNIC", "CNIC");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("VisiteeName", "Visitee Name");
            dataGridView1.Columns.Add("VisiteeID", "Visitee ID");
            dataGridView1.Columns.Add("Relation", "Relation");
            dataGridView1.Columns.Add("SDate", "Start Date");
            dataGridView1.Columns.Add("EDate", "End Date");
            // ...
            
            //dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            string query = @"SELECT * FROM GUEST";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = reader[i].ToString() });
                            }                           
                            row.Cells.Add(new DataGridViewButtonCell());
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
                
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //// Check if the cell belongs to the button column
            //if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            //{
            //    // Access the cell
            //    DataGridViewButtonCell buttonCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

            //    // Customize the button properties
            //    buttonCell.Value = "Print"; // Set the text displayed on the button
            //    buttonCell.FlatStyle = FlatStyle.Popup; // Set the flat style of the button
            //    buttonCell.Style.BackColor = Color.Blue; // Set the background color of the button
            //    buttonCell.Style.ForeColor = Color.White; // Set the text color of the button
            //}
        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button
            try
            {
                if (true && e.RowIndex >= 0)
                {
                    // Get the values of the other columns in the same row
                    object column1ValueObj = dataGridView1.Rows[e.RowIndex].Cells["VisiteeID"].Value;
                    object column2ValueObj = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value;
                    object column3ValueObj = dataGridView1.Rows[e.RowIndex].Cells["Contact"].Value;
                    object column4ValueObj = dataGridView1.Rows[e.RowIndex].Cells["CNIC"].Value;
                    object column5ValueObj = dataGridView1.Rows[e.RowIndex].Cells["SDate"].Value;
                    object column6ValueObj = dataGridView1.Rows[e.RowIndex].Cells["EDate"].Value;

                    // Check if the cell values are not null before calling ToString()
                    string visiteeId = column1ValueObj != null ? column1ValueObj.ToString() : "null";
                    string Name = column2ValueObj != null ? column2ValueObj.ToString() : "null";
                    string Contact = column3ValueObj != null ? column3ValueObj.ToString() : "null";
                    string CNIC = column4ValueObj != null ? column4ValueObj.ToString() : "null";
                    string SDate = column5ValueObj != null ? column5ValueObj.ToString() : "null";
                    string EDate = column6ValueObj != null ? column6ValueObj.ToString() : "null";

                    string visiteeName = "", visiteeCnic = "", visiteeContact = "";
                    try
                    {
                        // SQL query to retrieve entries from the table
                        string querys = $"SELECT * FROM user where userID == {visiteeId};";
                        // Create connection and command
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            using (MySqlCommand command = new MySqlCommand(querys, connection))
                            {
                                // Open connection
                                connection.Open();
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        // Get the values of the 'userID' and 'Name' columns
                                        visiteeCnic = reader.IsDBNull(reader.GetOrdinal("cnic")) ? "" : reader.GetString(reader.GetOrdinal("cnic"));
                                        visiteeName = reader.IsDBNull(reader.GetOrdinal("Name")) ? "" : reader.GetString(reader.GetOrdinal("Name"));
                                        visiteeContact = reader.IsDBNull(reader.GetOrdinal("Hostel")) ? "" : reader.GetString(reader.GetOrdinal("Hostel"));

                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                        ZKMessgeBox.Show("An error occurred: " + ex.Message);
                    }

                    // Instantiate the form for printing
                    PersonalizeMngForm print = new PersonalizeMngForm(Name, Contact, CNIC, visiteeName, visiteeContact, visiteeCnic, SDate, EDate);
                    print.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ZKMessgeBox.Show("An error occurred: " + ex.Message);
            }
        }

        #endregion

        #region Parameter
        private void btnACUnlock_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_ACUnlock(AccesccMng.lbSysOutputInfo, txtDelay);

            Cursor = Cursors.Default;
        }

        private void btnCloseAlarm_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_CloseAlarm(AccesccMng.lbSysOutputInfo);

            Cursor = Cursors.Default;
        }

        private void btnSetHoliday_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_SetHoliday(AccesccMng.lbSysOutputInfo, txtHolidayId, dtStartDate, dtEndDate, txtTimeZoneId);

            Cursor = Cursors.Default;
        }

        private void btnGetHoliday_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = AccesccMng.SDK.sta_GetHoliday(AccesccMng.lbSysOutputInfo, txtHolidayId, dtStartDate, dtEndDate, txtTimeZoneId);

            Cursor = Cursors.Default;
        }

        private void btnGetNOTimeZone_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;

            int iGetNo = 81;
            int ret = AccesccMng.SDK.sta_GetNONCTimeZone(AccesccMng.lbSysOutputInfo, iGetNo, txtGetNoTZ);

            Cursor = Cursors.Default;
        }

        private void btnSetNOTimeZone_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int iSetNo = 81;
            int ret = AccesccMng.SDK.sta_SetNONCTimeZone(AccesccMng.lbSysOutputInfo, iSetNo, txtSetNoTZ);

            Cursor = Cursors.Default;
        }

        private void btnGetNCTimeZone_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int iGetNC = 80;
            int ret = AccesccMng.SDK.sta_GetNONCTimeZone(AccesccMng.lbSysOutputInfo, iGetNC, txtGetNcTZ);

            Cursor = Cursors.Default;
        }

        private void btnSetNCTimeZone_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int iSetNC = 80;
            int ret = AccesccMng.SDK.sta_SetNONCTimeZone(AccesccMng.lbSysOutputInfo, iSetNC, txtSetNcTZ);

            Cursor = Cursors.Default;
        }
        #endregion

        #region idk

        private void txtDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtACGroupNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboACGroup1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboACGroup2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboACGroup3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboACGroup4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboACGroup5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHolidayId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTimeZoneId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboUAUserGrp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTZIndex1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTZIndex2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTZIndex3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGroupNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSetNoTZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSetNcTZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTZIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUTZIndex1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUTZIndex2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUTZIndex3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        private void btn_delAttLog_Click(object sender, EventArgs e)
        {



            if (namebox.Text == "" || contactbox.Text == "" || addressbox.Text == "" || cnicbox.Text == "" || relation.Text == "" || userList.SelectedItem == null)
            {
                ZKMessgeBox.Show("Please Select All Fields First !");
                return;
            }

            string[] vistee = userList.SelectedItem.ToString().Split(',');
            




            string query = @"INSERT INTO Guest (Name, Contact, CNIC, Address, VisiteeName, VisiteeID, Relation, StartDate, EndDate) 
                         VALUES (@Name, @Contact, @CNIC, @Address, @VisiteeName, @VisiteeID, @Relation, @StartDate, @EndDate)";

            // Create connection and command
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Name", namebox.Text);
                    command.Parameters.AddWithValue("@Contact", contactbox.Text);
                    command.Parameters.AddWithValue("@CNIC", cnicbox.Text);
                    command.Parameters.AddWithValue("@Address", addressbox.Text);
                    command.Parameters.AddWithValue("@VisiteeName", vistee[1]);
                    command.Parameters.AddWithValue("@VisiteeID", vistee[0]);
                    command.Parameters.AddWithValue("@Relation", relation.Text);
                    command.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value.Date);
                    command.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value.Date);

                    try
                    {
                        // Open connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            ZKMessgeBox.Show("Guest Added Successfully!");
                            UserIDTimer.Enabled = true;
                        }
                        else
                        {
                            Console.WriteLine("No rows inserted.");
                        }
                    button1.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                        ZKMessgeBox.Show($"Error Occured {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(namebox.Text == "" ||  contactbox.Text == "" ||  addressbox.Text == "" || cnicbox.Text == "" || relation.Text == "" || userList.SelectedItem == null)
            {
                ZKMessgeBox.Show("Please Select All Fields First !");
                return;
            }
            string[] vistee = userList.SelectedItem.ToString().Split(',');
            string visiteeName = "", visiteeCnic = "", visiteeContact = "";
            try
            {
                // SQL query to retrieve entries from the table
                string querys = $"SELECT * FROM user where regNo == '{vistee[0]}';";
                // Create connection and command
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(querys, connection))
                    {
                        // Open connection
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Get the values of the 'userID' and 'Name' columns
                                visiteeCnic = reader.GetString(reader.GetOrdinal("cnic"));
                                visiteeName = reader.GetString(reader.GetOrdinal("Name"));
                                visiteeContact = reader.GetString(reader.GetOrdinal("Hostel"));

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                ZKMessgeBox.Show("An error occurred: " + ex.Message);
            }


            PersonalizeMngForm print = new PersonalizeMngForm(namebox.Text, contactbox.Text, cnicbox.Text, visiteeName, visiteeContact, visiteeCnic, dateTimePicker1.Value.ToString("dd-MM-yyyy"), dateTimePicker2.Value.ToString("dd-MM-yyyy"));
            print.ShowDialog();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();

            // If searchValue is empty, show all data
            if (string.IsNullOrEmpty(searchValue))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Iterate through DataGridView rows to filter based on searchValue
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the row is not a new row
                if (!row.IsNewRow)
                {
                    // Check if the DataGridView is in edit mode and the current row is the one being edited
                    if (dataGridView1.IsCurrentRowDirty && row.Index == dataGridView1.CurrentCell.RowIndex)
                    {
                        // Skip toggling visibility for the row being edited
                        continue;
                    }

                    // Check if the cell value matches the search value
                    if (row.Cells["VisiteeId"].Value != null && row.Cells["VisiteeId"].Value.ToString() == searchValue)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox2.Text.Trim();

            // If searchValue is empty, show all data
            if (string.IsNullOrEmpty(searchValue))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Iterate through DataGridView rows to filter based on searchValue
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the row is not a new row
                if (!row.IsNewRow)
                {
                    // Check if the DataGridView is in edit mode and the current row is the one being edited
                    if (dataGridView1.IsCurrentRowDirty && row.Index == dataGridView1.CurrentCell.RowIndex)
                    {
                        // Skip toggling visibility for the row being edited
                        continue;
                    }

                    // Check if the cell value matches the search value
                    if (row.Cells["VisiteeName"].Value != null && row.Cells["VisiteeName"].Value.ToString().Contains(searchValue))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void AccessMngForm_Load(object sender, EventArgs e)
        {

        }

        private void userList_TextChanged(object sender, EventArgs e)
        {
            if (userList.SelectedIndex == -1)
            {

                string searchText = userList.Text.ToLower();

                // Clear the current items in the ComboBox
                userList.Items.Clear();

                // Reload data from the database and filter based on the search text
                loadUsers(searchText);

                // Show the dropdown list
                userList.DroppedDown = true;

                // Set the selection to the end of the text
                userList.SelectionStart = userList.Text.Length;
            }
        }
    }
}
