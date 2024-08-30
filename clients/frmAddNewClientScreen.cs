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
    public partial class frmAddNewClientScreen : Form
    {
        public frmAddNewClientScreen()
        {
            InitializeComponent();
        }


        public static bool IsAccountNumberExists(string accountNumber, string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            string[] clientLines = File.ReadAllLines(filePath);
            foreach (string line in clientLines)
            {
                string[] clientData = line.Split(',');
                if (clientData[0] == accountNumber)
                {
                    return true;
                }
            }

            return false;
        }

        private void SaveClientDataToFile()
        {
            string AccountNumber = txtAccountNumber.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age = int.Parse(txtAge.Text);
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            decimal totalBalance = decimal.Parse(txtTotalBalance.Text);

            string filePath = "E:/programming Advices/14-C# level 1/Bank Managment System/Files/Clients.txt";

            if (IsAccountNumberExists(AccountNumber, filePath))
            {
                MessageBox.Show("Account number already exists. Please enter a unique account number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidName(firstName))
            {
                MessageBox.Show("First name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidName(lastName))
            {
                MessageBox.Show("Last name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidAge(age))
            {
                MessageBox.Show("Please enter a valid age between 18 and 130.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string clientData = $"{AccountNumber},{firstName},{lastName},{age},{phoneNumber},{email},{totalBalance}";

            File.AppendAllText(filePath, clientData + Environment.NewLine);
            MessageBox.Show("Client added successfully!");
            this.Close();
        }

        public static bool IsValidName(string name)
        {
            // Check if the name only contains letters and spaces
            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }
        public static bool IsValidEmail(string email)
        {
            // Basic email format validation
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }

        public static bool IsValidAge(int age)
        {
            return age >= 18 && age <= 130;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClientDataToFile();
        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
           
            if(string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                e.Cancel = true;
                txtAccountNumber.Focus();
                errorAddclient.SetError(txtAccountNumber, "Account Number Can't Be Null");
            }
            else
            {
                e.Cancel= false;
                errorAddclient.SetError(txtAccountNumber, "");
            }

        }

        private void txtTotalBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (e.g., Backspace, Delete)
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow decimal point and digits
            if (e.KeyChar == '.' && !txtTotalBalance.Text.Contains('.'))
            {
                return;
            }

            // Allow only digits and decimal point
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow only letters and spaces
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != ' ';
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow only letters and spaces
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != ' ';
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Validate email format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                txtEmail.ForeColor = System.Drawing.Color.Red; // Change text color to indicate invalid email
                
            }
            else
            {
                txtEmail.ForeColor = System.Drawing.Color.Black; // Reset text color if valid
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (e.g., Backspace, Delete)
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow only digits
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void frmAddNewClientScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
}
    



