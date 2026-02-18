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

        private double netincome;

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

        private void button2_Click(object sender, EventArgs e)
        {
            sss_contrib = Convert.ToDouble(sss_contribtxtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribtxtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribtxtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribtxtbox.Text);
            sss_loan = Convert.ToDouble(sss_loantxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loantxtbox.Text);
            salary_loan = Convert.ToDouble(sal_loantxtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FS_loantxtbox.Text);
            salary_savings = Convert.ToDouble(FSD_deposittxtbox.Text);
            other_deduction = Convert.ToDouble(other_loantxtBox.Text);

            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            total_deducttxtbox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            netincometxtbox.Text = netincome.ToString("n");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            payslip_viewListBox.Items.Add("Employee Number: " + emp_nutxtbox.Text);
            payslip_viewListBox.Items.Add("Firstname: " + emp_fnametxtbox.Text);
            payslip_viewListBox.Items.Add("Middlename: " + emp_mnametxtbox.Text);
            payslip_viewListBox.Items.Add("Surname: " + emp_lnametxtbox.Text);
            payslip_viewListBox.Items.Add("Designation: " + desigtxtbox.Text);
            payslip_viewListBox.Items.Add("Employee Status: " + empstatustxtbox.Text);
            payslip_viewListBox.Items.Add("Department: " + deptnametxtbox.Text);
            payslip_viewListBox.Items.Add("Pay Date: " + pdatepicker.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("BP Num. of Hrs.: " + textBox10.Text);
            payslip_viewListBox.Items.Add("BP Rate / Hr: " + textBox11.Text);
            payslip_viewListBox.Items.Add("Basic Net Income: " + basic_netincometxtbox.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("HI Num. of Hrs.: " + textBox15.Text);
            payslip_viewListBox.Items.Add("HI Rate / Hr: " + textBox14.Text);
            payslip_viewListBox.Items.Add("Honorarium Net Income: " + hono_netincometxtbox.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("OTI Num. of Hrs.: " + textBox18.Text);
            payslip_viewListBox.Items.Add("OTI Rate / Hr: " + textBox17.Text);
            payslip_viewListBox.Items.Add("Other Net Income: " + other_netincometxtbox.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("SSS Contribution: " + sss_contribtxtbox.Text);
            payslip_viewListBox.Items.Add("PhilHealth Contribution: " + philhealth_contribtxtbox.Text);
            payslip_viewListBox.Items.Add("Pag-IBIG Contribution: " + pagibig_contribtxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Deposit: " + FSD_deposittxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Loan: " + FS_loantxtbox.Text);
            payslip_viewListBox.Items.Add("Salary Loan: " + sal_loantxtbox.Text);
            payslip_viewListBox.Items.Add("Other Loan: " + other_loantxtBox.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("Total Deduction: " + total_deducttxtbox.Text);
            payslip_viewListBox.Items.Add("Gross Income: " + gross_incometxtbox.Text);
            payslip_viewListBox.Items.Add("Net Income: " + netincometxtbox.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            empstatustxtbox.Clear();
            desigtxtbox.Clear();
            emp_lnametxtbox.Clear();
            emp_mnametxtbox.Clear();
            emp_fnametxtbox.Clear();
            emp_nutxtbox.Clear();
            deptnametxtbox.Clear();
            textBox10.Clear();
            textBox11.Clear();
            basic_netincometxtbox.Clear();
            textBox15.Clear();
            textBox14.Clear();
            hono_netincometxtbox.Clear();
            textBox18.Clear();
            textBox17.Clear();
            other_netincometxtbox.Clear();
            netincometxtbox.Clear();
            total_deducttxtbox.Clear();
            sal_loantxtbox.Clear();
            FSD_deposittxtbox.Clear();
            FS_loantxtbox.Clear();
            pagibig_loantxtbox.Clear();
            sss_loantxtbox.Clear();
            other_loantxtBox.Clear();
            sss_contribtxtbox.Clear();
            pagibig_contribtxtbox.Clear();
            philhealth_contribtxtbox.Clear();
            tax_contribtxtbox.Clear();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            empstatustxtbox.Clear();
            desigtxtbox.Clear();
            emp_lnametxtbox.Clear();
            emp_mnametxtbox.Clear();
            emp_fnametxtbox.Clear();
            emp_nutxtbox.Clear();
            deptnametxtbox.Clear();
            textBox10.Clear();
            textBox11.Clear();
            basic_netincometxtbox.Clear();
            textBox15.Clear();
            textBox14.Clear();
            hono_netincometxtbox.Clear();
            textBox18.Clear();
            textBox17.Clear();
            other_netincometxtbox.Clear();
            netincometxtbox.Clear();
            total_deducttxtbox.Clear();
            sal_loantxtbox.Clear();
            FSD_deposittxtbox.Clear();
            FS_loantxtbox.Clear();
            pagibig_loantxtbox.Clear();
            sss_loantxtbox.Clear();
            other_loantxtBox.Clear();
            sss_contribtxtbox.Clear();
            pagibig_contribtxtbox.Clear();
            philhealth_contribtxtbox.Clear();
            tax_contribtxtbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File |*.gif;*.jpg;*.png;*,bmp";
            openFileDialog.Title = " Select Employee Picture";
            openFileDialog.ShowDialog();
            //picpath = openFileDialog.FileNames;
            picpathtxtbox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = Double.Parse(textBox11.Text);
            basic_rate = Convert.ToDouble(textBox10.Text);
            basic_netincome = basic_numhrs * basic_rate; basic_netincometxtbox.Text = basic_netincome.ToString("n");
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Convert.ToDouble(textBox14.Text); hono_rate = Convert.ToDouble(textBox15.Text);
            hono_netincome = hono_numhrs * hono_rate; hono_netincometxtbox.Text = hono_netincome.ToString("n");
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(textBox18.Text); other_rate = Convert.ToDouble(textBox17.Text);
            other_netincome = other_numhrs * other_rate; other_netincometxtbox.Text = other_netincome.ToString("n");
            grossincome = basic_netincome + hono_netincome +
            other_netincome; gross_incometxtbox.Text = grossincome.ToString("n");
        }
    }
}
