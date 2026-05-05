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
    public partial class Lesson3_Example2_Function : Form
    {
        private double amount_paid, price, cash_given, change;
        private int quantity;

        public Lesson3_Example2_Function()
        {
            InitializeComponent();
        }

        private void displayTxtbox(string itemname, string price)
        {
            itemnameTxtbox.Text = itemname;
            priceTxtbox.Text = price;
        }

        private void quantityTxtbox()
        {
            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }


        private void Lesson3_Example2_Function_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal A", "90.50");
            quantityTxtbox();

        }

        private void priceTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal B", "120.50");
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal C", "150.00");
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal D", "100.50");
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal 1", "95.88");
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal 2", "90.50");
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal 3", "120.50");
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal 4", "90.50");
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Combo A", "90.50");
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Combo B", "120.50");
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Combo C", "190.50");
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Combo D", "190.00");
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Double A", "90.50");
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Double B", "99.50");
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal Double C", "110.50");
            quantityTxtbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            price = Convert.ToDouble(priceTxtbox.Text);
            quantity = Convert.ToInt32(qtyTxtbox.Text);
            cash_given = Convert.ToDouble(cash_givenTxtbox.Text);
            amount_paid = price * quantity;
            change = cash_given - amount_paid;
            amount_paidTxtbox.Text = amount_paid.ToString("n");
            textBox4.Text = change.ToString("n");
            cash_givenTxtbox.Focus();

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            qtyTxtbox.Clear();
            amount_paidTxtbox.Clear();
            cash_givenTxtbox.Clear();
            textBox4.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
