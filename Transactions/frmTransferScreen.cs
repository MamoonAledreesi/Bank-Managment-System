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
    public partial class frmTransferScreen : Form
    {
        public frmTransferScreen()
        {
            InitializeComponent();
        }
        string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/Clients.txt";
        private clients. clsClients fromClient;
        private clients. clsClients toClient;

        private clients. clsClients SearchClientByAccountNumber(string accountNumber)
        {
            

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length == 7 && data[0] == accountNumber)
                    {
                        return new clients. clsClients
                        {
                            AccountNumber = data[0],
                            FirstName = data[1],
                            LastName = data[2],
                            
                            TotalBalance = decimal.Parse(data[6])
                        };
                    }
                }
            }

            return null;
        }
        private void UpdateClientBalanceInFile(clients. clsClients client)
        {
            
            var lines = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                var data = lines[i].Split(',');

                if (data[0] == client.AccountNumber)
                {
                    data[6] = client.TotalBalance.ToString();
                    lines[i] = string.Join(",", data);
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        private void DisplayClientInfo(clients.clsClients client, string type)
        {
          

            if (client != null)
            {
                if ( type== "from")
                {
                    txtfromFirstName.Text = client.FirstName;
                    txtfromLastName.Text = client.LastName;
                    txtfromTotalBalance.Text = client.TotalBalance.ToString();
                    gbFromClientInfo.Visible = true;
                    gbFromClientInfo.Enabled = false;
                    txtFromAccountNumber.Enabled = false;
                    label4.Visible = true;
                    txtToAccountNumber.Visible = true;
                }
                else if (type == "to")
                {
                    txtToFirstName.Text = client.FirstName;
                    txtToLastName.Text = client.LastName;
                    txtToTotalBalance.Text = client.TotalBalance.ToString();
                    gbToClientInfo.Visible = true;
                    gbToClientInfo.Enabled= false;
                    txtToAccountNumber.Enabled=false;

                    btnTransfer.Visible = true;
                    txtTransferAmount.Visible = true;
                    label9.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogTransfer(clients.clsClients fromClient, clients.clsClients toClient, decimal transferAmount)
        {
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/transferlog.txt";
            string logEntry = $"{DateTime.Now}, {fromClient.FirstName} {fromClient.LastName}, {fromClient.TotalBalance + transferAmount}," +
                $" {fromClient.TotalBalance}, {toClient.FirstName} {toClient.LastName}, " +
                $"{toClient.TotalBalance - transferAmount}, {toClient.TotalBalance}, {transferAmount}";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(logEntry);
            }
        }

        

        private void txtFromAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string accountNumber = txtFromAccountNumber.Text;
                fromClient = SearchClientByAccountNumber(accountNumber);
                DisplayClientInfo(fromClient, "from");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtToAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string accountNumber = txtToAccountNumber.Text;
                toClient = SearchClientByAccountNumber(accountNumber);
                DisplayClientInfo(toClient, "to");
                e.Handled = true;
                e.SuppressKeyPress = true;

               
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (fromClient == null || toClient == null)
            {
                MessageBox.Show("Please enter valid account numbers for both clients.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtTransferAmount.Text, out decimal transferAmount))
            {
                MessageBox.Show("Please enter a valid transfer amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (transferAmount > fromClient.TotalBalance||transferAmount<=0)
            {
                MessageBox.Show("Insufficient balance for the transfer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fromClient.TotalBalance -= transferAmount;
            toClient.TotalBalance += transferAmount;

            UpdateClientBalanceInFile(fromClient);
            UpdateClientBalanceInFile(toClient);
            if (MessageBox.Show("Do you want confirm this operation?!", "Warnning",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                LogTransfer(fromClient, toClient, transferAmount);

                MessageBox.Show("Transfer completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DisplayClientInfo(fromClient, "from");
                DisplayClientInfo(toClient, "to");

                txtTransferAmount.Enabled = false;
                btnTransfer.Enabled = false;

                this.Focus();
            }
           else
            {
                MessageBox.Show("Filed operation!", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
