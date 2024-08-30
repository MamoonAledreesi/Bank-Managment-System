using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Managment_System.Transactions
{
    public class  clsTransferLogEntry
    {
        public DateTime TransferDate { get; set; }
        public string FromClientName { get; set; }
        public decimal FromClientBalanceBefore { get; set; }
        public decimal FromClientBalanceAfter { get; set; }
        public string ToClientName { get; set; }
        public decimal ToClientBalanceBefore { get; set; }
        public decimal ToClientBalanceAfter { get; set; }
        public decimal TransferAmount { get; set; }



        public static List<clsTransferLogEntry> GetTransferLogs()
        {
            List<clsTransferLogEntry> transferLogs = new List<clsTransferLogEntry>();
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/transferlog.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length == 8)
                    {
                        transferLogs.Add(new clsTransferLogEntry
                        {
                            TransferDate = DateTime.Parse(data[0]),
                            FromClientName = data[1],
                            FromClientBalanceBefore = decimal.Parse(data[2]),
                            FromClientBalanceAfter = decimal.Parse(data[3]),
                            ToClientName = data[4],
                            ToClientBalanceBefore = decimal.Parse(data[5]),
                            ToClientBalanceAfter = decimal.Parse(data[6]),
                            TransferAmount = decimal.Parse(data[7])
                        });
                    }
                }
            }

            return transferLogs;
        }

    }



}
