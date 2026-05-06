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
            
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            variables.quantity = Convert.ToInt32(quantitytxtbox.Text);
            variables.discount_amt = Convert.ToDouble(discounttextbox.Text);
            variables.discounted_amt = Convert.ToDouble(Discountedtextbox.Text);
            variables.cash_given = Convert.ToDouble(cashrenderedtxtbox.Text);

            //variables.

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

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {

           
        }
    }
}
