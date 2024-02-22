using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
namespace StandaloneSDKDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //dataBase Table Creation
            var connectionString = "Data Source=ZKTeco.db";
            using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create a table if it doesn't exist
                var createTableSql = @"
    CREATE TABLE IF NOT EXISTS Users (
        userID INTEGER PRIMARY KEY,
        Enable INTEGER,
        Name TEXT,
        CardNo TEXT NULL,
        Password TEXT NULL,
        FingerIndex INTEGER,
        Flag INTEGER NULL,
        FingerPrint TEXT UNIQUE,
        Privilege INTEGER NULL
    );

    CREATE TABLE IF NOT EXISTS facial (
        userID TEXT,
        Enable BOOLEAN,
        Name TEXT,
        password TEXT,
        iPrivillege INTEGER,
        iLength INTEGER,
        Face TEXT
    );";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = createTableSql;
                    command.ExecuteNonQuery();
                }
                Console.WriteLine("Table 'Users' and 'Facial' created successfully!");


                //using (var command = new SQLiteCommand("DELETE FROM Users", connection))
                //{
                //    command.ExecuteNonQuery();
                //    Console.WriteLine("All data in the 'Users' table has been deleted.");
                //}

            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
