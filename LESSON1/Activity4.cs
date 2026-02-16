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
            discounted_amounttxtbox.Text = "200.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(food_bundleA.Text + " + pricetxtbox.Text");
            displayListbox.Items.Add("Discounted Amount: " + "" + discounted_amounttxtbox.Text);
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
            discounted_amounttxtbox.Text = "(15% of the Price) P194.85";
            displayListbox.Items.Add(food_bundleA.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            cash_given = Convert.ToDouble(textBox7.Text);
            total_amountPaid = Convert.ToDouble(total_billstxtbox.Text);
            displayListbox.Items.Add("Total Bills: " + "" + total_billstxtbox.Text);
            displayListbox.Items.Add("Cash Given: " + "" + textBox7.Text);
            displayListbox.Items.Add("Change: " + "" + changetxtbox.Text);
            displayListbox.Items.Add("Total No. of Items: " + total_qtytxtbox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LESSON1.Activity4_PrintFrm print = new LESSON1.Activity4_PrintFrm();
            print.printDisplayListbox.Items.Addrange(this.displayListbox.Items);
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

            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;
            radioButton25.Checked = false;
            radioButton26.Checked = false;
            radioButton27.Checked = false;
            radioButton28.Checked = false;
            radioButton29.Checked = false;
            radioButton30.Checked = false;
            radioButton31.Checked = false;
            radioButton32.Checked = false;

            displayListbox.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtytxtbox_TextChanged(object sender, EventArgs e)
        {
            double price, discounted_amount, discount_amount;
        }
    }
}
