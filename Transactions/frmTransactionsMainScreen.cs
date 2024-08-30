using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Managment_System.Transactions
{
    public partial class frmTransactionsMainScreen : Form
    {
        public frmTransactionsMainScreen()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDepositscreen frmDepositscreen = new frmDepositscreen();
            frmDepositscreen.ShowDialog();
        }

        private void btnWithdrow_Click(object sender, EventArgs e)
        {

            frmDepositscreen frmDepositscreen = new frmDepositscreen();
            frmDepositscreen.Text = "Withdraw Screen";
            frmDepositscreen.label1.Text = "Withdraw";
            frmDepositscreen.btnDeposit.Text = "Withdraw";
            frmDepositscreen.ShowDialog();

            
        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            frmTotalBalncesScreen frmTotal = new frmTotalBalncesScreen();
            frmTotal.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTransferScreen frmTransferscreen = new frmTransferScreen();  
            frmTransferscreen.ShowDialog();
        }

        private void btnTransferLog_Click(object sender, EventArgs e)
        {
            frmTransferLog frmTransferLog = new frmTransferLog();   
            frmTransferLog.ShowDialog();
        }
    }
}
