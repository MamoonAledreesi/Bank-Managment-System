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
    public partial class frmUpdateClientScreen : Form
    {
        public frmUpdateClientScreen()
        {
            InitializeComponent();
        }
        private clsClients SearchClientByAccountNumber(string accountNumber)
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
                        return new clsClients
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

        public  void EnbleTextboxes()
        {
            txtSearchAccountNumber.Enabled = false;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtAge.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtTotalBalance.Enabled = true;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string accountNumber = txtSearchAccountNumber.Text;

            if (string.IsNullOrEmpty(accountNumber))
            {
                MessageBox.Show("Please enter an account number to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(lblUpdateclient.Text == "Update Client Information")
            {
                EnbleTextboxes();
                btnDelete.Visible = false;
            }
            else if(lblUpdateclient.Text == "Find Client Information")
            {
                btnDelete.Visible = false;
            }
            else
                btnDelete.Visible = true;


            clients.clsClients client = SearchClientByAccountNumber(accountNumber);

            if (client != null)
            {
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

        public  void btnUpdateClient_Click(object sender, EventArgs e)
        {

            

            string accountNumber = txtSearchAccountNumber.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string ageText = txtAge.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            string totalBalanceText = txtTotalBalance.Text;

            string FilePath= "E:/programming Advices/14-C# level 1/Bank Managment System/Files/Clients.txt";
            // Validate first and last names
            if (!frmAddNewClientScreen.IsValidName(firstName))
            {
                MessageBox.Show("First name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!frmAddNewClientScreen.IsValidName(lastName))
            {
                MessageBox.Show("Last name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email
            if (!frmAddNewClientScreen.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate age
            if (!int.TryParse(ageText, out int age) || !frmAddNewClientScreen.IsValidAge(age))
            {
                MessageBox.Show("Please enter a valid age between 18 and 130.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate total balance
            if (!decimal.TryParse(totalBalanceText, out decimal totalBalance))
            {
                MessageBox.Show("Please enter a valid total balance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if account number exists for update
            if (frmAddNewClientScreen.IsAccountNumberExists(accountNumber, FilePath))
            {
                if (MessageBox.Show("Update client information?", "Update", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    UpdateClient(accountNumber, firstName, lastName, age, phoneNumber, email, totalBalance);
                    MessageBox.Show("Update client seccessfully", "Seccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" Error Client did not updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show(" Error Client did not updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
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

        private void frmUpdateClientScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
                string accountNumber = txtSearchAccountNumber.Text;

                if (string.IsNullOrEmpty(accountNumber))
                {
                    MessageBox.Show("Please enter an account number to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            if (MessageBox.Show("Are you sure do you wnat to delete this client?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (DeleteClient(accountNumber))
                {
                    MessageBox.Show("Client deleted successfully!");
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Client not found.", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Cancel delete client ?", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
        }

        private bool DeleteClient(string accountNumber)
        {
            string filePath = "E:/programming Advices/14-C# level 1/Bank Managment System/Files/Clients.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath).ToList();
                var lineToRemove = lines.FirstOrDefault(line => line.Split(',')[0] == accountNumber);

                if (lineToRemove != null)
                {
                    lines.Remove(lineToRemove);
                    File.WriteAllLines(filePath, lines);
                    return true;
                }
            }

            return false;
        }
        private void ClearFormFields()
        {
            txtSearchAccountNumber.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTotalBalance.Text = string.Empty;
            txtSearchAccountNumber.Text = string.Empty;

            // Enable account number field
            txtSearchAccountNumber.ReadOnly = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
