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
        private double discounted_total, price, discounted_amt, cash_rendered, change, discount_totalgiven, qty_total, discount_amt;

        public Lesson2_Example4__Class_()
        {
            InitializeComponent();
        }

        private void quantity_price_Convert()
        {
           variables.quantity = Convert.ToInt32(quantitytxtbox.Text);
           variables.price = Convert.ToDouble(pricetextbox.Text);
        }

        private void quantityTxtbox()
        {

        }

        Item_Name_Value item_Name_Value = new Item_Name_Value();
        Variables variables = new Variables();

        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt=(variables.quantity * variables.price) - variables.discount_amt;
            discounttextbox.Text = variables.discount_amt.ToString("n");
            Discountedtextbox.Text = variables.discounted_amt.ToString("n");
        }

        public void GetPriceItemValue()
        {
            itemnametextbox.Text = (item_Name_Value.GetItemName());
            pricetextbox.Text = (item_Name_Value.GetPrice());
        }

        private void Lesson2_Example4__Class__Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0.30;
            computation_Formula_and_DisplayData();
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;

        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0.10;
            computation_Formula_and_DisplayData();
            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0.15;
            computation_Formula_and_DisplayData();
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.quantity * variables.price) * 0;
            computation_Formula_and_DisplayData();
            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            regularRbtn.Checked = false;
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            variables.quantity = Convert.ToInt32(quantitytxtbox.Text);
            variables.discount_amt = Convert.ToDouble(discounttextbox.Text);
            variables.discounted_amt = Convert.ToDouble(Discountedtextbox.Text);
            variables.cash_given = Convert.ToDouble(cashrenderedtxtbox.Text);

            variables.qty_total += variables.quantity;
            variables.discount_totalgiven += variables.discount_amt;
            variables.discount_total += variables.discounted_amt;
            variables.change = variables.cash_given - variables.discounted_amt;

            qty_totaltextbox.Text = variables.qty_total.ToString("n");
            discount_totaltextbox.Text = variables.discount_totalgiven.ToString("n");
            discounted_totaltextbox.Text = variables.discount_total.ToString("n");
            changetxtbox.Text = variables.change.ToString("n");
            cashrenderedtxtbox.Text = variables.cash_given.ToString("n");



        }

        private void label15_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal B", "675.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal C", "128.50");
            GetPriceItemValue();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal D", "233.50");
            GetPriceItemValue();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal E", "321.50");
            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal F", "123.50");
            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal G", "234.50");
            GetPriceItemValue();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal H", "456.50");
            GetPriceItemValue();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal I", "765.50");
            GetPriceItemValue();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();

        }
    }
}
