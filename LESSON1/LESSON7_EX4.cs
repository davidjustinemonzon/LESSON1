using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class LESSON7_EX4 : Form
    {
        private double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00,
            grossincome = 0.00,
            tax = 0;

        private double sss_contrib, pagibig_contrib, philhealth_contrib, total_deduction, net_income;

        public LESSON7_EX4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LESSON7_EX4_Load(object sender, EventArgs e)
        {
            Basic_IncomepercutoffTxtbox.Enabled = false;
            Hono_totalpayTxtbox.Enabled = false;
            Other_totalpayTxtbox.Enabled = false;
            NetIncomeTxtbox.Enabled = false;
            GrossIncomeTxtbox.Enabled = false;
            TotalDeductionTxtbox.Enabled = false;
            SSS_ContribTxtbox.Enabled = false;
            Pagibig_ContribTxtbox.Enabled = false;
            PhilHealth_ContribTxtbox.Enabled = false;
            TaxtTxtbox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sss_contrib = Convert.ToDouble(SSS_ContribTxtbox.Text);
                pagibig_contrib = Convert.ToDouble(Pagibig_ContribTxtbox.Text);
                philhealth_contrib = Convert.ToDouble(PhilHealth_ContribTxtbox.Text);
                tax = Convert.ToDouble(TaxtTxtbox.Text);
                total_deduction = sss_contrib + pagibig_contrib + philhealth_contrib + tax;
                net_income = grossincome - total_deduction;
                TotalDeductionTxtbox.Text = total_deduction.ToString("C");
                GrossIncomeTxtbox.Text = grossincome.ToString("C");
                NetIncomeTxtbox.Text = net_income.ToString("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                other_numhrs = Convert.ToDouble(Other_CutoffTxtbox.Text);
                other_rate = Convert.ToDouble(Other_RateTxtbox.Text);
                other_netincome = other_numhrs * other_rate;
                Other_totalpayTxtbox.Text = other_netincome.ToString("n");
                grossincome = basic_netincome + hono_netincome + other_netincome;
                GrossIncomeTxtbox.Text = grossincome.ToString("n");

                //computation for philhealth contributions
                double philhealth_value = 0;
                if (grossincome < 10000)
                {
                    philhealth_value = 137.50;
                }
                else
                {
                    double philhealth_employshare = 137.50;

                    for (int x = 10000; x <= 40000; x += 1000)
                    {
                        if (grossincome >= x && grossincome < x + 1000 || grossincome > x + 1000)
                        {
                            philhealth_value = philhealth_employshare;
                        }
                        philhealth_employshare += 13.75;
                    }
                }
                PhilHealth_ContribTxtbox.Text = philhealth_value.ToString("N");

                //computation for sss contributions
                double sss_value = 0;
                if (grossincome <= 1000)
                {
                    sss_value = 36.30;
                }
                else
                {
                    double sss_employshare = 36.30;
                    for (int x = 1000; x <= 15750; x += 500)
                    {
                        if (grossincome >= x && grossincome < x + 500 || grossincome > x + 500)
                        {
                            sss_value = sss_employshare;
                        }
                        sss_employshare += 18.20;
                    }
                }
                SSS_ContribTxtbox.Text = sss_value.ToString("N");

                //tax contribution per month based from the new table of tax 2019
                if (grossincome < (250000 / 24))
                {
                    TaxtTxtbox.Text = "0.00";
                }
                else if (grossincome > 10416.67 && grossincome <= 16666.67)
                {
                    tax = ((((grossincome * 24) - 250000) * 0.20) / 24);
                    TaxtTxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 16666.67 && grossincome < 33333.33)
                {
                    tax = (((((grossincome * 24) - 400000) * 0.25) + 30000) / 24);
                    TaxtTxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome < 83333.33)
                {
                    tax = (((((grossincome * 24) - 800000) * 0.30) + 130000) / 24);
                    TaxtTxtbox.Text = tax.ToString("n");
                }
                else if (grossincome > 83333.33 && grossincome < 333333.33)
                {
                    tax = (((((grossincome * 24) - 2000000) * 0.32) + 490000) / 24);
                    TaxtTxtbox.Text = tax.ToString("n");
                }
                else
                {
                    tax = (((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24);
                    TaxtTxtbox.Text = tax.ToString("n");
                }
                Pagibig_ContribTxtbox.Text = "100";
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void Hono_CutoffTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hono_numhrs = Convert.ToDouble(Hono_CutoffTxtbox.Text);
                hono_rate = Convert.ToDouble(Hono_RateTxtbox.Text);
                hono_netincome = hono_numhrs * hono_rate;
                Hono_totalpayTxtbox.Text = hono_netincome.ToString("n");
                grossincome = basic_netincome + hono_netincome + other_netincome;
                GrossIncomeTxtbox.Text = grossincome.ToString("n");

            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                basic_numhrs = Convert.ToDouble(Basic_CutoffTxtbox.Text);
                basic_rate = Convert.ToDouble(Basic_RateTxtbox.Text);
                basic_netincome = basic_numhrs * basic_rate;
                Basic_IncomepercutoffTxtbox.Text = basic_netincome.ToString("n");

                grossincome = basic_netincome + hono_netincome + other_netincome;
                GrossIncomeTxtbox.Text = grossincome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
