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

namespace Bank_Managment_System.Currencies
{
    public partial class frmFindcurrencyScreen : Form
    {
        private List<clsCurrencies> currencies = new List<clsCurrencies>();
        public frmFindcurrencyScreen()
        {
            InitializeComponent();
            LoadCurrencies();
        }

        private void LoadCurrencies()
        {
            string[] lines = File.ReadAllLines(" E:/programming Advices/14-C# level 1/Bank Managment System/Files/Currencies.txt");
            foreach (var line in lines)
            {
                var data = line.Split(',');
                if (data.Length == 4)
                {
                    currencies.Add(new clsCurrencies
                    {
                        Country = data[0],
                        Code = data[1],
                        Name = data[2],
                        Rate = decimal.Parse(data[3])
                    });
                }
            }
        }


        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSearchCriteria.SelectedIndex == 0)
            {
                lblSearch.Text = "Enter Code";
                lblSearch.Visible = true;
                txtSearchByCodeOrCountry.Visible = true;
            }
            else
            {
                lblSearch.Text = "Enter Country";
                lblSearch.Visible = true;
                txtSearchByCodeOrCountry.Visible = true;
            }
                
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchTerm = txtSearchByCodeOrCountry.Text.Trim().ToLower();
            List<clsCurrencies> results = new List<clsCurrencies>();
            

            if (cmbSearchCriteria.SelectedItem.ToString() == "country")
            {
                results = currencies.Where(c => c.Country.ToLower().Contains(searchTerm)).ToList();
            }
            else if (cmbSearchCriteria.SelectedItem.ToString() == "code")
            {
                results = currencies.Where(c => c.Code.ToLower() == searchTerm).ToList();
            }

            if (results.Count > 0)
            {
       
                foreach (var currency in results)
                {
                    dgvResults.Rows.Add(currency.Country, currency.Code, currency.Name, currency.Rate);
                }

                

            }
            else
            {
                MessageBox.Show("No results found.");
            }
        }


    }

       
    
}
