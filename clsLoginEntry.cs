using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Bank_Managment_System
{
    public class clsLoginEntry
    {
        public DateTime DateTime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CanAccessClients { get; set; }
        public bool CanAccessTransactions { get; set; }
        public bool CanAccessManageUsers { get; set; }

        public static List<clsLoginEntry> GetLoginEntriesFromFile()
        {
            List<clsLoginEntry> loginEntries = new List<clsLoginEntry>();
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/LoginRegisters.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length == 6)
                    {
                        loginEntries.Add(new clsLoginEntry
                        {
                            DateTime = DateTime.Parse(data[0]),
                            Username = data[1],
                            Password = data[2],
                            CanAccessClients = bool.Parse(data[3]),
                            CanAccessTransactions = bool.Parse(data[4]),
                            CanAccessManageUsers = bool.Parse(data[5])
                        });
                    }
                }
            }

            return loginEntries;
        }
    }
}
