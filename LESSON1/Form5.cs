using LESSON1;

namespace MONZON_OOP_CPE201
{
    public partial class Form5 : Form
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
        private double tax;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            other_numhrs = Convert.ToDouble(textBox18.Text);
            other_rate = Convert.ToDouble(textBox17.Text);
            other_netincome = other_numhrs * other_rate;
            other_netincometxtbox.Text = other_netincome.ToString("n");
            grossincome = basic_netincome + hono_netincome +
            other_netincome; gross_incometxtbox.Text = grossincome.ToString("n");
            pagibig_contribtxtbox.Text = "100.00";

            if (grossincome > 10000)
            {
                philhealth_contribtxtbox.Text = "137.50";
            }
            else if (grossincome > 10000 && grossincome <= 11000)
            {
                philhealth_contribtxtbox.Text = "151.25";
            }
            else if (grossincome > 11000 && grossincome <= 12000)
            {
                philhealth_contribtxtbox.Text = "165.00";
            }
            else if (grossincome > 12000 && grossincome <= 13000)
            {
                philhealth_contribtxtbox.Text = "178.75";
            }
            else if (grossincome > 13000 && grossincome <= 14000)
            {
                philhealth_contribtxtbox.Text = "192.50";
            }
            else if (grossincome > 14000 && grossincome <= 15000)
            {
                philhealth_contribtxtbox.Text = "206.25";
            }
            else if (grossincome > 15000 && grossincome <= 16000)
            {
                philhealth_contribtxtbox.Text = "220.00";
            }
            else if (grossincome > 16000 && grossincome <= 17000)
            {
                philhealth_contribtxtbox.Text = "233.75";
            }
            else if (grossincome > 17000 && grossincome <= 18000)
            {
                philhealth_contribtxtbox.Text = "247.50";
            }
            else if (grossincome > 18000 && grossincome <= 19000)
            {
                philhealth_contribtxtbox.Text = "261.25";
            }
            else if (grossincome > 19000 && grossincome <= 20000)
            {
                philhealth_contribtxtbox.Text = "275.00";
            }
            else if (grossincome > 20000 && grossincome <= 21000)
            {
                philhealth_contribtxtbox.Text = "288.75";
            }
            else if (grossincome > 21000 && grossincome <= 22000)
            {
                philhealth_contribtxtbox.Text = "302.50";
            }
            else if (grossincome > 22000 && grossincome <= 23000)
            {
                philhealth_contribtxtbox.Text = "316.25";
            }
            else if (grossincome > 23000 && grossincome <= 24000)
            {
                philhealth_contribtxtbox.Text = "330.00";
            }
            else if (grossincome > 24000 && grossincome <= 25000)
            {
                philhealth_contribtxtbox.Text = "343.75";
            }
            else if (grossincome > 25000 && grossincome <= 26000)
            {
                philhealth_contribtxtbox.Text = "357.50";
            }
            else if (grossincome > 26000 && grossincome <= 27000)
            {
                philhealth_contribtxtbox.Text = "371.25";
            }
            else if (grossincome > 27000 && grossincome <= 28000)
            {
                philhealth_contribtxtbox.Text = "385.00";
            }
            else if (grossincome > 28000 && grossincome <= 29000)
            {
                philhealth_contribtxtbox.Text = "398.75";
            }
            else if (grossincome > 29000 && grossincome <= 30000)
            {
                philhealth_contribtxtbox.Text = "412.50";
            }
            else if (grossincome > 30000 && grossincome <= 31000)
            {
                philhealth_contribtxtbox.Text = "426.25";
            }
            else if (grossincome > 31000 && grossincome <= 32000)
            {
                philhealth_contribtxtbox.Text = "440.00";
            }
            else if (grossincome > 32000 && grossincome <= 33000)
            {
                philhealth_contribtxtbox.Text = "453.75";
            }
            else if (grossincome > 33000 && grossincome <= 34000)
            {
                philhealth_contribtxtbox.Text = "467.50";
            }
            else if (grossincome > 34000 && grossincome <= 35000)
            {
                philhealth_contribtxtbox.Text = "481.25";
            }
            else if (grossincome > 35000 && grossincome <= 36000)
            {
                philhealth_contribtxtbox.Text = "495.00";
            }
            else if (grossincome > 36000 && grossincome <= 37000)
            {
                philhealth_contribtxtbox.Text = "508.75";
            }
            else if (grossincome > 37000 && grossincome <= 38000)
            {
                philhealth_contribtxtbox.Text = "522.50";
            }
            else if (grossincome > 38000 && grossincome <= 39000)
            {
                philhealth_contribtxtbox.Text = "536.25";
            }
            else if (grossincome > 39000 && grossincome <= 3999.99)
            {
                philhealth_contribtxtbox.Text = "543.13";
            }
            else
            {
                philhealth_contribtxtbox.Text = "550.00";

                if (grossincome < 1000)
                {
                    sss_contribtxtbox.Text = "0.00";
                }
                else if (grossincome > 1000 && grossincome <= 1249.99)
                {
                    sss_contribtxtbox.Text = "36.30";
                }
                else if (grossincome > 1250 && grossincome <= 1749.99)
                {
                    sss_contribtxtbox.Text = "54.50";
                }
                else if (grossincome > 1750 && grossincome <= 2249.99)
                {
                    sss_contribtxtbox.Text = "72.70";
                }
                else if (grossincome > 2250 && grossincome <= 2749.99)
                {
                    sss_contribtxtbox.Text = "90.80";
                }
                else if (grossincome > 2750 && grossincome <= 3249.99)
                {
                    sss_contribtxtbox.Text = "109.00";
                }
                else if (grossincome > 3250 && grossincome <= 3749.99)
                {
                    sss_contribtxtbox.Text = "127.20";
                }
                else if (grossincome > 3750 && grossincome <= 4249.99)
                {
                    sss_contribtxtbox.Text = "145.30";
                }
                else if (grossincome > 4250 && grossincome <= 4749.99)
                {
                    sss_contribtxtbox.Text = "163.50";
                }
                else if (grossincome > 4750 && grossincome <= 5249.99)
                {
                    sss_contribtxtbox.Text = "181.70";
                }
                else if (grossincome > 5250 && grossincome <= 5749.99)
                {
                    sss_contribtxtbox.Text = "199.80";
                }
                else if (grossincome > 5750 && grossincome <= 6249.99)
                {
                    sss_contribtxtbox.Text = "218.00";
                }
                else if (grossincome > 6250 && grossincome <= 6749.99)
                {
                    sss_contribtxtbox.Text = "236.20";
                }
                else if (grossincome > 6750 && grossincome <= 7249.99)
                {
                    sss_contribtxtbox.Text = "254.30";
                }
                else if (grossincome > 7250 && grossincome <= 7749.99)
                {
                    sss_contribtxtbox.Text = "272.50";
                }
                else if (grossincome > 7750 && grossincome <= 8249.99)
                {
                    sss_contribtxtbox.Text = "290.70";
                }
                else if (grossincome > 8250 && grossincome <= 8749.99)
                {
                    sss_contribtxtbox.Text = "308.80";
                }
                else if (grossincome > 8750 && grossincome <= 9249.99)
                {
                    sss_contribtxtbox.Text = "327.00";
                }
                else if (grossincome > 9250 && grossincome <= 9749.99)
                {
                    sss_contribtxtbox.Text = "345.20";
                }
                else if (grossincome > 9750 && grossincome <= 10249.99)
                {
                    sss_contribtxtbox.Text = "363.30";
                }
                else if (grossincome > 10250 && grossincome <= 10749.99)
                {
                    sss_contribtxtbox.Text = "381.50";
                }
                else if (grossincome > 10750 && grossincome <= 11249.99)
                {
                    sss_contribtxtbox.Text = "399.70";
                }
                else if (grossincome > 11250 && grossincome <= 11749.99)
                {
                    sss_contribtxtbox.Text = "417.80";
                }
                else if (grossincome > 11750 && grossincome <= 12249.99)
                {
                    sss_contribtxtbox.Text = "436.00";
                }
                else if (grossincome > 12250 && grossincome <= 12749.99)
                {
                    sss_contribtxtbox.Text = "454.20";
                }
                else if (grossincome > 12750 && grossincome <= 13249.99)
                {
                    sss_contribtxtbox.Text = "472.30";
                }
                else if (grossincome > 13250 && grossincome <= 13749.99)
                {
                    sss_contribtxtbox.Text = "490.50";
                }
                else if (grossincome > 13750 && grossincome <= 14249.99)
                {
                    sss_contribtxtbox.Text = "508.70";
                }
                else if (grossincome > 14250 && grossincome <= 14749.99)
                {
                    sss_contribtxtbox.Text = "526.80";
                }
                else if (grossincome > 14750 && grossincome <= 15249.99)
                {
                    sss_contribtxtbox.Text = "545.00";
                }
                else if (grossincome > 15250 && grossincome <= 15749.99)
                {
                    sss_contribtxtbox.Text = "563.20";
                }
                else
                    sss_contribtxtbox.Text = "581.30";

                if (grossincome < (250000/24))
                {
                    tax_contribtxtbox.Text = "0.00";
                }
                else if (grossincome > 10416.67 && grossincome <= 16666.67)
                {
                    tax = ((((grossincome * 24) - 250000) * 0.20)/24);
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 16666.67 && grossincome <= 33333.33)
                {
                    tax = (((((grossincome * 24) - 400000) * 0.25) + 30000)/24);
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome <= 83333.33)
                {
                    tax = (((((grossincome * 24) - 800000) * 0.30) + 130000)/24);
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 83333.33 && grossincome <= 333333.33)
                {
                    tax = (((((grossincome * 24) - 2000000) * 0.32) + 490000)/24);
                    tax_contribtxtbox.Text = tax.ToString("n");
                }
                else  
                {
                    tax = (((((grossincome * 24) - 8000000) * 0.35) + 2410000)/24);
                    tax_contribtxtbox.Text = tax.ToString("n");
                }


          
            }
        
        }
    
       






        private void button5_Click(object sender, EventArgs e)
        {
            //Activity5_PrintFrm print1 = new Activity5_PrintFrm();
            //print1.printDisplayListbox.Items.AddRange(this.payslip_viewListBox.Items);
            //print1.Show();
        }
    }
}
