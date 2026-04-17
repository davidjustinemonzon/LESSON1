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
    public partial class LESSON7_EX6 : Form
    {
        public LESSON7_EX6()
        {
            InitializeComponent();
        }

        private void LESSON7_EX6_Load(object sender, EventArgs e)
        {
            CountryCombobox.Items.Add("South Korea");
            CountryCombobox.Items.Add("Thailand");
            CountryCombobox.Items.Add("Hawaii");
            CountryCombobox.Items.Add("Hongkong");
            CountryCombobox.Items.Add("Canada");
            CountryCombobox.Items.Add("Japan");
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            int InitialValue = 0;
            int numTimesDisplay;
            numTimesDisplay = Convert.ToInt32(NumTimesDisplayTxtbox.Text);
            do
            {
                displayListbox.Items.Add(CountryCombobox.Text);
                InitialValue++;
            } while (InitialValue <= numTimesDisplay);
        }
    }
}
