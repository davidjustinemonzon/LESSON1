using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LESSON1
{
    public partial class Activity4 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;
        
        public Activity4()
        {
            InitializeComponent();
        }

        private void EXAMPLE3_Load(object sender, EventArgs e)
        {
            pricetxtbox.Enabled = false;
            discounted_amounttxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            total_billstxtbox.Enabled = false;
            discount_amounttxtbox.Enabled = false;
            total_qtytxtbox.Enabled = false;

            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;

            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton11.Enabled = false;
            radioButton12.Enabled = false;

        }

        // Add this method to your Activity4 class to fix CS1061
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // You can add logic here if needed, or leave it empty if not required
        }

        private void pricetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void food_bundleA_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.LightCyan;
            food_bundleB.Checked = false;

            radioButton3.Checked = true;
            radioButton4.Checked = true;
            radioButton5.Checked = true;
            radioButton6.Checked = true;
            radioButton7.Checked = true;

            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;

            pricetxtbox.Text = "1000.00";
            discount_amounttxtbox.Text = "200.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(food_bundleB.Text + pricetxtbox.Text);
            displayListbox.Items.Add("Discounted Amount: " + discount_amounttxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();




        }

        private void food_bundleB_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            food_bundleA.Checked = false;

            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            radioButton8.Checked = true;
            radioButton9.Checked = true;
            radioButton10.Checked = true;
            radioButton11.Checked = true;
            radioButton12.Checked = true;

            pricetxtbox.Text = "P1,299.00";
            discount_amounttxtbox.Text = "(15% of the Price) P194.85";
            displayListbox.Items.Add(food_bundleA.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            cash_given = Convert.ToDouble(textBox7.Text);
            total_amountPaid = Convert.ToDouble(total_billstxtbox.Text);
            change = cash_given - total_amountPaid ;
            changetxtbox.Text = change.ToString("n");
            displayListbox.Items.Add("Total Bills: " + total_billstxtbox.Text);
            displayListbox.Items.Add("Cash Given: " + textBox7.Text);
            displayListbox.Items.Add("Change: " + changetxtbox.Text);
            displayListbox.Items.Add("Total No. of Items: " + total_qtytxtbox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
         LESSON1.Activity4_PrintFrm print = new Activity4_PrintFrm(displayListbox.Items);
            //print.printDisplayListbox.Items.AddRange(this.displayListbox.Items);
            print.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayListbox.Items.RemoveAt(displayListbox.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            food_bundleA.Checked = false;
            food_bundleB.Checked = false;

            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;

            pricetxtbox.Clear();
            qtytxtbox.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;

            displayListbox.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtytxtbox_TextChanged(object sender, EventArgs e)
        {
            double price, discounted_amount, discount_amount;
            int qty;
            price = Convert.ToDouble(pricetxtbox.Text);
            qty = Convert.ToInt32(qtytxtbox.Text);
            discount_amount = Convert.ToDouble(discount_amounttxtbox.Text);
            discounted_amount = (price * qty) - discount_amount;
            total_qty += qty;
            total_qtytxtbox.Text = total_qty.ToString();
            total_amount += discounted_amount;
            total_billstxtbox.Text = total_amount.ToString("n");
            discounted_amounttxtbox.Text = discounted_amount.ToString("n");
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "500.99";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox1.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "550.99";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox2.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "600.99";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox3.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "700.50";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox4.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "500.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox5.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "750.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox10.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "700.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox9.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "850.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox8.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "450.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox7.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "650.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox6.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox15.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox14.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox13.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox12.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox11.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox20.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox19.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox18.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox17.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_amounttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(checkBox16.Text + pricetxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }
    }
}
