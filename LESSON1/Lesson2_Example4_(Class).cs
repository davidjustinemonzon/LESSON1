using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Lesson2_Example4__Class_ : Form
    {
        private int qty;
        private double price, discounted_amt, cash_rendered, change, discount_totalgiven, discounted_total, qty_total, discount_amt;

        public Lesson2_Example4__Class_()
        {
            InitializeComponent();
        }


        


        private void GetPriceItemValue()
        {
            //Price_Item_Value price_item_value = new Price_Item_Value();
            //Variables variables = new Variables();

            //itemnametextbox.Text = (price_item_value.GetItemName());
             //pricetextbox.Text = (price_item_value.GetPrice());
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

        private void Lesson2_Example4__Class__Load(object sender, EventArgs e)
        {
            
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
                //variables.amount_paid = Convert.ToDouble(cashrenderedtxtbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                cashrenderedtxtbox.Clear();
                cashrenderedtxtbox.Focus();
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }
    }
}
