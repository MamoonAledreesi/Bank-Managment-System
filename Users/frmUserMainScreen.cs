using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Managment_System.Users
{
    public partial class frmUserMainScreen : Form
    {
        public frmUserMainScreen()
        {
            InitializeComponent();
        }

        private void frmUserMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUserscreen frmAddNewUserscreen = new frmAddNewUserscreen();
            frmAddNewUserscreen.ShowDialog();
        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            frmShowAllUsersScreen frmShowAllUsersScreen = new frmShowAllUsersScreen();  
            frmShowAllUsersScreen.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            frmUpdateUserInfoScreen frmUpdateUserInfoScreen = new frmUpdateUserInfoScreen();
            frmUpdateUserInfoScreen.ShowDialog();
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            
                frmUpdateUserInfoScreen frmUpdateUserInfoScreen  = new frmUpdateUserInfoScreen();
                
                frmUpdateUserInfoScreen.lblTitleName.Text = "Find User Informaion";
                frmUpdateUserInfoScreen.Text = "Find User Screen";
               
                frmUpdateUserInfoScreen.ShowDialog();
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmUpdateUserInfoScreen frmUpdateUserInfoScreen = new frmUpdateUserInfoScreen();

            frmUpdateUserInfoScreen.lblTitleName.Text = "Delete User Informaion";
            frmUpdateUserInfoScreen.Text = "Delete User Screen";

            frmUpdateUserInfoScreen.ShowDialog();
        }
    }
}
