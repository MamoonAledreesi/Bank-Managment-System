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
    public partial class frmUpdateRatesScreen : Form
    {

        private string FileName = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/Currencies.txt";
        public frmUpdateRatesScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string codeToSearch = txtCountryCode.Text.Trim();
            string[] lines = File.ReadAllLines(FileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[1].Trim().Equals(codeToSearch, StringComparison.OrdinalIgnoreCase))
                {
                    // Populate the group box with country information
                    lblCountryName.Text = parts[0];
                    lblCountryCode.Text = parts[1];
                    lblCurrencyName.Text = parts[2];
                    lblCountryRate.Text = parts[3];

                    grpCountryInfo.Visible = true; // Show the group box
                    return;
                }
            }

            MessageBox.Show("Country code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update rate?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                
                string newRate = txtNewRate.Text.Trim();
                string codeToSearch = txtCountryCode.Text.Trim();
                string[] lines = File.ReadAllLines(FileName);
                bool updated = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[1].Trim().Equals(codeToSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        // Update the rate in the file
                        parts[3] = newRate;
                        lines[i] = string.Join(",", parts);
                        updated = true;

                        // Update the rate in the group box
                        lblCountryRate.Text = newRate;

                        break;
                    }
                }

                if (updated)
                {
                    File.WriteAllLines(FileName, lines);
                    MessageBox.Show("Rate updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Failed to update the rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNewRate_TextChanged(object sender, EventArgs e)
        {
            if(chkUpdateRate.Checked)
            {
                txtNewRate.Visible = true;
            }
            else
                txtNewRate.Visible = false;
        }
    }
    
}
