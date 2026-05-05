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
    public partial class Activity4_PrintFrm : Form
    {
        public Activity4_PrintFrm(ListBox.ObjectCollection items)
        {
            InitializeComponent(); this.IsMdiContainer = true;
            printDisplayListBox.Items.AddRange(printDisplayListBox.Items);
        }

        private void Activity4_PrintFrm_Load(object sender, EventArgs e)
        {
          
        }

        private void printDisplayListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
