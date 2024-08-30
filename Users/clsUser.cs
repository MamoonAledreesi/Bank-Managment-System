using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Bank_Managment_System.Users
{
    public class clsUser
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool CanAccessClients { get; set; }
        public bool CanAccessTransactions { get; set; }
        public bool CanAccessManageUsers { get; set; }

        public static List<clsUser> GetUsersFromFile()
        {
            List<clsUser> users = new List<clsUser>();
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/users.txt"; 

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length == 8)
                    {
                        users.Add(new clsUser
                        {
                            Username = data[0],
                            FullName = data[1],
                            Password = data[2],
                            PhoneNumber = data[3],
                            Email = data[4],
                            CanAccessClients = bool.Parse(data[5]),
                            CanAccessTransactions = bool.Parse(data[6]),
                            CanAccessManageUsers = bool.Parse(data[7])
                        });
                    }
                }
            }

            return users;
        }
    }
}
