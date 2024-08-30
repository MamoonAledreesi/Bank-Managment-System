using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Managment_System.clients
{
    public partial class frmClientsMainMenuScreen : Form
    {
        public frmClientsMainMenuScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clients.frmAddNewClientScreen frmAddNewClientScreen = new clients.frmAddNewClientScreen();
            frmAddNewClientScreen.ShowDialog();
        }

        private void btnShowAllClients_Click(object sender, EventArgs e)
        {
            frmShowAllClientsScreen frmShowAllClientsScreen = new frmShowAllClientsScreen();
            frmShowAllClientsScreen.ShowDialog();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            frmUpdateClientScreen frmUpdateClientScreen = new frmUpdateClientScreen();
             frmUpdateClientScreen.Show();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {

            if(btnFindClient.Text== "Find Client")
            {
                frmUpdateClientScreen frmUpdateClientScreen = new frmUpdateClientScreen();
                frmUpdateClientScreen.Show();
                frmUpdateClientScreen.Text = "Find Cielnt Screen";
                frmUpdateClientScreen.lblUpdateclient.Text = "Find Client Information";
                frmUpdateClientScreen.btnUpdateClient.Visible = false;

            }

            
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (btnDeleteClient.Text == "Delete Client")
            {
                frmUpdateClientScreen frmUpdateClientScreen = new frmUpdateClientScreen();
                frmUpdateClientScreen.Show();
                frmUpdateClientScreen.Text = "Delete Cielnt Screen";
                frmUpdateClientScreen.lblUpdateclient.Text = "Delete Client Information";
                frmUpdateClientScreen.btnUpdateClient.Visible = false;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        
    }
}
