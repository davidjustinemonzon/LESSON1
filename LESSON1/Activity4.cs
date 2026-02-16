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




        }

        private void food_bundleB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
