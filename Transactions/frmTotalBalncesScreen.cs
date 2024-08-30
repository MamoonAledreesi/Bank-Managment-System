using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bank_Managment_System.Transactions
{
    public partial class frmTotalBalncesScreen : Form
    {

        decimal CounttotalBalnce=0;   

        public frmTotalBalncesScreen()
        {
            InitializeComponent();
        }


        private List<clients.clsClients> GetClientsFromFile()
        {
            List<clients.clsClients> clients = new List<clients.clsClients>();
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/Clients.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length == 7)
                    {
                        clients.Add(new clients.clsClients
                        {
                            AccountNumber = data[0],
                            FirstName = data[1],
                            LastName = data[2],
                            TotalBalance = decimal.Parse(data[6]),
                            
                        }) ;

                    }

                    
                }

            }

            return clients;
        }
        private void PopulateDataGridView()
        {
            var clients = GetClientsFromFile();

            foreach (var client in clients)
            {
                DGVbalnces.Rows.Add(client.AccountNumber, client.FullName,  client.TotalBalance);
                CounttotalBalnce += client.TotalBalance;
            }
        }


        private void frmTotalBalncesScreen_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            lblTotalBalance.Text = $"Total Balance: {CounttotalBalnce:C}";
        }
    }
}
