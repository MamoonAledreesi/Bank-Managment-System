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
    public partial class frmShowAllUsersScreen : Form
    {
        public frmShowAllUsersScreen()
        {
            InitializeComponent();
        }

        private void PopulateDataGridView()
        {
            var users =clsUser. GetUsersFromFile();

            dataGridViewUsers.Rows.Clear();
            foreach (var user in users)
            {
                dataGridViewUsers.Rows.Add(user.Username, user.FullName,user.Password, user.PhoneNumber, user.Email,
                    user.CanAccessClients, user.CanAccessTransactions, user.CanAccessManageUsers);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowAllUsersScreen_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
