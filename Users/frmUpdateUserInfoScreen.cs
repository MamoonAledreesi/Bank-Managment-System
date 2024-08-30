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
    public partial class frmUpdateUserInfoScreen : Form
    {
        public frmUpdateUserInfoScreen()
        {
            InitializeComponent();
        }

        string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/users.txt";

        void EnabelBoxes()
        {


            txtUsername.Enabled = false;
            
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible  = true;
            label6.Visible = true;
            groupBox1.Visible= true;

            txtEmail.Visible = true;
            txtFullName.Visible = true;
            txtPassword.Visible = true;
            txtPhoneNumber.Visible = true;
            
            btnUpdateUser.Visible = true;

        }
        void DisabelBoxes()
        {


            txtUsername.Enabled = false;

            
            groupBox1.Enabled = false;

            txtEmail.Enabled = false;
            txtFullName.Enabled = false;
            txtPassword.Enabled = false;
            txtPhoneNumber.Enabled = false;

           

        }
        private clsUser SearchUserByUserName(string Username)
        {
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/users.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length == 8 && data[0] == Username)
                    {
                        return new clsUser
                        {
                            Username = data[0],
                            FullName = data[1],
                            Password = data[2],
                            PhoneNumber = data[3],
                            Email = data[4],
                            CanAccessClients =bool.Parse( data[5]),
                            CanAccessTransactions = bool .Parse(data[6]),
                            CanAccessManageUsers=bool.Parse( data[7])
                        };
                    }
                }
            }

            return null;
        }

        private void UpdateUserInfo()
        {
            

            string username = txtUsername.Text;
            string fullName = txtFullName.Text;
            string password = txtPassword.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            bool canAccessClients = chkClients.Checked;
            bool canAccessTransactions = chkTransactions.Checked;
            bool canAccessManageUsers = chkManageUsers.Checked;

            
        

            if (!Users.frmAddNewUserscreen.IsValidName(fullName))
            {
                MessageBox.Show("Name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Users.frmAddNewUserscreen.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (Users.frmAddNewUserscreen.IsUSerExists(username, filePath))
            {

                if (MessageBox.Show("Update User information?", "Update", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    UpdateUser(username, fullName,password,phoneNumber, email, canAccessClients, canAccessTransactions, canAccessManageUsers);
                    MessageBox.Show("Update user seccessfully", "Seccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" Error  user did not updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();   
        }

        private void UpdateUser(string UserName, string FullName, string Password,
            string phoneNumber, string email, bool chkClients,bool chkTransactions,bool chkManageUsers)
        {
            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/users.txt";
            var lines = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                var data = lines[i].Split(',');

                if (data[0] == UserName)
                {
                    lines[i] = $"{UserName},{FullName},{Password},{phoneNumber},{email},{chkClients},{chkTransactions},{chkManageUsers}";
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);
        }
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            UpdateUserInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if ( Users.frmAddNewUserscreen.IsUSerExists(username, filePath))
            {
                


                clsUser clsuser = SearchUserByUserName(username);
                if (clsuser != null)
                {
                    txtPhoneNumber.Text = clsuser.PhoneNumber;
                    txtEmail.Text = clsuser.Email;
                    txtPassword.Text = clsuser.Password;
                    txtFullName.Text = clsuser.FullName;

                    chkClients.Checked = clsuser.CanAccessClients;
                    chkTransactions.Checked = clsuser.CanAccessTransactions;
                    chkManageUsers.Checked = clsuser.CanAccessManageUsers;
                    EnabelBoxes();

                    if (lblTitleName.Text == "Find User Informaion")
                    {
                        btnUpdateUser.Visible = false;
                        DisabelBoxes();
                    }
                    if (lblTitleName.Text == "Delete User Informaion")
                    {
                        btnUpdateUser.Visible = false;
                        btnDelete.Visible = true;
                        DisabelBoxes();
                    }


                }
            }
            else
            {
                MessageBox.Show("User not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;

            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("Please enter an UserName to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure do you wnat to delete this User?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (DeleteUser(UserName))
                {
                    MessageBox.Show("User deleted successfully!");
                    ClearFormFields();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("USer not found.", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Cancel delete user ?", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private bool DeleteUser(string accountNumber)
        {
          

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
            txtUsername.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
           
            txtEmail.Text = string.Empty;
            groupBox1.Text=String.Empty;

            // Enable account number field
            txtUsername.ReadOnly = false;
        }
    }
}
