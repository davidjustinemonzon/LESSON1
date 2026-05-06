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
    public partial class Lesson3_Example2_Class : Form
    {
        public Lesson3_Example2_Class()
        {
            InitializeComponent();
        }

        Item_Name_Value item_Name_Value = new Item_Name_Value();
        Variables variables = new Variables();

        private void quantityTxtbox()
        {

        }

        private void GetPriceItemValue()
        {
            itemnameTxtbox.Text = (item_Name_Value.GetItemName());
            priceTxtbox.Text = (item_Name_Value.GetPrice());
        }

        private void Lesson3_Example2_Class_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                variables.amount_paid = Convert.ToDouble(amount_paidTxtbox.Text);
                variables.cash_given = Convert.ToDouble(cash_givenTxtbox.Text);
                variables.change = variables.cash_given - variables.amount_paid;
                textBox4.Text = variables.change.ToString("C");
                amount_paidTxtbox.Text = variables.amount_paid.ToString("C");
                cash_givenTxtbox.Text = variables.cash_given.ToString("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal A", "346.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal B", "675.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal C", "128.50");
            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal D", "233.50");
            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal E", "321.50");
            GetPriceItemValue();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal F", "123.50");
            GetPriceItemValue();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal G", "234.50");
            GetPriceItemValue();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal H", "456.50");
            GetPriceItemValue();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal I", "765.50");
            GetPriceItemValue();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal J", "234.50");
            GetPriceItemValue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal K", "678.50");
            GetPriceItemValue();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal L", "348.50");
            GetPriceItemValue();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal M", "300.50");
            GetPriceItemValue();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal N", "100.50");
            GetPriceItemValue();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            item_Name_Value.SetPriceItemName("Combo Meal O", "200.50");
            GetPriceItemValue();
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                variables.price = Convert.ToDouble(priceTxtbox.Text);
                variables.quantity = Convert.ToDouble(qtyTxtbox.Text);
                variables.amount_paid = variables.price * variables.quantity;
                amount_paidTxtbox.Text = variables.amount_paid.ToString("n");
                cash_givenTxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
            }
        }
    }
}
