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


        Item_Name_Value item_Name_Value = new Item_Name_Value();
        Variables variables = new Variables();


        private void GetPriceItemValue()
        {


            itemnametextbox.Text = (item_Name_Value.GetItemName());
            pricetextbox.Text = (item_Name_Value.GetPrice());
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
                variables.amount_paid = Convert.ToDouble(discounted_totaltextbox.Text);
                variables.cash_given = Convert.ToDouble(cashrenderedtxtbox.Text);
                variables.change = variables.cash_given - variables.amount_paid;
                changetxtbox.Text = variables.change.ToString("C");
                discounted_totaltextbox.Text = variables.amount_paid.ToString("C");
                cashrenderedtxtbox.Text = variables.cash_given.ToString("C");
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
            price_item_TextValue("Combo Meal A", "346.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal B", "986.50");
            GetPriceItemValue();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal C", "654.50");
            GetPriceItemValue();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal D", "314.50");
            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal E", "134.50");
            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal F", "125.50");
            GetPriceItemValue();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal G", "167.50");
            GetPriceItemValue();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal H", "15.50");
            GetPriceItemValue();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal I", "812.50");
            GetPriceItemValue();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal J", "129.50");
            GetPriceItemValue();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal K", "280.50");
            GetPriceItemValue();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal L", "120.50");
            GetPriceItemValue();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal M", "230.50");
            GetPriceItemValue();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal N", "200.50");
            GetPriceItemValue();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal O", "892.50");
            GetPriceItemValue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal P", "893.50");
            GetPriceItemValue();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal A", "895.50");
            GetPriceItemValue();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal A", "400.50");
            GetPriceItemValue();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal A", "150.50");
            GetPriceItemValue();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal A", "77.50");
            GetPriceItemValue();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Combo Meal A", "90.50");
            GetPriceItemValue();
        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                variables.price = Convert.ToDouble(discounted_totaltextbox.Text);
                variables.quantity = Convert.ToDouble(quantitytxtbox.Text);
                variables.amount_paid = variables.price * variables.quantity;
                discounted_totaltextbox.Text = variables.amount_paid.ToString("n");
                cashrenderedtxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
            }
        }
    }
}
