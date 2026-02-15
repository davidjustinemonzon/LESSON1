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

        }

        // Add this method to your Activity4 class to fix CS1061
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // You can add logic here if needed, or leave it empty if not required
        }
    }
}
