using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Activity2
{
    public partial class Activity5 : Form
    {
        private string picpath;
        private Double basic_netincome = 0.0,
            basic_numhrs = 0.0,
            basic_rate = 0.0,
            hono_netincome = 0.0,
            hono_numhrs = 0.0,
            hono_rate = 0.0,
            other_netincome = 0.0,
            other_numhrs = 0.0,
            other_rate = 0.0;

        private Double total_netincome = 0.0,
            grossincome = 0.0,
            sss_contrib = 0.0,
            pagibig_contrib = 0.0,
            philhealth_contrib = 0.0,
            tax_contrib = 0.0;

        private Double sss_loan = 0.0,
            pagibig_loan = 0.0,
            salary_loan = 0.0,
            salary_savings = 0.0,
            faculty_sav_loan = 0.0,
            other_deduction = 0.0,
            total_deduction = 0.0,
            total_contrib = 0.0,
            total_loan = 0.0;


        public Activity5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Activity5_Load(object sender, EventArgs e)
        {
            basic_netincometxtbox.Enabled = false;
            hono_netincometxtbox.Enabled = false;
            other_netincometxtbox.Enabled = false;
            netincometxtbox.Enabled = false;
            gross_incometxtbox.Enabled = false;
            total_deducttxtbox.Enabled = false;
            sss_contribtxtbox.Text = "0.00";
            pagibig_contribtxtbox.Text = "0.00";
            philhealth_contribtxtbox.Text = "0.00";
            tax_contribtxtbox.Text = "0.00";
            sss_loantxtbox.Text = "0.00";
            pagibig_loantxtbox.Text = "0.00";
            FSD_deposittxtbox.Text = "0.00";
            FS_loantxtbox.Text = "0.00";
            sal_loantxtbox.Text = "0.00";
            other_loantxtBox.Text = "0.00";
            others_loanCombo.Text = "Select other deduction";
            others_loanCombo.Items.Add("Other 1");
            others_loanCombo.Items.Add("Other 2");
            others_loanCombo.Items.Add("Other 3");
            others_loanCombo.Items.Add("Other 4");
            picpathtxtbox.Hide();


        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void netincometxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
