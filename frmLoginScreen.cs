using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Managment_System
{
    public partial class frmLoginScreen : Form
    {

       
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private Users. clsUser AuthenticateUser(string username, string password)
        {
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/users.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length == 8 && data[0] == username && data[2] == password)
                    {
                        return new Users. clsUser
                        {
                            Username = data[0],
                            FullName = data[1],
                            Password = data[2],
                            PhoneNumber = data[3],
                            Email = data[4],
                            CanAccessClients = bool.Parse(data[5]),
                            CanAccessTransactions = bool.Parse(data[6]),
                            CanAccessManageUsers = bool.Parse(data[7])
                        };
                    }
                }
            }

            return null;
        }


        private void LogLogin(Users.clsUser user)
        {
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/LoginRegisters.txt";


            string logEntry = $"{DateTime.Now},{user.Username},{user.Password},{user.CanAccessClients},{user.CanAccessTransactions},{user.CanAccessManageUsers}";

            File.AppendAllText(filePath, logEntry + Environment.NewLine);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorEmptytxtbox.Clear();
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            Users.clsUser loggedInUser = AuthenticateUser(username, password);

            if (loggedInUser != null)
            {
                LogLogin(loggedInUser);
                frmMainMenueScreen mainMenu = new frmMainMenueScreen(loggedInUser);
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorEmptytxtbox.SetError(txtUserName, "UserName sould have a value");

            }
            else
            {
                e.Cancel = false;
                errorEmptytxtbox.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorEmptytxtbox.SetError(txtPassword, "Password sould have a value");

            }
            else
            {
                e.Cancel = false;
                errorEmptytxtbox.SetError(txtPassword, "");

            }
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                chbShowPassword.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                chbShowPassword.Text = "Show Password";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
