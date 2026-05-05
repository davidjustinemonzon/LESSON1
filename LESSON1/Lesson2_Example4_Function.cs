using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Lesson2_Example4_Function : Form
    {

        private int qty;
        private double price, discounted_amt, cash_rendered, change ,discount_totalgiven, discounted_total, qty_total, discount_amt;
        public Lesson2_Example4_Function()
        {
            InitializeComponent();
        }

        private void quantityTxtbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }

        private void quanity_price_Convert()
        {
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
        }

        private void computation_Formula_and_Displaydata()
        {
            discounted_amt = (price * qty) - discount_amt;
            discounttextbox.Text = discount_amt.ToString("n");
            Discountedtextbox.Text = discounted_amt.ToString("n");
        }

        public void price_item_TextValue(string itemname, string price)
        {
            itemnametextbox.Text = itemname;
            pricetextbox.Text = price;
        }

        private void Lesson2_Example4_Function_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal A", "89.50");
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label16.Text, "101.50");
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label17.Text, "111.50");
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label18.Text, "120.50");
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label19.Text, "90.50");
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label24.Text, "101.50");
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label23.Text, "123.50");
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label22.Text, "188.00");
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label21.Text, "680.50");
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label20.Text, "199.50");
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label29.Text, "146.50");
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label28.Text, "181.50");
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label27.Text, "191.50");
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label26.Text, "171.50");
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label25.Text, "185.50");
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label34.Text, "121.50");
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label33.Text, "135.50");
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label32.Text, "178.50");
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label31.Text, "199.50");
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label30.Text, "121.50");
            quantityTxtbox();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quanity_price_Convert();
                discount_amt = (price * qty) * 0.30;
                computation_Formula_and_Displaydata();
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantityTxtbox();
            }
        }
        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quanity_price_Convert();
                discount_amt = (price * qty) * 0.30;
                computation_Formula_and_Displaydata();
                radioButton1.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantityTxtbox();
            }
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quanity_price_Convert();
                discount_amt = (price * qty) * 0.15;
                computation_Formula_and_Displaydata();
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                noTaxRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantityTxtbox();
            }
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quanity_price_Convert();
                discount_amt = (price * qty) * 0;
                computation_Formula_and_Displaydata();
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantityTxtbox();
            }
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {

           
            try
            {
                qty = Convert.ToInt32(quantitytxtbox.Text);
                discount_amt = Convert.ToDouble(discounttextbox.Text);
                discounted_amt = Convert.ToDouble(Discountedtextbox.Text);
                cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);
                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;
                change = cash_rendered - discounted_amt;
                qty_totaltextbox.Text = qty_total.ToString("n");
                discount_totaltextbox.Text = discount_totalgiven.ToString("n");
                discounted_totaltextbox.Text = discounted_total.ToString("n");
                changetxtbox.Text = change.ToString("n");
                cashrenderedtxtbox.Text = cash_rendered.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                cashrenderedtxtbox.Clear();
                cashrenderedtxtbox.Focus();
            }


        }
    }
}
