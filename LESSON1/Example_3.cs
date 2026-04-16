using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson_2_Activity
{
    public partial class Example_3 : Form
    {
        //Declare variables to store the total amount and quantity
        private double total_amount = 0;
        private int total_qty = 0;

        public Example_3()
        {
            InitializeComponent();
        }

        private void Example_3_Load(object sender, EventArgs e)
        {
            //Disable the textboxes to prevent user input
            PriceTxtbox.Enabled = false;
            DiscountedTxtbox.Enabled = false;
            ChangeTxtbox.Enabled = false;
            TotalBillsTxtbox.Enabled = false;
            DiscountTxtbox.Enabled = false;
            TotalQtyTxtbox.Enabled = false;

            //Inserting image to picturebox
            //Burger1IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image1.jpg");
            //Burger2IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image2.jpg");
            //Burger3IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image3.jpg");
            //Burger4IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image4.jpg");
            //Burger5IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image5.jpg");
            //Burger6IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image6.jpg");
            //Burger7IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image7.jpg");
            //Burger8IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image8.jpg");
            //Burger9IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image9.jpg");
           // Burger10IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image10.jpg");
           // Burger11IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image11.jpg");
            //Burger12IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image12.jpg");
            //Burger13IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image13.jpg");
           // Burger14IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image14.jpg");
           // Burger15IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image15.jpg");
           // Burger16IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image16.jpg");
           // Burger17IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image17.jpg");
           // Burger18IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image18.jpg");
           // Burger19IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image19.jpg");
           //Burger20IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Image20.jpg");

            //disable the checkboxes to prevent user input
            A_BucketfriesBox.Enabled = false;
            A_ChickenBox.Enabled = false;
            A_DeluxeburgerBox.Enabled = false;
            A_Icedteabox.Enabled = false;
            A_SidedishBox.Enabled = false;
            B_chickenBox.Enabled = false;
            B_HalohaloBox.Enabled = false;
            B_LargefriesBox.Enabled = false;
            B_SDeluxeburgerbox.Enabled = false;
            B_SpaghettiBox.Enabled = false;




        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code to uncheck all given checkboxes
            FoodBundleA_RB.Checked = false;
            FoodBundleB_RB.Checked= false;

            //code for inserting default image inside the picturebox
           // DisplayPicturebox.Image = System.Drawing.Image.FromFile("C:\\Users\\My Computer\\source\\repos\\Lesson_2_Activity\\Image Folder\\Default.jpg");
            A_BucketfriesBox.Checked = false;
            A_ChickenBox.Checked = false;
            A_DeluxeburgerBox.Checked = false;
            A_Icedteabox.Checked = false;
            A_SidedishBox.Checked = false;
            B_chickenBox.Checked = false;
            B_HalohaloBox.Checked = false;
            B_LargefriesBox.Checked = false;
            B_SDeluxeburgerbox.Checked = false;
            B_SpaghettiBox.Checked = false;

            //code for clearing the textboxes
            QtyTxtbox.Clear();
            PriceTxtbox.Clear();
            Burger1CB.Checked = false;
            Burger2CB.Checked = false;
            Burger3CB.Checked = false;
            Burger4CB.Checked = false;
            Burger5CB.Checked = false;
            Burger6CB.Checked = false;
            Burger7CB.Checked = false;
            Burger8CB.Checked = false;
            Burger9CB.Checked = false;
            Burger10CB.Checked = false;
            Burger11CB.Checked = false;
            Burger12CB.Checked = false;
            Burger13CB.Checked = false;
            Burger14CB.Checked = false;
            Burger15CB.Checked = false;
            Burger16CB.Checked = false;
            Burger17CB.Checked = false;
            Burger18CB.Checked = false;
            Burger19CB.Checked = false;
            Burger20CB.Checked = false;

            //remove all data inside the listbox
            DisplayListbox.Items.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code to remove selected data inside the listbox
            DisplayListbox.Items.RemoveAt(DisplayListbox.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          //Example_3_prntfrm print = new Example_3_prntfrm(DisplayListbox.Items);
           // print.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            //cash_given = Convert.ToDouble(CashGivenTxtbox.Text);
            //total_amountPaid = Convert.ToDouble(TotalBillsTxtbox.Text);
            //change = cash_given - total_amountPaid;
            // ChangeTxtbox.Text = change.ToString("n");
            //DisplayListbox.Items.Add("total Bills: " + " " + TotalBillsTxtbox.Text);
            //DisplayListbox.Items.Add("Cash Given: " + " " + CashGivenTxtbox.Text);
            //DisplayListbox.Items.Add("Change: " + " " + ChangeTxtbox.Text);
            // DisplayListbox.Items.Add("Total No. of Items:" + " " + TotalQtyTxtbox.Text);

            try
            {
                cash_given = Convert.ToDouble(CashGivenTxtbox.Text);
                total_amountPaid = Convert.ToDouble(TotalBillsTxtbox.Text);
                change = cash_given - total_amountPaid;
                ChangeTxtbox.Text = change.ToString("n");
                DisplayListbox.Items.Add("Total Bills: " + " " + TotalBillsTxtbox.Text);
                DisplayListbox.Items.Add("Cash Given: " + " " + CashGivenTxtbox.Text);
                DisplayListbox.Items.Add("Total No. of Items: " + " " + TotalQtyTxtbox.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Enter valid data in cash given textbox!");
                CashGivenTxtbox.Clear();
                CashGivenTxtbox.Focus();
            }

        }

        private void Burger1IMG_Click(object sender, EventArgs e)
        {
            
        }

        private void FoodBundleA_RB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
           
            

            // code for food bundle B not be selected
            FoodBundleB_RB.Checked = false;

            // inserting image to picturebox
            //DisplayPicturebox.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Food Bundle A.jpg");

            // codes to check the checkboxes when food bundle A is selected
            A_BucketfriesBox.Checked = true;
            A_ChickenBox.Checked = true;
            A_DeluxeburgerBox.Checked = true;
            A_Icedteabox.Checked = true;
            A_SidedishBox.Checked = true;

            //codes to uncheck the checkboxes when food bundle A is selected
            B_chickenBox.Checked = false;
            B_HalohaloBox.Checked = false;
            B_LargefriesBox.Checked = false;
            B_SDeluxeburgerbox.Checked = false;
            B_SpaghettiBox.Checked = false;

            //codes for displaying data inside the textboxes
            PriceTxtbox.Text = "1,000.00";
            DiscountTxtbox.Text = "200.00";
            price = Convert.ToDouble(PriceTxtbox.Text);

            //codes for inserting data inside the listbox
            DisplayListbox.Items.Add(FoodBundleA_RB.Text + " " + PriceTxtbox.Text);
            DisplayListbox.Items.Add("Discount amount: "+" " + DiscountTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();

        }

        private void DisplayPicturebox_Click(object sender, EventArgs e)
        {

        }

        private void FoodBundleB_RB_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            FoodBundleA_RB.Checked = false;
            DisplayPicturebox.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-21.C203-21\\source\\repos\\Lesson_2_Activity\\Assignment 1 and 2\\Image Folder\\Food Bundle B.jpg");
            A_BucketfriesBox.Checked = false;
            A_ChickenBox.Checked = false;
            A_DeluxeburgerBox.Checked = false;
            A_Icedteabox.Checked = false;
            A_SidedishBox.Checked = false;
            B_chickenBox.Checked = true;
            B_HalohaloBox.Checked = true;
            B_LargefriesBox.Checked = true;
            B_SDeluxeburgerbox.Checked = true;
            B_SpaghettiBox.Checked = true;
            PriceTxtbox.Text = "1,299.00";
            DiscountTxtbox.Text = "194.85";
            DisplayListbox.Items.Add(FoodBundleB_RB.Text);
        }

        private void QtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            double price, discounted_amount, discount_amount;
            //int qty;
            //price = Convert.ToDouble(PriceTxtbox.Text);
            //qty = Convert.ToInt32(QtyTxtbox.Text);
            //discount_amount = Convert.ToDouble(DiscountTxtbox.Text);
            // discounted_amount = (price * qty) - discount_amount;
            //total_qty += qty;
            //TotalQtyTxtbox.Text = total_qty.ToString();
            // total_amount += discounted_amount;
            //TotalBillsTxtbox.Text = total_amount.ToString("n");
            //DiscountedTxtbox.Text = discounted_amount.ToString("n");

            int qty;
            try
            {
                price = Convert.ToDouble(PriceTxtbox.Text);
                qty = Convert.ToInt32(QtyTxtbox.Text);
                discount_amount = Convert.ToDouble(DiscountTxtbox.Text);
                discounted_amount = (price * qty) - discount_amount;
                total_qty += qty;
                TotalQtyTxtbox.Text = total_qty.ToString();
                total_amount += discounted_amount;
                TotalBillsTxtbox.Text = total_amount.ToString("n");
                DiscountedTxtbox.Text = discounted_amount.ToString("n");
            }
            catch(Exception)
            {
                MessageBox.Show("Enter number of quantity ordered!");
                QtyTxtbox.Focus();
            }

        }

        private void Burger1CB_CheckedChanged(object sender, EventArgs e)
        {
            //code to declare a variable with specific data type
            double price;

            //code for putting text property value of the textbox
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "500.99";

            //code for converting string to numeric data type
            price = Convert.ToDouble(PriceTxtbox.Text);

            //code for inserting texxt property value of the checkbox to the listbox
            DisplayListbox.Items.Add(Burger1CB.Text + " " + PriceTxtbox.Text);

            //code for putting text property value of the textbox
            QtyTxtbox.Text = "0";

            //code for putting the focus on the textbox
            QtyTxtbox.Focus();
        }

        private void Burger2CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "550.00";   
            price = Convert.ToDouble(PriceTxtbox.Text);          
            DisplayListbox.Items.Add(Burger2CB.Text + " " + PriceTxtbox.Text);          
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger3CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "600.99";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger3CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger4CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "700.50";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger4CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger5CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "500.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger5CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger6CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "750.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger6CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger7CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "700.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger7CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger8CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "850.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger8CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger9CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "450.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger9CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger10CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "650.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger10CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger11CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger11CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger12CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger12CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger13CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger13CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger14CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger14CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger15CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger15CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger16CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger16CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger17CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger17CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger18CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger18CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger19CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger19CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger20CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Burger20CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }
    }
}
