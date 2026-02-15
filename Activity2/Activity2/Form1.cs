namespace Activity2
{
    public partial class Form1 : Form
    {
        private double total_amount = 0;
        private int qty_total = 0;
        private double discount_totalgiven = 0;
        private double discounted_total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changetxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            itemnametextbox.Enabled = false;
            qty_totaltextbox.Enabled = false;
            Discountedtextbox.Enabled = false;
            discount_totaltextbox.Enabled = false;
            discounted_totaltextbox.Enabled = false;

            //pictureBox20.Image = Image.FromFile("C:\\Users\\C203-02.C203-02\\Downloads\\c1.png");
            //pictureBox19.Image = Image.FromFile("C:\\Users\\C203-02.C203-02\\Downloads\\c2.png");
            //pictureBox18.Image = Image.FromFile("C:\\Users\\C203-02.C203-02\\Downloads\\c3.png");
            //pictureBox17.Image = Image.FromFile("C:\\Users\\C203-02.C203-02\\Downloads\\c4.png");
            //pictureBox16.Image = Image.FromFile("C:\\Users\\C203-02.C203-02\\Downloads\\c5.png");

            label15.Text = "ADOBO";
            label16.Text = "BANGUS";
            label17.Text = "BULALO";
            label18.Text = "GULAY";
            label19.Text = "BILOG-BILOG";
            label20.Text = "SINIGANGG";
            label21.Text = "CORN SOUP";
            label22.Text = "TINOLA";
            label23.Text = "L-SARIWA";
            label24.Text = "PALABOKK";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void changetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;
            discounttextbox.Text = discount_amt.ToString("n");
            Discountedtextbox.Text = discounted_amt.ToString("n");
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;
            discounttextbox.Text = discount_amt.ToString("n");
            Discountedtextbox.Text = discounted_amt.ToString("n");
            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;
            discounttextbox.Text = discount_amt.ToString("n");
            Discountedtextbox.Text = discounted_amt.ToString("n");
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;
            discounttextbox.Text = discount_amt.ToString("n");
            Discountedtextbox.Text = discounted_amt.ToString("n");
            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            regularRbtn.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discounttextbox.Text);
            discounted_amt = Convert.ToDouble(Discountedtextbox.Text);
            cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;
            qty_totaltextbox.Text = qty_total.ToString();
            discount_totaltextbox.Text = discount_totalgiven.ToString("n");
            discounted_totaltextbox.Text = discounted_total.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashrenderedtxtbox.Text = cash_rendered.ToString("n");




        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            itemnametextbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discounttextbox.Clear();
            Discountedtextbox.Clear();
            changetxtbox.Clear();
            cashrenderedtxtbox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label15.Text";
            pricetextbox.Text = "89.50";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label16.Text";
            pricetextbox.Text = "101.50";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label17.Text";
            pricetextbox.Text = "100.50";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label18.Text";
            pricetextbox.Text = "90.50";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label19.Text";
            pricetextbox.Text = "101.50";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label20.Text";
            pricetextbox.Text = "90.50";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label21.Text";
            pricetextbox.Text = "101.50";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label22.Text";
            pricetextbox.Text = "188.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label23.Text";
            pricetextbox.Text = "123.50";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "label24.Text";
            pricetextbox.Text = "680.50";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "PATATIM";
            pricetextbox.Text = "199.50";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "CALDERETA";
            pricetextbox.Text = "99.50";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "SISIG";
            pricetextbox.Text = "190.50";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "PANCIT BIHON";
            pricetextbox.Text = "121.50";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "TORTA";
            pricetextbox.Text = "599.50";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "KARE-KARE";
            pricetextbox.Text = "91.50";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "SINIGANG";
            pricetextbox.Text = "81.50";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "PIGETI";
            pricetextbox.Text = "71.50";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "GINISA";
            pricetextbox.Text = "211.50";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = "TAHONG";
            pricetextbox.Text = "576.00";
        }
    }
}
