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
    public partial class frmTransferLog : Form
    {
        public frmTransferLog()
        {
            InitializeComponent();
        }

        private void PopulateTransferLogGridView()
        {
            var transferLogs =clsTransferLogEntry. GetTransferLogs();
            dataGridViewTransferLog.DataSource = transferLogs;
        }
        private void frmTransferLog_Load(object sender, EventArgs e)
        {
            PopulateTransferLogGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTransferLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
