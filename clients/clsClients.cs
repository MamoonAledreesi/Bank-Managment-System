using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Managment_System.clients
{
    public class clsClients
    {
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal TotalBalance { get; set; }




        private void UpdateClient(string accountNumber, string firstName, string lastName, int age, string phoneNumber, string email, decimal totalBalance)
        {
            string filePath = "E:/programming Advices/14-C# level 1/Bank Managment System/Files/Clients.txt";
            var lines = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                var data = lines[i].Split(',');

                if (data[0] == accountNumber)
                {
                    lines[i] = $"{accountNumber},{firstName},{lastName},{age},{phoneNumber},{email},{totalBalance}";
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);
        }



      public   void Deposit(decimal Amount)
        {
            TotalBalance += Amount;
            UpdateClient(AccountNumber, FirstName, LastName, Age, PhoneNumber, Email, TotalBalance);
            
        }

      public   bool Withdraw(decimal Amount)
        {
            if (Amount > TotalBalance)
            {
                return false;
            }
            else
            {
                TotalBalance -= Amount;
                UpdateClient(AccountNumber, FirstName, LastName, Age, PhoneNumber, Email, TotalBalance);
            }
            return true;

        }


    }

}
