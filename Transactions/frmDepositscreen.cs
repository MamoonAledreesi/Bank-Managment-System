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

namespace Bank_Managment_System.Transactions
{
    public partial class frmDepositscreen : Form
    {
        public frmDepositscreen()
        {
            InitializeComponent();
        }

        private clients. clsClients SearchClientByAccountNumber(string accountNumber)
        {
            string filePath = "E:/programming Advices/14-C# level 1/Bank Managment System/Files/Clients.txt";

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
                            Age = int.Parse(data[3]),
                            PhoneNumber = data[4],
                            Email = data[5],
                            TotalBalance = decimal.Parse(data[6])
                        };
                    }
                }
            }

            return null;
        }

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


        private void EnbleTextboxes()
        {
            txtSearchAccountNumber.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAge.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtTotalBalance.Enabled = false;
            btnSearch.Enabled = false;
            txtDepositAmount.Enabled = true;
            btnDeposit.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string accountNumber = txtSearchAccountNumber.Text;

            if (string.IsNullOrEmpty(accountNumber))
            {
                MessageBox.Show("Please enter an account number to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            clients.clsClients client = SearchClientByAccountNumber(accountNumber);

            if (client != null)
            {
                gbCilentInfomation.Visible = true;
                EnbleTextboxes();
                // Populate form fields with client data
                txtSearchAccountNumber.Text = client.AccountNumber;
                txtFirstName.Text = client.FirstName;
                txtLastName.Text = client.LastName;
                txtAge.Text = client.Age.ToString();
                txtPhoneNumber.Text = client.PhoneNumber;
                txtEmail.Text = client.Email;
                txtTotalBalance.Text = client.TotalBalance.ToString();
            }
            else
            {
                MessageBox.Show("Client not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnDeposit_Click(object sender, EventArgs e)
        {

            string accountNumber = txtSearchAccountNumber.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string ageText = txtAge.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            string totalBalanceText = txtTotalBalance.Text;
            string totalBalanceDepsitText=txtDepositAmount.Text;
            decimal totalBalanceDepsit =Convert.ToDecimal( txtDepositAmount.Text)+Convert.ToDecimal(txtTotalBalance.Text);

            if (btnDeposit.Text == "Withdraw")
            {
                if(Convert.ToDecimal(txtDepositAmount.Text)> Convert.ToDecimal(txtTotalBalance.Text))
                {
                    MessageBox.Show("You can't Withdraw Because Withdraw balance > Total Balance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDepositAmount.Clear();
                    txtDepositAmount.Focus();
                    return;
                }
                 totalBalanceDepsit =  Convert.ToDecimal(txtTotalBalance.Text)- Convert.ToDecimal(txtDepositAmount.Text);
            }

            if (!decimal.TryParse(totalBalanceDepsitText, out decimal totalBalanceDepsittext))
            {
                MessageBox.Show("Please enter a valid total balance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Do you want to perform this operation?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                UpdateClient(accountNumber, firstName, lastName, Convert.ToInt16(ageText), phoneNumber, email, totalBalanceDepsit);
                txtTotalBalance.Text = Convert.ToString(totalBalanceDepsit);
                MessageBox.Show("Amount Updatted Seccessfully.", "Seccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("New total Balance : " + txtTotalBalance.Text,
                    "Seccessfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();   
            }
            else
            {
                MessageBox.Show(" Error amount did not Updatted ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow only digits
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
