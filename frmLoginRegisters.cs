using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Managment_System
{
    public partial class frmLoginRegisters : Form
    {
        public frmLoginRegisters()
        {
            InitializeComponent();
        }

        private void frmLoginRegisters_Load(object sender, EventArgs e)
        {
            PopulateDataGridView(); 
        }

        private void PopulateDataGridView()
        {
            var loginEntries =clsLoginEntry. GetLoginEntriesFromFile();

            dataGridViewLoginRegisters.Rows.Clear();
            foreach (var entry in loginEntries)
            {
                dataGridViewLoginRegisters.Rows.Add(entry.DateTime, entry.Username, entry.Password, entry.CanAccessClients, entry.CanAccessTransactions, entry.CanAccessManageUsers);
            }
        }

        private void dataGridViewLoginRegisters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
