using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;
namespace StandaloneSDKDemo
{
    static class Program
    {
        public static NotifyIcon notifyIcon;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //dataBase Table Creation
//            var connectionString = "Data Source=ZKTeco.db";
//            try
//            {
//                using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
//                {
//                    connection.Open();

//                    // Create a table if it doesn't exist
//                    var createTableSql = @"
//    CREATE TABLE IF NOT EXISTS Users (
//        userID INTEGER PRIMARY KEY,
//        Enable INTEGER,
//        Name TEXT,
//        CardNo TEXT NULL,
//        Password TEXT NULL,
//        FingerIndex INTEGER,
//        Flag INTEGER NULL,
//        FingerPrint TEXT UNIQUE,
//        Privilege INTEGER NULL
//    );
//    CREATE TABLE IF NOT EXISTS facial (
//        userID TEXT PRIMARY KEY,
//        Enable BOOLEAN,
//        Name TEXT,
//        password TEXT,
//        iPrivillege INTEGER,
//        iLength INTEGER,
//        Face TEXT UNIQUE
//    );
//    CREATE TABLE IF NOT EXISTS user (
//        userID TEXT PRIMARY KEY,
//        Name TEXT,
//        cnic TEXT,
//        Hostel TEXT,
//        Degree TEXT
//    );
//    CREATE TABLE IF NOT EXISTS Attendance (
//        AttendanceID INTEGER PRIMARY KEY AUTOINCREMENT,
//        Identifier TEXT UNIQUE,
//        UserID TEXT,
//        UserName TEXT,
//        AttendanceTime TEXT,
//        VerifyType INTEGER,
//        VerifyState TEXT,
//        WorkCode INTEGER
//    );

//    CREATE TABLE IF NOT EXISTS Guest (
//        GuestID INTEGER PRIMARY KEY AUTOINCREMENT,
//        Name TEXT NOT NULL,
//        Contact TEXT NOT NULL,
//        CNIC TEXT NOT NULL,
//        Address TEXT NOT NULL,
//        VisiteeName TEXT NOT NULL,
//        VisiteeID TEXT NOT NULL,
//        Relation TEXT NOT NULL,
//        StartDate TEXT NOT NULL,
//        EndDate TEXT NOT NULL
//);";

//                    using (var command = connection.CreateCommand())
//                    {
//                        command.CommandText = createTableSql;
//                        command.ExecuteNonQuery();
//                    }
//                    Console.WriteLine("Table 'Users' and 'Facial' created successfully!");


            //        //using (var command = new SQLiteCommand("DELETE FROM facial", connection))
            //        //{
            //        //    command.ExecuteNonQuery();
            //        //    Console.WriteLine("All data in the 'Facial' table has been deleted.");
            //        //}
            //        //using (var command = new SQLiteCommand("DELETE FROM user", connection))
            //        //{
            //        //    command.ExecuteNonQuery();
            //        //    Console.WriteLine("All data in the 'Users' table has been deleted.");
            //        //}
            //        string stm = "SELECT * FROM user";
            //        using (var cmd = new SQLiteCommand(stm, connection))
            //        {
            //            using (SQLiteDataReader rdr = cmd.ExecuteReader())
            //            {

            //                while (rdr.Read())
            //                {
            //                    Console.WriteLine($"userID: {rdr["userID"]}, Name: {rdr["Name"]}, CNIC: {rdr["cnic"]}, Hostel: {rdr["Hostel"]}, Degree: {rdr["Degree"]}");
            //                }
            //            }
            //        }
            //    }

            //}
            //catch
            //{

            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            
        }
    }
}
