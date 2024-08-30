using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Managment_System.Users
{
    public partial class frmAddNewUserscreen : Form
    {
        public frmAddNewUserscreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


        public static bool IsUSerExists(string USername, string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            string[] clientLines = File.ReadAllLines(filePath);
            foreach (string line in clientLines)
            {
                string[] clientData = line.Split(',');
                if (clientData[0] == USername)
                {
                    return true;
                }
            }

            return false;
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


        private bool ValidateForm()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Username is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Full name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Password is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider.SetError(txtPhoneNumber, "Phone number is required.");
                return false;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Invalid email format.");
                return false;
            }

            return true;
        }

       

        private void SaveUser()
        {
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/users.txt";

            string username = txtUsername.Text;
            string fullName = txtFullName.Text;
            string password = txtPassword.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            bool canAccessClients = chkClients.Checked;
            bool canAccessTransactions = chkTransactions.Checked;
            bool canAccessManageUsers = chkManageUsers.Checked;

            ValidateForm();
            if (IsUSerExists(username, filePath))
            {
                MessageBox.Show("UserName already exists. Please enter a unique UserName.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidName(fullName))
            {
                MessageBox.Show("Name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            string userRecord = $"{username},{fullName},{password},{phoneNumber},{email},{canAccessClients},{canAccessTransactions},{canAccessManageUsers}";
            MessageBox.Show("User added successfully!","success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(userRecord);
            }
            this.Close();   
        }

        private void btnSaveUser_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure do you want do add this user?", "warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SaveUser();
            }
            else
            {
                MessageBox.Show(" failed  added!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow only digits
            e.Handled = Char.IsDigit(e.KeyChar);
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
    }
}
