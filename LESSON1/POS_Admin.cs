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
    public partial class POS_Admin : Form
    {
       // pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;

        public POS_Admin()
        {
           // posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            try
            {
                P1.Clear(); P11.Clear();
                P2.Clear(); P12.Clear();
                P3.Clear(); P13.Clear();
                P4.Clear(); P14.Clear();
                P5.Clear(); P15.Clear();
                P6.Clear(); P16.Clear();
                P7.Clear(); P17.Clear();
                P8.Clear(); P18.Clear();
                P9.Clear(); P19.Clear();
                P10.Clear(); P20.Clear();

                PICP1.Clear(); PICP11.Clear();
                PICP2.Clear(); PICP12.Clear();
                PICP3.Clear(); PICP13.Clear();
                PICP4.Clear(); PICP14.Clear();
                PICP5.Clear(); PICP15.Clear();
                PICP6.Clear(); PICP16.Clear();
                PICP7.Clear(); PICP17.Clear();
                PICP8.Clear(); PICP18.Clear();
                PICP9.Clear(); PICP19.Clear();
                PICP10.Clear(); PICP20.Clear();

                N1.Clear(); N11.Clear();
                N2.Clear(); N12.Clear();
                N3.Clear(); N13.Clear();
                N4.Clear(); N14.Clear();
                N5.Clear(); N15.Clear();
                N6.Clear(); N16.Clear();
                N7.Clear(); N17.Clear();
                N8.Clear(); N18.Clear();
                N9.Clear(); N19.Clear();
                N10.Clear(); N20.Clear();

                pictureBox1.Image = pic;
                pictureBox2.Image = pic;
                pictureBox3.Image = pic;
                pictureBox4.Image = pic;
                pictureBox5.Image = pic;
                pictureBox6.Image = pic;
                pictureBox7.Image = pic;
                pictureBox8.Image = pic;
                pictureBox9.Image = pic;
                pictureBox10.Image = pic;
                pictureBox11.Image = pic;
                pictureBox12.Image = pic;
                pictureBox13.Image = pic;
                pictureBox14.Image = pic;
                pictureBox15.Image = pic;
                pictureBox16.Image = pic;
                pictureBox17.Image = pic;
                pictureBox18.Image = pic;
                pictureBox19.Image = pic;
                pictureBox20.Image = pic;



            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

        private void open_file_image()
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void POS_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                PICP1.Hide(); PICP11.Hide();
                PICP2.Hide(); PICP12.Hide();
                PICP3.Hide(); PICP13.Hide();
                PICP4.Hide(); PICP14.Hide();
                PICP5.Hide(); PICP15.Hide();
                PICP6.Hide(); PICP16.Hide();
                PICP7.Hide(); PICP17.Hide();
                PICP8.Hide(); PICP18.Hide();
                PICP9.Hide(); PICP19.Hide();
                PICP10.Hide(); PICP20.Hide();

              //  posdb_connect.pos_select();
               // posdb_connect.pos_cmd();
               // posdb_connect.pos_sqladapterSelect();
                //datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

            }

            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
