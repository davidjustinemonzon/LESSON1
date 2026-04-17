using Lesson_2_Activity;
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
    public partial class MENUSTRIP : Form
    {
        public MENUSTRIP()
        {
            InitializeComponent(); this.IsMdiContainer = true;
        }

        private void aCTIVITY1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1 newMDIChild = new Activity1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void aCITIVITY2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACT2 newMDIChild = new ACT2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void eXAMPLE3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example_3 newMDIChild = new Example_3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void aCITIVITY4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4 newMDIChild = new Activity4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void lESSON7EXAMPLE4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LESSON7_EX4 newMDIChild = new LESSON7_EX4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void lESSON7EXAMPLE5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LESSON7_EX5 newMDIChild = new LESSON7_EX5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void lESSON7EXAMPLE6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LESSON7_EX6 newMDIChild = new LESSON7_EX6();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
