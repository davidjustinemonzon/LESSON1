using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LESSON1
{
    public partial class POS_Admin : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;

        public POS_Admin()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            try
            {
                pic = Image.FromFile("C:\\Users\\C203-13\\Downloads\\difim.png");

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
                pictureBox6.Image = pic;
                pictureBox11.Image = pic;
                pictureBox16.Image = pic;
                pictureBox17.Image = pic;
                pictureBox12.Image = pic;
                pictureBox7.Image = pic;
                pictureBox2.Image = pic;
                pictureBox18.Image = pic;
                pictureBox13.Image = pic;
                pictureBox8.Image = pic;
                pictureBox3.Image = pic;
                pictureBox19.Image = pic;
                pictureBox14.Image = pic;
                pictureBox9.Image = pic;
                pictureBox4.Image = pic;
                pictureBox20.Image = pic;
                pictureBox15.Image = pic;
                pictureBox10.Image = pic;
                pictureBox5.Image = pic;



            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

        private void open_file_image()
        {
            openFileDialog1.Filter = "Image File |*.jpg;*.jpeg;*.png;*.bmp";
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

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

            }

            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Insert into name table
                posdb_connect.pos_sql = "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) VALUES ('" + comboBox1.Text + "','" + N1.Text + "','" + N2.Text + "','" + N3.Text + "','" + N4.Text + "','" + N5.Text + "','" + N6.Text + "','" + N6.Text + "','" + N6.Text + "','" + N6.Text + "','" + N6.Text + "','" + N6.Text + "','" + N7.Text + "','" + N13.Text + "','" + N14.Text + "','" + N15.Text + "','" + N16.Text + "','" + N17.Text + "','" + N18.Text + "','" + N19.Text + "','" + N20.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                // Insert into price table
                posdb_connect.pos_sql = "INSERT INTO pos_priceTbl (price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) VALUES ('" + P1.Text + "','" + P2.Text + "','" + P3.Text + "','" + P4.Text + "','" + P5.Text + "','" + P6.Text + "','" + P7.Text + "','" + P8.Text + "','" + P9.Text + "','" + P10.Text + "','" + P11.Text + "','" + P12.Text + "','" + P13.Text + "','" + P14.Text + "','" + P15.Text + "','" + P16.Text + "','" + P17.Text + "','" + P18.Text + "','" + P19.Text + "','" + P20.Text + "','" + comboBox1.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                // Insert into picture path table
                posdb_connect.pos_sql = "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id) VALUES ('" + PICP1.Text + "','" + PICP2.Text + "','" + PICP3.Text + "','" + PICP4.Text + "','" + PICP5.Text + "','" + PICP6.Text + "','" + PICP7.Text + "','" + PICP8.Text + "','" + PICP9.Text + "','" + PICP10.Text + "','" + PICP11.Text + "','" + PICP12.Text + "','" + PICP13.Text + "','" + PICP14.Text + "','" + PICP15.Text + "','" + PICP16.Text + "','" + PICP17.Text + "','" + PICP18.Text + "','" + PICP19.Text + "','" + PICP20.Text + "','" + comboBox1.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                // Refresh view
                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
           }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SEARCH button logic
            try
            {
                // 1. Define the SQL Query with JOINs
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl " +
                                        "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                                        "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                                        "WHERE pos_nameTbl.pos_id = '" + comboBox1.Text + "'";

                // 2. Execute and Fill Dataset
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                // 3. Display in DataGrid
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

                // 4. Map Name TextBoxes (N) - Indexes [2] to [21]
                N1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                N2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                N3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                N4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                N5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                N6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                N7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                N8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                N9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                N10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                N11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                N12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                N13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                N14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                N15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                N16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                N17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                N18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                N19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                N20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                // 5. Map Picture Path TextBoxes (PICP) and Images - Indexes [24] to [43]
                PICP1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                pictureBox1.Image = Image.FromFile(PICP1.Text);
                PICP2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                pictureBox6.Image = Image.FromFile(PICP2.Text);
                PICP3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                pictureBox11.Image = Image.FromFile(PICP3.Text);
                PICP4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                pictureBox16.Image = Image.FromFile(PICP4.Text);
                PICP5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                pictureBox17.Image = Image.FromFile(PICP5.Text);
                PICP6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                pictureBox12.Image = Image.FromFile(PICP6.Text);
                PICP7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                pictureBox7.Image = Image.FromFile(PICP7.Text);
                PICP8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                pictureBox2.Image = Image.FromFile(PICP8.Text);
                PICP9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                pictureBox18.Image = Image.FromFile(PICP9.Text);
                PICP10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                pictureBox13.Image = Image.FromFile(PICP10.Text);
                PICP11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                pictureBox8.Image = Image.FromFile(PICP11.Text);
                PICP12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                pictureBox3.Image = Image.FromFile(PICP12.Text);
                PICP13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                pictureBox19.Image = Image.FromFile(PICP13.Text);
                PICP14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                pictureBox14.Image = Image.FromFile(PICP14.Text);
                PICP15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                pictureBox9.Image = Image.FromFile(PICP15.Text);
                PICP16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                pictureBox4.Image = Image.FromFile(PICP16.Text);
                PICP17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                pictureBox20.Image = Image.FromFile(PICP17.Text);
                PICP18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                pictureBox15.Image = Image.FromFile(PICP18.Text);
                PICP19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                pictureBox10.Image = Image.FromFile(PICP19.Text);
                PICP20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                pictureBox5.Image = Image.FromFile(PICP20.Text);

                // 6. Map Price TextBoxes (P) - Indexes [46] to [65]
                P1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                P2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                P3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                P4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                P5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                P6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                P7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                P8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                P9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                P10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                P11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                P12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                P13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                P14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                P15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                P16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                P17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                P18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                P19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                P20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // UPDATE Button Logic
            try
            {
                // Update Name Table
                posdb_connect.pos_sql = "UPDATE pos_nameTbl SET name1 = '" + N1.Text + "', name2 = '" + N2.Text + "', name3 = '" + N3.Text + "', name4 = '" + N4.Text + "', name5 = '" + N5.Text + "', name6 = '" + N6.Text + "', name7 = '" + N7.Text + "', name8 = '" + N8.Text + "', name9 = '" + N9.Text + "', name10 = '" + N10.Text + "', name11 = '" + N11.Text + "', name12 = '" + N12.Text + "', name13 = '" + N13.Text + "', name14 = '" + N14.Text + "', name15 = '" + N15.Text + "', name16 = '" + N16.Text + "', name17 = '" + N17.Text + "', name18 = '" + N18.Text + "', name19 = '" + N19.Text + "', name20 = '" + N20.Text + "' WHERE pos_id = '" + comboBox1.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                // Update Price Table
                posdb_connect.pos_sql = "UPDATE pos_priceTbl SET price1 = '" + P1.Text + "', price2 = '" + P2.Text + "', price3 = '" + P3.Text + "', price4 = '" + P4.Text + "', price5 = '" + P5.Text + "', price6 = '" + P6.Text + "', price7 = '" + P7.Text + "', price8 = '" + P8.Text + "', price9 = '" + P9.Text + "', price10 = '" + P10.Text + "', price11 = '" + P11.Text + "', price12 = '" + P12.Text + "', price13 = '" + P13.Text + "', price14 = '" + P14.Text + "', price15 = '" + P15.Text + "', price16 = '" + P16.Text + "', price17 = '" + P17.Text + "', price18 = '" + P18.Text + "', price19 = '" + P19.Text + "', price20 = '" + P20.Text + "' WHERE pos_id = '" + comboBox1.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                // Update Picture Path Table
                posdb_connect.pos_sql = "UPDATE pos_picTbl SET pic1 = '" + PICP1.Text + "', pic2 = '" + PICP2.Text + "', pic3 = '" + PICP3.Text + "', pic4 = '" + PICP4.Text + "', pic5 = '" + PICP5.Text + "', pic6 = '" + PICP6.Text + "', pic7 = '" + PICP7.Text + "', pic8 = '" + PICP8.Text + "', pic9 = '" + PICP9.Text + "', pic10 = '" + PICP10.Text + "', pic11 = '" + PICP11.Text + "', pic12 = '" + PICP12.Text + "', pic13 = '" + PICP13.Text + "', pic14 = '" + PICP14.Text + "', pic15 = '" + PICP15.Text + "', pic16 = '" + PICP16.Text + "', pic17 = '" + PICP17.Text + "', pic18 = '" + PICP18.Text + "', pic19 = '" + PICP19.Text + "', pic20 = '" + PICP20.Text + "' WHERE pos_id = '" + comboBox1.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                // Refresh the DataGrid to show updated changes
                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

                MessageBox.Show("Record updated successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error during update. Please check database connection.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // DELETE Button Logic
            try
            {
                // 1. Delete from Price Table
                posdb_connect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_id = '" + comboBox1.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                // 2. Delete from Picture Table
                posdb_connect.pos_sql = "DELETE FROM pos_picTbl WHERE pos_id = '" + comboBox1.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                // 3. Delete from Name Table
                posdb_connect.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_id = '" + comboBox1.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                // Refresh view and clear inputs
                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

                // Assuming you have a function to clear textboxes
                cleartextboxes();
                //
                MessageBox.Show("Record deleted successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error during deletion. Record may not exist or is currently in use.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp"; // filtering image display
                if (openFileDialog1.ShowDialog() == DialogResult.OK) // displaying the file dialogbox
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); // inserting selected image
                    string picpath = openFileDialog1.FileName; // storing the file location to a variable
                    PICP1.Text = picpath; // displaying the file location to the textbox
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox2.Image = Image.FromFile(openFileDialog1.FileName); PICP2.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox3.Image = Image.FromFile(openFileDialog1.FileName); PICP3.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox4.Image = Image.FromFile(openFileDialog1.FileName); PICP4.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox5.Image = Image.FromFile(openFileDialog1.FileName); PICP5.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox6.Image = Image.FromFile(openFileDialog1.FileName); PICP6.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox7.Image = Image.FromFile(openFileDialog1.FileName); PICP7.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox8.Image = Image.FromFile(openFileDialog1.FileName); PICP8.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox9.Image = Image.FromFile(openFileDialog1.FileName); PICP9.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox10.Image = Image.FromFile(openFileDialog1.FileName); PICP10.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox11.Image = Image.FromFile(openFileDialog1.FileName); PICP11.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox12.Image = Image.FromFile(openFileDialog1.FileName); PICP12.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox13.Image = Image.FromFile(openFileDialog1.FileName); PICP13.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox14.Image = Image.FromFile(openFileDialog1.FileName); PICP14.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox15.Image = Image.FromFile(openFileDialog1.FileName); PICP15.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox16.Image = Image.FromFile(openFileDialog1.FileName); PICP16.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox17.Image = Image.FromFile(openFileDialog1.FileName); PICP17.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox18.Image = Image.FromFile(openFileDialog1.FileName); PICP18.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox19.Image = Image.FromFile(openFileDialog1.FileName); PICP19.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            try { openFileDialog1.ShowDialog(); pictureBox20.Image = Image.FromFile(openFileDialog1.FileName); PICP20.Text = openFileDialog1.FileName; }
            catch { MessageBox.Show("No image selected!"); }
        }
    }
}


