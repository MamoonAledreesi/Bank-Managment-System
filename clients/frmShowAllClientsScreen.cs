using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Managment_System.clients
{
    public partial class frmShowAllClientsScreen : Form
    {
        public frmShowAllClientsScreen()
        {
            InitializeComponent();
        }


      
        private List<clsClients> GetClientsFromFile()
        {
            List<clsClients> clients = new List<clsClients>();
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/Clients.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length == 7)
                    {
                        clients.Add(new clsClients
                        {
                            AccountNumber = data[0],
                            FirstName = data[1],
                            LastName = data[2],
                            Age = int.Parse(data[3]),
                            PhoneNumber = data[4],
                            Email = data[5],
                            TotalBalance = decimal.Parse(data[6])
                        });
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
                dataGridView1.Rows.Add(client.AccountNumber, client.FullName, client.PhoneNumber, client.Age, client.Email, client.TotalBalance);
            }
        }



        private void frmShowAllClientsScreen_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
