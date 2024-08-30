using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Bank_Managment_System
{
    public partial class frmMainMenueScreen : Form
    {
        private Users. clsUser loggedInUser;

        public frmMainMenueScreen(Users.clsUser User)
        {
            InitializeComponent();

            loggedInUser = User;
            InitializeMenu();

        }


        private void InitializeMenu()
        {
            btnClients.Enabled = loggedInUser.CanAccessClients;
            btnTransactions.Enabled = loggedInUser.CanAccessTransactions;
            btnManageUsers.Enabled = loggedInUser.CanAccessManageUsers;
        }

       

        private void btnClients_Click(object sender, EventArgs e)
        {
            clients.frmClientsMainMenuScreen frmClientsMainMenuScreen = new clients.frmClientsMainMenuScreen();
            frmClientsMainMenuScreen.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Transactions.frmTransactionsMainScreen frmTransactionsMainScreen = new Transactions.frmTransactionsMainScreen();
            frmTransactionsMainScreen.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users.frmUserMainScreen frmUserMainScreen = new Users.frmUserMainScreen();
            frmUserMainScreen.ShowDialog();

        }

        private void btnLoginRegisters_Click(object sender, EventArgs e)
        {
            frmLoginRegisters frmLoginRegisters = new frmLoginRegisters();
            frmLoginRegisters.ShowDialog();
        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            frmcurrencyExchange frmcurrencyExchange = new frmcurrencyExchange();
            frmcurrencyExchange.ShowDialog();
        }
    }
}
