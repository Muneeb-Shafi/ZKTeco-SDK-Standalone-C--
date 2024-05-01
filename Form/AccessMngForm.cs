﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        public AccessMngForm(Main Parent)
        {
            InitializeComponent();
            AccesccMng = Parent;
            loadUsers();
        }

        private void loadUsers()
        {
            userList.Items.Clear();
            try
            {
                // SQL query to retrieve entries from the table
                string query = "SELECT userID, Name FROM user";
                var connectionString = "Data Source=ZKTeco.db";
                // Create connection and command
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Open connection
                        connection.Open();

                        // Execute the query and fill a DataTable
                        DataTable dataTable = new DataTable();
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Populate the ComboBox with entries from the DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            userList.Items.Add(row["userID"].ToString() + "-" +row["Name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
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
            AccesccMng.SDK.sta_UserIDTimer(false, cboUAUserIDGroup, cboUAUserIDTZ);
        }

        private void RefreshUserIDMenuItem_Click(object sender, EventArgs e)
        {
            AccesccMng.SDK.sta_UserIDTimer(true, cboUAUserIDGroup, cboUAUserIDTZ);
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

        private void btn_delAttLog_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=ZKTeco.db";

            string query = @"INSERT INTO Guest (Name, Contact, CNIC, Address, VisiteeName, VisiteeID, Relation, StartDate, EndDate) 
                         VALUES (@Name, @Contact, @CNIC, @Address, @VisiteeName, @VisiteeID, @Relation, @StartDate, @EndDate)";

            // Create connection and command
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string[] vistee = userList.SelectedItem.ToString().Split('-');
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
                            Console.WriteLine("Data inserted successfully.");
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
                        MessageBox.Show($"Error Occured {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
