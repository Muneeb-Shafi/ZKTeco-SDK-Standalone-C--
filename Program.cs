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
                    CREATE TABLE IF NOT EXISTS Users (userID INTEGER PRIMARY KEY,Enable INTEGER,Name TEXT,
                    CardNo TEXT NULL,Password TEXT NULL,FingerIndex INTEGER,Flag INTEGER NULL,
                    FingerPrint TEXT UNIQUE,Privilege INTEGER NULL)";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = createTableSql;
                    command.ExecuteNonQuery();
                }
                Console.WriteLine("Table 'Users' created successfully!");


                //using (var command = new SQLiteCommand("DELETE FROM Users", connection))
                //{
                //    command.ExecuteNonQuery();
                //    Console.WriteLine("All data in the 'Users' table has been deleted.");
                //}


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


                            Console.WriteLine($"User ID: {userID}");
                            Console.WriteLine($"Enable: {enable}");
                            Console.WriteLine($"Name: {name}");
                            Console.WriteLine($"Card No: {cardNo}");
                            Console.WriteLine($"Password: {password}");
                            Console.WriteLine($"Finger Index: {fingerIndex}");
                            Console.WriteLine($"Flag: {flag}");
                            Console.WriteLine($"Fingerprint: {fingerPrint}");
                            Console.WriteLine($"Privilege: {privilege}");
                            Console.WriteLine();
                        }
                    }
                }






                }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
