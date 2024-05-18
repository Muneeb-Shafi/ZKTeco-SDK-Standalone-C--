﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Reflection;
using CsvHelper;
using System.Data.SqlClient;
using System.Globalization;
using System.Xml.Linq;
using MySql.Data.MySqlClient;


namespace StandaloneSDKDemo
{
    public delegate void MessageEvent(string message);
    public partial class UserMngForm : Form
    {
        public UserMngForm(Main Parent)
        {
            InitializeComponent();
            UserMng = Parent;
            connectionString = Parent.connectionString;
            UserMng.SDK.biometricTypes.Add("General");
            UserMng.SDK.biometricTypes.Add("Finger Printer");
            UserMng.SDK.biometricTypes.Add("Face");
            UserMng.SDK.biometricTypes.Add("Voiceprint");
            UserMng.SDK.biometricTypes.Add("Iris");
            UserMng.SDK.biometricTypes.Add("Retina");
            UserMng.SDK.biometricTypes.Add("Palm prints");
            UserMng.SDK.biometricTypes.Add("FingerVein");
            UserMng.SDK.biometricTypes.Add("Palm Vein");
            SDKHelper.onMessage += SDKHelper_onMessage;
            //groupBox3.Enabled = false;

        }

        public string connectionString;
        public UserMngForm()
        {
            InitializeComponent();
            SDKHelper.onMessage += SDKHelper_onMessage;
        }

        private Main UserMng;
        void SDKHelper_onMessage(string msg)
        {
            if (!string.IsNullOrEmpty(msg))
            {
                UserMng.SDK.sta_GetAllUserID(true, cbUserID, cbUserID1, cbUserID2, cbUserID3, cbUserID4, txtID2, cbUserID7);
            }
        }

        #region UserInfo

        private void btnDeleteEnrollData_Click(object sender, EventArgs e)
        {

        }

        private void btnDelUserTmp_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_DelUserTmp(UserMng.lbSysOutputInfo, cbUserID3, cbFingerIndex1);

            Cursor = Cursors.Default;
        }

        private void btnSetUserInfo_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cnictext.Text == "" || degreetext.Text == "" || cbPrivilege.Text.Trim() == "")
            {
                return;
            }

            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_SetUserInfo(UserMng.lbSysOutputInfo, txtUserID1, txtName, cbPrivilege, txtCardnumber, txtPassword);
            UserMng.SDK.sta_GetAllUserID(true, cbUserID, cbUserID1, cbUserID2, cbUserID3, cbUserID4, txtID2, cbUserID7);

            var connectionString = "Data Source=ZKTeco.db";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Create a table if it doesn't exist
                var insertDataQuery = @"INSERT INTO user (userID, regNo, Name, cnic, Hostel, Degree) 
                            VALUES (@userID, @regNo, @Name, @cnic, @Hostel, @Degree);";

                using (var command = new MySqlCommand(insertDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@userID", txtUserID1.Text);
                    command.Parameters.AddWithValue("@regNo", txtUserID.Text);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@cnic", cnictext.Text);
                    command.Parameters.AddWithValue("@Hostel", hosteltext.Text);
                    command.Parameters.AddWithValue("@Degree", degreetext.Text);

                    command.ExecuteNonQuery();
                }
            }

            Cursor = Cursors.Default;



        }

        private void btnStartEnroll_Click(object sender, EventArgs e)
        {

        }

        private void btnGetHIDEventCardNumAsStr_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_GetHIDEventCardNum(UserMng.lbSysOutputInfo);

            Cursor = Cursors.Default;
        }

        private void btnSetVD_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_SetUserValidDate(UserMng.lbSysOutputInfo, cbExpires, txtID2, dtStartDate, dtEndDate, txtCount);
            Cursor = Cursors.Default;
        }

        private void btnGetVD_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_GetUserValidDate(UserMng.lbSysOutputInfo, cbExpires, txtID2, dtStartDate, dtEndDate, txtCount);

            Cursor = Cursors.Default;
        }

        private void btGetUserVerifyStyle_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_GetUserVerifyStyle(UserMng.lbSysOutputInfo, cbUserID7, cbVerifyStyle);

            Cursor = Cursors.Default;
        }

        private void btSetUserVerifyStyl_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_SetUserVerifyStyle(UserMng.lbSysOutputInfo, cbUserID7, cbVerifyStyle);

            Cursor = Cursors.Default;
        }


        private void RefreshUserIDMenuItem_Click(object sender, EventArgs e)
        {
            UserMng.SDK.sta_GetAllUserID(true, cbUserID, cbUserID1, cbUserID2, cbUserID3, cbUserID4, txtID2, cbUserID7);

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCardnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region UserFP
        private void btnGetAllUserFPInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = UserMng.SDK.sta_GetAllUserFPInfo(UserMng.lbSysOutputInfo, UserMng.PrgSTA, lvUserInfo);

            Cursor = Cursors.Default;
        }

        public void btnSetAllUserFPInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (cbBatchUpload.Checked)
            {
                UserMng.SDK.sta_batch_SetAllUserFPInfo(UserMng.lbSysOutputInfo, UserMng.PrgSTA, lvUserInfo);
            }
            else
            {
                UserMng.SDK.sta_SetAllUserFPInfo(UserMng.lbSysOutputInfo, UserMng.PrgSTA, lvUserInfo);
            }

            Cursor = Cursors.Default;
        }
        #endregion

        #region UserFace
        public void btnGetAllUserFaceInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = UserMng.SDK.sta_GetAllUserFaceInfo(UserMng.lbSysOutputInfo, UserMng.PrgSTA, listUserInfo);

            Cursor = Cursors.Default;
        }

        public void btnSetAllUserFaceInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = UserMng.SDK.sta_SetAllUserFaceInfo(UserMng.lbSysOutputInfo, UserMng.PrgSTA, listUserInfo);

            Cursor = Cursors.Default;
        }
        #endregion

        #region UserPhoto
        private void btnGetAllUserPhoto_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_DownloadAllUserPhoto(UserMng.lbSysOutputInfo, txtAllPhotoPath);

            Cursor = Cursors.Default;
        }


        private void btnUploadAllUserPhoto_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_UploadAllUserPhoto(UserMng.lbSysOutputInfo, txtAllPhotoPath);

            Cursor = Cursors.Default;
        }

        private void btnUploadOneUserPhoto_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (tbGetPhotoPath.Text.Trim() == "")
            {
                UserMng.lbSysOutputInfo.Items.Add("*Select photo first");
                Cursor = Cursors.Default;
                return;
            }

            if (cbUserID4.Text.Trim() == "")
            {
                UserMng.lbSysOutputInfo.Items.Add("*Select User ID first");
                Cursor = Cursors.Default;
                return;
            }

            string fullName = this.tbGetPhotoPath.Text.Trim() + this.cbUserID4.Text.Trim() + ".jpg";
            if (getUserPhotoByID(fullName))
            {
                this.pictureBox2.Image = GetImageFile(fullName);
            }
            else
            {
                UserMng.lbSysOutputInfo.Items.Add("*User ID " + this.cbUserID4.Text.Trim() + " has no photo in this folder.");
                Cursor = Cursors.Default;
                return;
            }

            UserMng.SDK.sta_uploadOneUserPhoto(UserMng.lbSysOutputInfo, fullName);

            Cursor = Cursors.Default;
        }

        private void btnDownloadOneUserPhoto_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_downloadOneUserPhoto(UserMng.lbSysOutputInfo, this.cbUserID4.Text.Trim(), this.tbGetPhotoPath.Text.Trim());

            Cursor = Cursors.Default;
        }

        private void btnDeleteOneUserPhoto_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_DeleteOneUserPhoto(UserMng.lbSysOutputInfo, this.cbUserID4.Text.Trim());

            Cursor = Cursors.Default;
        }

        private void btnPhotopath1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (DialogResult.OK == fbd.ShowDialog())
            {
                txtAllPhotoPath.Text = fbd.SelectedPath;

                if (!fbd.SelectedPath.EndsWith("\\"))
                {
                    txtAllPhotoPath.Text += "\\";
                }

            }
        }

        private void btnPhotopath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (DialogResult.OK == fbd.ShowDialog())
            {
                tbGetPhotoPath.Text = fbd.SelectedPath;

                if (!fbd.SelectedPath.EndsWith("\\"))
                {
                    tbGetPhotoPath.Text += "\\";
                }
            }
        }

        private MemoryStream ReadFile(string path)
        {
            if (!File.Exists(path))
                return null;

            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                byte[] b = new byte[file.Length];
                file.Read(b, 0, b.Length);

                MemoryStream stream = new MemoryStream(b);
                return stream;
            }
        }

        private Image GetImageFile(string path)
        {
            MemoryStream stream = ReadFile(path);
            return stream == null ? null : Image.FromStream(stream);
        }

        private bool getUserPhotoByID(string photoName)
        {
            DirectoryInfo directory = new DirectoryInfo(this.tbGetPhotoPath.Text.Trim());

            if (directory.Exists)
            {
                foreach (FileInfo info in directory.GetFiles())
                {
                    if (info.FullName.ToString() == photoName)
                        return true;
                }
            }

            return false;
        }

        private void cbUserID4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tbGetPhotoPath.Text.Trim() == "" || this.cbUserID4.Text.Trim() == "")
            {
                return;
            }

            string fullName = this.tbGetPhotoPath.Text.Trim() + this.cbUserID4.Text.Trim() + ".jpg";
            if (getUserPhotoByID(fullName))
            {
                this.pictureBox2.Image = GetImageFile(fullName);
            }
            else
            {
                this.pictureBox2.Image = null;
            }
        }
        #endregion

        #region SMS
        private void btnSetSMS_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_SetSMS(UserMng.lbSysOutputInfo, txtSMSID, cbTag, txtValidMins, dtStartTime, txtContent);

            Cursor = Cursors.Default;
        }

        private void btnGetSMS_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_GetSMS(UserMng.lbSysOutputInfo, txtSMSID, cbTag, txtValidMins, dtStartTime, txtContent);

            Cursor = Cursors.Default;
        }

        private void btnSetUserSMS_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_SetUserSMS(UserMng.lbSysOutputInfo, txtSMSID1, cbUserID);

            Cursor = Cursors.Default;
        }

        private void btnDeleteSMS_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_DelSMS(UserMng.lbSysOutputInfo, txtSMSID2);

            Cursor = Cursors.Default;
        }

        private void btnDeleteUserSMS_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_DelUserSMS(UserMng.lbSysOutputInfo, txtSMSID2, cbUserID1);

            Cursor = Cursors.Default;
        }

        private void btnClearSMS_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_ClearSMS(UserMng.lbSysOutputInfo);

            Cursor = Cursors.Default;
        }

        private void btnClearUserSMS_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_ClearUserSMS(UserMng.lbSysOutputInfo);

            Cursor = Cursors.Default;
        }

        private void txtSMSID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValidMins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSMSID1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSMSID2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Workcode
        private void btnSetWorkCode_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_SetWorkCode(UserMng.lbSysOutputInfo, txtWorkcodeID, txtWorkcodeName);

            Cursor = Cursors.Default;
        }

        private void btnGetWorkCode_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_GetWorkCode(UserMng.lbSysOutputInfo, txtWorkcodeID, txtWorkcodeName);

            Cursor = Cursors.Default;
        }

        private void btnDeleteWorkCode_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_DelWorkCode(UserMng.lbSysOutputInfo, txtWorkcodeID);

            Cursor = Cursors.Default;
        }

        private void btnClearWorkCode_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_ClearWorkCode(UserMng.lbSysOutputInfo);

            Cursor = Cursors.Default;
        }

        private void txtWorkcodeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWorkcodeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ' ' || char.IsLetter(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        #endregion

        #region userrole

        private void clbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";

            str = clbMenu.SelectedItem.ToString();

            if (string.Compare(str, "User Mgt") == 0)
            {
                clbUserMgt.Enabled = true;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = true;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "Access Control") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = true;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false ;
                clbAccessControl.Visible = true ;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "IC Card") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = true;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false ;
                clbICCard.Visible = true;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "Comm") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = true;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = true ;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "System") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = true;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false ;
                clbSystem.Visible = true ;
                clbPersonalize.Visible = false;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "Personalize") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = true;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false ;
                clbPersonalize.Visible = true ;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "Data Mgt") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = true;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false ;
                clbDataMgt.Visible = true ;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "USB Manager") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = true;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false ;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = true;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "Attendance Search") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = true;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false ;
                clbDataMgt.Visible = false  ;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = true ;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "Print") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = true;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false ;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = true ;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "Short Message") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = true;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false ;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = true ;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "Work Code") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = true;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false ;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = true ;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "Auto Test") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = true;
                clbSysInfo.Enabled = false;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false ;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = true ;
                clbSysInfo.Visible = false;
                */
            }
            else if (string.Compare(str, "System Info") == 0)
            {
                clbUserMgt.Enabled = false;
                clbAccessControl.Enabled = false;
                clbICCard.Enabled = false;
                clbComm.Enabled = false;
                clbSystem.Enabled = false;
                clbPersonalize.Enabled = false;
                clbDataMgt.Enabled = false;
                clbUSBManager.Enabled = false;
                clbAttendanceSearch.Enabled = false;
                clbPrint.Enabled = false;
                clbSMS.Enabled = false;
                clbWorkCode.Enabled = false;
                clbAutotest.Enabled = false;
                clbSysInfo.Enabled = true;
                /*
                clbUserMgt.Visible = false;
                clbAccessControl.Visible = false;
                clbICCard.Visible = false;
                clbComm.Visible = false;
                clbSystem.Visible = false;
                clbPersonalize.Visible = false ;
                clbDataMgt.Visible = false;
                clbUSBManager.Visible = false;
                clbAttendanceSearch.Visible = false;
                clbPrint.Visible = false;
                clbSMS.Visible = false;
                clbWorkCode.Visible = false;
                clbAutotest.Visible = false;
                clbSysInfo.Visible = true ;
                */
            }
        }

        private void clbMenu_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int idx = e.Index;
            //UserMng.lbSysOutputInfo.Items.Add(idx.ToString());
            switch (idx)
            {
                case 0:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbUserMgt.Items.Count; i++)
                            {

                                clbUserMgt.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbUserMgt.Items.Count; i++)
                            {

                                clbUserMgt.SetItemChecked(i, true);

                            }
                        }
                    }
                    break;
                case 1:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbAccessControl.Items.Count; i++)
                            {
                                clbAccessControl.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbAccessControl.Items.Count; i++)
                            {
                                clbAccessControl.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbICCard.Items.Count; i++)
                            {
                                clbICCard.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbICCard.Items.Count; i++)
                            {
                                clbICCard.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbComm.Items.Count; i++)
                            {
                                clbComm.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbComm.Items.Count; i++)
                            {
                                clbComm.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 4:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbSystem.Items.Count; i++)
                            {
                                clbSystem.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbSystem.Items.Count; i++)
                            {
                                clbSystem.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 5:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbPersonalize.Items.Count; i++)
                            {
                                clbPersonalize.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbPersonalize.Items.Count; i++)
                            {
                                clbPersonalize.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 6:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbDataMgt.Items.Count; i++)
                            {
                                clbDataMgt.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbDataMgt.Items.Count; i++)
                            {
                                clbDataMgt.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 7:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbUSBManager.Items.Count; i++)
                            {
                                clbUSBManager.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbUSBManager.Items.Count; i++)
                            {
                                clbUSBManager.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 8:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbAttendanceSearch.Items.Count; i++)
                            {
                                clbAttendanceSearch.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbAttendanceSearch.Items.Count; i++)
                            {
                                clbAttendanceSearch.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 9:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbPrint.Items.Count; i++)
                            {
                                clbPrint.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbPrint.Items.Count; i++)
                            {
                                clbPrint.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 10:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbSMS.Items.Count; i++)
                            {
                                clbSMS.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbSMS.Items.Count; i++)
                            {
                                clbSMS.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 11:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbWorkCode.Items.Count; i++)
                            {
                                clbWorkCode.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbWorkCode.Items.Count; i++)
                            {
                                clbWorkCode.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 12:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbAutotest.Items.Count; i++)
                            {
                                clbAutotest.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbAutotest.Items.Count; i++)
                            {
                                clbAutotest.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
                case 13:
                    {
                        if (clbMenu.GetItemChecked(idx))
                        {
                            for (int i = 0; i < clbSysInfo.Items.Count; i++)
                            {
                                clbSysInfo.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < clbSysInfo.Items.Count; i++)
                            {
                                clbSysInfo.SetItemChecked(i, true);
                            }
                        }
                    }
                    break;
            }
        }

        private void btnGetUserRole_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int[] iAppState = new int[14];
            int[] iFunUserMng = new int[3];
            int[] iFunAccess = new int[7];
            int[] iFunICCard = new int[5];
            int[] iFunComm = new int[7];
            int[] iFunSystem = new int[5];
            int[] iFunPersonalize = new int[6];
            int[] iFunDataMng = new int[3];
            int[] iFunUSBMng = new int[3];
            int[] iFunAttSearch = new int[3];
            int[] iFunPrint = new int[2];
            int[] iFunSMS = new int[2];
            int[] iFunWorkCode = new int[3];
            int[] iFunAutoTest = new int[7];
            int[] iFunSysInfo = new int[3];
            int i = 0;


            int ret = UserMng.SDK.sta_GetUserRole(UserMng.lbSysOutputInfo, cbUserRole, iAppState, iFunUserMng, iFunAccess, iFunICCard, iFunComm, iFunSystem, iFunPersonalize, iFunDataMng, iFunUSBMng, iFunAttSearch, iFunPrint, iFunSMS, iFunWorkCode, iFunAutoTest, iFunSysInfo);

            if (ret < 0)
            {
                Cursor = Cursors.Default;
                return;
            }

            for (i = 0; i < iAppState.Length; i++)
            {
                if (iAppState[i] == 1)
                {
                    clbMenu.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbMenu.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunUserMng.Length; i++)
            {
                if (iFunUserMng[i] == 1)
                {
                    clbUserMgt.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbUserMgt.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunAccess.Length; i++)
            {
                if (iFunAccess[i] == 1)
                {
                    clbAccessControl.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbAccessControl.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunICCard.Length; i++)
            {
                if (iFunICCard[i] == 1)
                {
                    clbICCard.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbICCard.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunComm.Length; i++)
            {
                if (iFunComm[i] == 1)
                {
                    clbComm.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbComm.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunSystem.Length; i++)
            {
                if (iFunSystem[i] == 1)
                {
                    clbSystem.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbSystem.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunPersonalize.Length; i++)
            {
                if (iFunPersonalize[i] == 1)
                {
                    clbPersonalize.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbPersonalize.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunDataMng.Length; i++)
            {
                if (iFunDataMng[i] == 1)
                {
                    clbDataMgt.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbDataMgt.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunUSBMng.Length; i++)
            {
                if (iFunUSBMng[i] == 1)
                {
                    clbUSBManager.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbUSBManager.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunAttSearch.Length; i++)
            {
                if (iFunAttSearch[i] == 1)
                {
                    clbAttendanceSearch.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbAttendanceSearch.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunPrint.Length; i++)
            {
                if (iFunPrint[i] == 1)
                {
                    clbPrint.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbPrint.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunSMS.Length; i++)
            {
                if (iFunSMS[i] == 1)
                {
                    clbSMS.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbSMS.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunWorkCode.Length; i++)
            {
                if (iFunWorkCode[i] == 1)
                {
                    clbWorkCode.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbWorkCode.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunAutoTest.Length; i++)
            {
                if (iFunAutoTest[i] == 1)
                {
                    clbAutotest.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbAutotest.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (i = 0; i < iFunSysInfo.Length; i++)
            {
                if (iFunSysInfo[i] == 1)
                {
                    clbSysInfo.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    clbSysInfo.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            Cursor = Cursors.Default;
        }

        private void btnSetUserRole_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int[] iAppState = new int[14];
            int[] iFunUserMng = new int[3];
            int[] iFunAccess = new int[7];
            int[] iFunICCard = new int[5];
            int[] iFunComm = new int[7];
            int[] iFunSystem = new int[5];
            int[] iFunPersonalize = new int[6];
            int[] iFunDataMng = new int[3];
            int[] iFunUSBMng = new int[3];
            int[] iFunAttSearch = new int[3];
            int[] iFunPrint = new int[2];
            int[] iFunSMS = new int[2];
            int[] iFunWorkCode = new int[3];
            int[] iFunAutoTest = new int[7];
            int[] iFunSysInfo = new int[3];

            for (int i = 0; i < clbMenu.Items.Count; i++)
            {
                if (clbMenu.GetItemChecked(i))
                {
                    iAppState[i] = 1;
                }
                else
                {
                    iAppState[i] = 0;
                }
            }

            for (int i = 0; i < clbUserMgt.Items.Count; i++)
            {
                if (clbUserMgt.GetItemChecked(i))
                {
                    iFunUserMng[i] = 1;
                }
                else
                {
                    iFunUserMng[i] = 0;
                }
            }

            for (int i = 0; i < clbAccessControl.Items.Count; i++)
            {
                if (clbAccessControl.GetItemChecked(i))
                {
                    iFunAccess[i] = 1;
                }
                else
                {
                    iFunAccess[i] = 0;
                }
            }

            for (int i = 0; i < clbICCard.Items.Count; i++)
            {
                if (clbICCard.GetItemChecked(i))
                {
                    iFunICCard[i] = 1;
                }
                else
                {
                    iFunICCard[i] = 0;
                }
            }

            for (int i = 0; i < clbComm.Items.Count; i++)
            {
                if (clbComm.GetItemChecked(i))
                {
                    iFunComm[i] = 1;
                }
                else
                {
                    iFunComm[i] = 0;
                }
            }

            for (int i = 0; i < clbSystem.Items.Count; i++)
            {
                if (clbSystem.GetItemChecked(i))
                {
                    iFunSystem[i] = 1;
                }
                else
                {
                    iFunSystem[i] = 0;
                }
            }

            for (int i = 0; i < clbPersonalize.Items.Count; i++)
            {
                if (clbPersonalize.GetItemChecked(i))
                {
                    iFunPersonalize[i] = 1;
                }
                else
                {
                    iFunPersonalize[i] = 0;
                }
            }

            for (int i = 0; i < clbDataMgt.Items.Count; i++)
            {
                if (clbDataMgt.GetItemChecked(i))
                {
                    iFunDataMng[i] = 1;
                }
                else
                {
                    iFunDataMng[i] = 0;
                }
            }

            for (int i = 0; i < clbUSBManager.Items.Count; i++)
            {
                if (clbUSBManager.GetItemChecked(i))
                {
                    iFunUSBMng[i] = 1;
                }
                else
                {
                    iFunUSBMng[i] = 0;
                }
            }

            for (int i = 0; i < clbAttendanceSearch.Items.Count; i++)
            {
                if (clbAttendanceSearch.GetItemChecked(i))
                {
                    iFunAttSearch[i] = 1;
                }
                else
                {
                    iFunAttSearch[i] = 0;
                }
            }

            for (int i = 0; i < clbPrint.Items.Count; i++)
            {
                if (clbPrint.GetItemChecked(i))
                {
                    iFunPrint[i] = 1;
                }
                else
                {
                    iFunPrint[i] = 0;
                }
            }

            for (int i = 0; i < clbSMS.Items.Count; i++)
            {
                if (clbSMS.GetItemChecked(i))
                {
                    iFunSMS[i] = 1;
                }
                else
                {
                    iFunSMS[i] = 0;
                }
            }

            for (int i = 0; i < clbWorkCode.Items.Count; i++)
            {
                if (clbWorkCode.GetItemChecked(i))
                {
                    iFunWorkCode[i] = 1;
                }
                else
                {
                    iFunWorkCode[i] = 0;
                }
            }

            for (int i = 0; i < clbAutotest.Items.Count; i++)
            {
                if (clbAutotest.GetItemChecked(i))
                {
                    iFunAutoTest[i] = 1;
                }
                else
                {
                    iFunAutoTest[i] = 0;
                }
            }

            for (int i = 0; i < clbSysInfo.Items.Count; i++)
            {
                if (clbSysInfo.GetItemChecked(i))
                {
                    iFunSysInfo[i] = 1;
                }
                else
                {
                    iFunSysInfo[i] = 0;
                }
            }

            int ret = UserMng.SDK.sta_SetUserRole(UserMng.lbSysOutputInfo, cbUserRole, iAppState, iFunUserMng, iFunAccess, iFunICCard, iFunComm, iFunSystem, iFunPersonalize, iFunDataMng, iFunUSBMng, iFunAttSearch, iFunPrint, iFunSMS, iFunWorkCode, iFunAutoTest, iFunSysInfo);


            Cursor = Cursors.Default;
        }
        #endregion

        private void GetUserInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_GetUserInfo(UserMng.lbSysOutputInfo, txtUserID, txtName, cbPrivilege, txtCardnumber, txtPassword);

            Cursor = Cursors.Default;
        }

        #region UserBio

        //vs2008版本过低只能通过调用自己所写的接口实现string类的IsNullOrWhiteSpace
        public static bool IsNullOrWhiteSpace(string value)
        {
            if (value != null)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsWhiteSpace(value[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /*
                private void btnConnect_Click(object sender, EventArgs e)
                {
                    if (sdk == null) return;

                    if (Convert.ToInt32(btnConnect.Tag) == 0)
                    {
                        //Connect to device
                        string ip = txtIP.Text;
                        int port = Convert.ToInt32(txtPort.Text);
                        int commKey = 0;
                        if (!IsNullOrWhiteSpace(txtCommKey.Text)) commKey = Convert.ToInt32(txtCommKey.Text);

                        sdk.connectDevice(ip, port, commKey);

                        if (sdk.isConnected)
                        {
                            btnConnect.Tag = 1;
                            btnConnect.Text = "Disconnect";
                            cmbBiometricType.Items.Clear();
                            for (int i = 0; i < sdk.biometricType.Length; i++)
                            {
                                if (sdk.biometricType[i] == '1')
                                {
                                    cmbBiometricType.Items.Add(new BioType() { name = biometricTypes[i], value = i });
                                }
                            }
                        }
                    }
                    else
                    {
                        //Disconnect device
                        if (sdk.isConnected)
                        {
                            sdk.disconnectDevice();
                            btnConnect.Tag = 0;
                            btnConnect.Text = "Connect";
                            cmbBiometricType.Items.Clear();
                        }
                    }
                }
        */
        private void btnDownloadUser_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (UserMng.SDK == null) return;

            if (UserMng.SDK.GetConnectState())
            {
                cmbBiometricType.Items.Clear();
                for (int i = 0; i < UserMng.SDK.biometricType.Length; i++)
                {
                    if (UserMng.SDK.biometricType[i] == '1')
                    {
                        cmbBiometricType.Items.Add(new SDKHelper.BioType() { name = UserMng.SDK.biometricTypes[i], value = i });
                    }
                }
                UserMng.SDK.employeeList = UserMng.SDK.sta_getEmployees();

                lstUsers.Items.Clear();
                lstUsers.BeginUpdate();
                foreach (SDKHelper.Employee employee in UserMng.SDK.employeeList)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = employee.pin;
                    item.SubItems.Add(employee.name);
                    item.SubItems.Add(employee.password);
                    item.SubItems.Add(employee.privilege.ToString());
                    item.SubItems.Add(employee.cardNumber);
                    lstUsers.Items.Add(item);
                }
                lstUsers.EndUpdate();
                UserMng.PrgSTA.Value = 100;
                UserMng.lbSysOutputInfo.Items.Add("Download successfully");
            }
            Cursor = Cursors.Default;
        }

        private void btnDownloadBio_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int CountTemplate = 0;
            string strType = string.Empty;

            if (UserMng.SDK == null) return;
            if (UserMng.SDK.GetConnectState())
            {
                if (cmbBiometricType.SelectedItem != null)
                {
                    SDKHelper.BioType bioType = cmbBiometricType.SelectedItem as SDKHelper.BioType;
                    List<SDKHelper.BioTemplate> newTemplates = new List<SDKHelper.BioTemplate>();
                    newTemplates = UserMng.SDK.sta_BatchGetBioTemplates(UserMng.PrgSTA, bioType.value);
                    CountTemplate = newTemplates.Count;
                    lstBiometric.Items.Clear();

                    lstBiometric.BeginUpdate();
                    foreach (SDKHelper.BioTemplate template in newTemplates)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = template.pin;
                        item.SubItems.Add(template.valid_flag == 1 ? "Valid" : "Invalid");
                        item.SubItems.Add(template.is_duress == 0 ? "False" : "True");
                        strType = string.Empty;
                        switch (template.bio_type)
                        {
                            case 0:
                                strType = "General";
                                break;
                            case 1:
                                strType = "FP";
                                break;
                            case 2:
                                strType = "Face";
                                break;
                            case 7:
                                strType = "FingerVein";
                                break;
                            case 8:
                                strType = "Palm";
                                break;
                            default:
                                break;
                        }
                        item.SubItems.Add(strType);
                        item.SubItems.Add(template.version);
                        item.SubItems.Add(template.data_format == 0 ? "ZK" : "Other");
                        item.SubItems.Add(template.template_no.ToString());
                        item.SubItems.Add(template.template_no_index.ToString());
                        item.SubItems.Add(template.template_data);

                        lstBiometric.Items.Add(item);
                    }
                    lstBiometric.EndUpdate();

                    UserMng.SDK.bioTemplateList.AddRange(newTemplates);
                    UserMng.PrgSTA.Value = 100;
                    UserMng.lbSysOutputInfo.Items.Add("Downlaod  " + strType + " : " + CountTemplate);
                    UserMng.lbSysOutputInfo.Items.Add("Download successfully");
                }
            }
            Cursor = Cursors.Default;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //          UserMng.SDK.bioTemplateList.Clear();
            lstBiometric.Items.Clear();     //modify 2017/11/23
            Cursor = Cursors.Default;
        }

        private void btnUploadBio_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (UserMng.SDK != null && UserMng.SDK.GetConnectState())
            {
                string message = string.Empty;
                UserMng.SDK.sta_setBioTemplates(UserMng.SDK.bioTemplateList, out message);
                if (!IsNullOrWhiteSpace(message))
                {
                    UserMng.lbSysOutputInfo.Items.Add(message);
                }
                else
                {
                    UserMng.PrgSTA.Value = 100;
                    UserMng.lbSysOutputInfo.Items.Add("Upload successfully");
                }
            }
            Cursor = Cursors.Default;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (UserMng.SDK != null && UserMng.SDK.GetConnectState())
            {
                UserMng.SDK.sta_setEmployees(UserMng.SDK.employeeList);
                UserMng.PrgSTA.Value = 100;
                UserMng.lbSysOutputInfo.Items.Add("Upload successfully");
            }
            Cursor = Cursors.Default;
        }
        #endregion


        private void btnDeleteEnrollData_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (UserMng.SDK.sta_DeleteEnrollData(UserMng.lbSysOutputInfo, textBox1.Text, cbBackupDE) == 1)
            {

                var connectionString = "Data Source=ZKTeco.db";
                string query = "DELETE FROM user WHERE regNo = '@UserID'";
                string userIDToDelete = txtUserID1.Text;
                if (cbBackupDE.SelectedItem.ToString() == "12") {

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", userIDToDelete);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine($"Row with UserID '{userIDToDelete}' deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine($"No rows deleted for UserID '{userIDToDelete}'.");
                            }
                        }
                    }
                }
                query = "DELETE FROM Users WHERE userID = @UserID";

                userIDToDelete = txtUserID1.Text;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userIDToDelete);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Row with UserID '{userIDToDelete}' deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"No rows deleted for UserID '{userIDToDelete}'.");
                        }
                    }
                }
            }

            Cursor = Cursors.Default;
        }

        private void btnStartEnroll_Click_2(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;

            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_OnlineEnroll(UserMng.lbSysOutputInfo, txtUserID1, cbFingerIndex, cbFlag);


            Cursor = Cursors.Default;

            txtUserID.Text = txtUserID1.Text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var connectionString = "Data Source=ZKTeco.db";
            lvUserInfo.Items.Clear();
            int index = 0;
            bool enabled = false;
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Users";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userID = reader.GetInt32(reader.GetOrdinal("userID"));
                            int enable = reader.GetInt32(reader.GetOrdinal("Enable"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string cardNo = reader.GetString(reader.GetOrdinal("CardNo"));
                            string password = reader.GetString(reader.GetOrdinal("Password"));
                            int fingerIndex = reader.GetInt32(reader.GetOrdinal("FingerIndex"));
                            int? flag = reader.IsDBNull(reader.GetOrdinal("Flag")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("Flag"));
                            string fingerPrint = reader.IsDBNull(reader.GetOrdinal("FingerPrint"))
                                                ? null
                                                : reader.GetString(reader.GetOrdinal("FingerPrint"));
                            int? privilege = reader.IsDBNull(reader.GetOrdinal("Privilege")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("Privilege"));
                            lvUserInfo.Items.Add(userID.ToString());

                            if (enable == 1)
                            {
                                enabled = true;
                            }
                            else
                            {
                                enabled = false;
                            }
                            lvUserInfo.Items[index].SubItems.Add(enabled.ToString());
                            lvUserInfo.Items[index].SubItems.Add(name);
                            lvUserInfo.Items[index].SubItems.Add(cardNo);
                            lvUserInfo.Items[index].SubItems.Add(password);
                            lvUserInfo.Items[index].SubItems.Add(fingerIndex.ToString());
                            lvUserInfo.Items[index].SubItems.Add(flag.ToString());
                            lvUserInfo.Items[index].SubItems.Add(fingerPrint);
                            lvUserInfo.Items[index].SubItems.Add(privilege.ToString());
                            index++;
                        }
                    }
                }
                connection.Close();
            }
            Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvUserInfo.Items.Clear();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            listUserInfo.Items.Clear();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var connectionString = "Data Source=ZKTeco.db";
            listUserInfo.Items.Clear();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM facial";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userID = reader.GetString(reader.GetOrdinal("userID"));
                            int enable = reader.GetInt32(reader.GetOrdinal("Enable"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string password = reader.GetString(reader.GetOrdinal("Password"));
                            int? privilege = reader.IsDBNull(reader.GetOrdinal("iPrivilege")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("Privilege"));
                            int? length = reader.IsDBNull(reader.GetOrdinal("iLength")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("iLength"));
                            string face = reader.IsDBNull(reader.GetOrdinal("Face")) ? null : reader.GetString(reader.GetOrdinal("Face"));

                            ListViewItem item = new ListViewItem(userID);
                            item.SubItems.Add(enable == 1 ? "true" : "false");
                            item.SubItems.Add(name);
                            item.SubItems.Add(password);
                            item.SubItems.Add(privilege?.ToString());
                            item.SubItems.Add(length?.ToString());
                            item.SubItems.Add(face);

                            listUserInfo.Items.Add(item);
                            Console.WriteLine(item);
                        }

                    }
                }
                connection.Close();
            }
            Cursor = Cursors.Default;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void GetUserInfo_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserMng.SDK.sta_GetUserInfo(UserMng.lbSysOutputInfo, txtUserID, txtName, cbPrivilege, txtCardnumber, txtPassword);

            Cursor = Cursors.Default;

            groupBox3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int recs = 0;
            Cursor = Cursors.WaitCursor;
            if(textBox2.Text == "")
            {
                MessageBox.Show("Please Import File First");
                return;
            }
            var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null

            };
            try
            {
                using (var reader = new StreamReader(textBox2.Text))
                using (var csv = new CsvReader(reader, csvConfig))
                {
                    var records = csv.GetRecords<users>();

                    foreach (var user in records)
                    {
                        InsertIntoDatabase(user);
                        recs++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Cursor = Cursors.Default;
            MessageBox.Show($"{recs} records inserted");

            int index = 0;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string stm = "SELECT * FROM user";
                using (var cmd = new MySqlCommand(stm, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int userID = reader.GetInt32(reader.GetOrdinal("machineID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string cardNo = reader.GetString(reader.GetOrdinal("cnic"));
                            string hostel = reader.GetString(reader.GetOrdinal("Hostel"));
                            string degree = reader.GetString(reader.GetOrdinal("Degree"));
                            string regNo = reader.GetString(reader.GetOrdinal("regNo"));
                            string roomNo = reader.GetString(reader.GetOrdinal("RoomNo"));
                            int fpCheck = reader.GetInt32(reader.GetOrdinal("fp"));

                            listView1.Items.Add(userID.ToString());

                            listView1.Items[index].SubItems.Add(name);
                            listView1.Items[index].SubItems.Add(cardNo);
                            listView1.Items[index].SubItems.Add(hostel);
                            listView1.Items[index].SubItems.Add(degree);
                            listView1.Items[index].SubItems.Add(regNo);
                            listView1.Items[index].SubItems.Add(roomNo);
                            if(fpCheck == 0) {
                                listView1.Items[index].SubItems.Add("NotAvailable");
                            }
                            else if (fpCheck == 1)
                            {
                                listView1.Items[index].SubItems.Add("Available");
                            }

                            index++;
                        }

                    }
                }
            }
        }

        public void InsertIntoDatabase(users user)
        {
            if(user.CNIC == null || user.RegNo == null)
            {
                return;
            }
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO User (Name, cnic, Hostel, Degree, RegNo, RoomNo, fp) VALUES (@Name, @cnic, @Hostel, @Degree, @RegNo, @RoomNo, @fp)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@cnic", user.CNIC);
                        command.Parameters.AddWithValue("@Hostel", user.Hostel);
                        command.Parameters.AddWithValue("@Degree", user.Degree);
                        command.Parameters.AddWithValue("@RegNo", user.RegNo);
                        command.Parameters.AddWithValue("@RoomNo", user.RoomNo);
                        command.Parameters.AddWithValue("@fp", user.FPCheck);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }




        private void button6_Click(object sender, EventArgs e)
        {

            // Query to get the count of rows in the Users table
            string query = "SELECT COUNT(*) FROM user";

            // Variable to hold the count
            int rowCount = 0;

            // Create connection and command
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        rowCount = Convert.ToInt32(command.ExecuteScalar());
                        userCount.Text = rowCount.ToString();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage7 || e.TabPage == tabPage6 || e.TabPage == tabPage10 || e.TabPage == tabPage11)
            {
                e.Cancel = true;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UserMngForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            int index = 0;



            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string stm = "SELECT DISTINCT Hostel FROM user;";
                using (var cmd = new MySqlCommand(stm, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string hostel = reader.GetString(reader.GetOrdinal("Hostel"));
                            metroComboBox1.Items.Add(hostel);
                        }

                    }
                }
            }



            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string stm = "SELECT * FROM user";
                using (var cmd = new MySqlCommand(stm, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int userID = reader.GetInt32(reader.GetOrdinal("machineID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string cardNo = reader.GetString(reader.GetOrdinal("cnic"));
                            string hostel = reader.GetString(reader.GetOrdinal("Hostel"));
                            string degree = reader.GetString(reader.GetOrdinal("Degree"));
                            string regNo = reader.GetString(reader.GetOrdinal("regNo"));
                            string roomNo = reader.GetString(reader.GetOrdinal("RoomNo"));
                            int fpCheck = reader.GetInt32(reader.GetOrdinal("fp"));

                            listView1.Items.Add(userID.ToString());

                            listView1.Items[index].SubItems.Add(name);
                            listView1.Items[index].SubItems.Add(cardNo);
                            listView1.Items[index].SubItems.Add(degree);
                            listView1.Items[index].SubItems.Add(hostel);
                            listView1.Items[index].SubItems.Add(regNo);
                            listView1.Items[index].SubItems.Add(roomNo);
                            if (fpCheck == 0)
                            {
                                listView1.Items[index].SubItems.Add("NotAvailable");
                            }
                            else if (fpCheck == 1)
                            {
                                listView1.Items[index].SubItems.Add("Available");
                            }

                            index++;
                        }

                    }
                    userCount.Text = index.ToString();
                    txtUserID1.Text = (index + 1).ToString();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            openFileDialog1.FileName = "StudentsDataFile";
            openFileDialog1.Filter = "*.csv*|*.csv*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
            Cursor = Cursors.Default;
        }
        private void listView1_Click(object sender, EventArgs e)
        {
            Point mousePosition = listView1.PointToClient(Control.MousePosition);
            ListViewItem clickedItem = listView1.GetItemAt(mousePosition.X, mousePosition.Y);
            int response = 0;
            string userID = "";

            DialogResult result = MessageBox.Show("Scan User FingerPrints", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (clickedItem != null && listView1.SelectedItems.Count > 0)

                {
                    // Get the selected item
                    clickedItem = listView1.SelectedItems[0];
                    int desiredColumnIndex = GetDesiredColumnIndex(listView1, "UserID");
                    int fpIndex = GetDesiredColumnIndex(listView1, "FingerPrint");
                    string fpValue = clickedItem.SubItems[fpIndex].Text;
                    if (fpValue == "Available")
                    {
                        MessageBox.Show("FingerPrint Already Registered");
                        return;
                    }
                    string columnValue1 = clickedItem.SubItems[desiredColumnIndex].Text;
                    Cursor = Cursors.WaitCursor;
                    cbFingerIndex.SelectedIndex = 0;
                    cbFlag.SelectedIndex = 0;
                    cbPrivilege.SelectedIndex = 0;
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    userID = selectedItem.SubItems[0].Text;
                    string Name = selectedItem.SubItems[1].Text;
                    txtName.Text = Name;
                    txtUserID1.Text = userID;
                    response = UserMng.SDK.sta_OnlineEnroll(UserMng.lbSysOutputInfo, txtUserID1, cbFingerIndex, cbFlag);
                    UserMng.SDK.sta_SetUserInfo(UserMng.lbSysOutputInfo, txtUserID1, txtName, cbPrivilege, txtCardnumber, txtPassword);
                    Cursor = Cursors.Default;

                }

                if (response == 1)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE user SET fp = 1 WHERE machineID = @userId";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@userId", int.Parse(userID));

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Optionally, you can check the number of rows affected
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Record updated successfully.");
                            }
                            else
                            {
                                Console.WriteLine("No records were updated.");
                            }
                        }
                    }
                    foreach (ListViewItem item in listView1.Items)
                    {
                        listView1.Items.Remove(item);
                    }
                    loadData();
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private static int GetDesiredColumnIndex(ListView listView, string desiredHeaderText)
        {
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                if (listView.Columns[i].Text == desiredHeaderText)
                {
                    return i;
                }
            }
            return -1;
        }

        private void FilterListView(string searchText)
        {
            string searchTextLower = searchText.ToLower();
            foreach (ListViewItem item in listView1.Items)
            {

                string columnText = item.SubItems[1].Text.ToLower();

                if (columnText.Contains(searchTextLower))
                {
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                    break;
                }
                else
                {
                    item.Selected = false;
                    item.Focused = false;
                }


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox3.Text.Trim();
            FilterListView(searchText);
        }

        private void listView1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_Leave(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string stm = $"SELECT * FROM user where Hostel = '{metroComboBox1.SelectedItem}'";
                int index = 0;
                using (var cmd = new MySqlCommand(stm, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int userID = reader.GetInt32(reader.GetOrdinal("machineID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string cardNo = reader.GetString(reader.GetOrdinal("cnic"));
                            string hostel = reader.GetString(reader.GetOrdinal("Hostel"));
                            string degree = reader.GetString(reader.GetOrdinal("Degree"));
                            string regNo = reader.GetString(reader.GetOrdinal("regNo"));
                            string roomNo = reader.GetString(reader.GetOrdinal("RoomNo"));
                            int fpCheck = reader.GetInt32(reader.GetOrdinal("fp"));

                            listView1.Items.Add(userID.ToString());

                            listView1.Items[index].SubItems.Add(name);
                            listView1.Items[index].SubItems.Add(cardNo);
                            listView1.Items[index].SubItems.Add(degree);
                            listView1.Items[index].SubItems.Add(hostel);
                            listView1.Items[index].SubItems.Add(regNo);
                            listView1.Items[index].SubItems.Add(roomNo);
                            if (fpCheck == 0)
                            {
                                listView1.Items[index].SubItems.Add("NotAvailable");
                            }
                            else if (fpCheck == 1)
                            {
                                listView1.Items[index].SubItems.Add("Available");
                            }

                            index++;
                        }

                    }
                }
            }
        }
    }

    public class users
    {
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string Hostel { get; set; }
        public string Degree { get; set; }
        public string RegNo { get; set; }
        public string RoomNo { get; set; }
        public bool FPCheck { get; set; }
    }
}
