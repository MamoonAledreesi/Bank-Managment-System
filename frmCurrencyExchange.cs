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
    public partial class frmcurrencyExchange : Form
    {
        public frmcurrencyExchange()
        {
            InitializeComponent();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindCurrency_Click(object sender, EventArgs e)
        {
            Currencies.frmFindcurrencyScreen frmFindcurrencyScreen = new Currencies.frmFindcurrencyScreen();
            frmFindcurrencyScreen.ShowDialog();
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            Currencies.frmUpdateRatesScreen frmUpdateRatesScreen = new Currencies.frmUpdateRatesScreen();
            frmUpdateRatesScreen.ShowDialog();
        }

        private void frmcurrencyExchange_Load(object sender, EventArgs e)
        {

        }
    }
}
