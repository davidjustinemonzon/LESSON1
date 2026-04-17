namespace LESSON1
{
    partial class LESSON7_EX6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NumTimesDisplayTxtbox = new TextBox();
            ShowBtn = new Button();
            label2 = new Label();
            CountryCombobox = new ComboBox();
            displayListbox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 39);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "ENTER A NUMBER:";
            // 
            // NumTimesDisplayTxtbox
            // 
            NumTimesDisplayTxtbox.Location = new Point(171, 35);
            NumTimesDisplayTxtbox.Name = "NumTimesDisplayTxtbox";
            NumTimesDisplayTxtbox.Size = new Size(159, 23);
            NumTimesDisplayTxtbox.TabIndex = 1;
            // 
            // ShowBtn
            // 
            ShowBtn.Location = new Point(336, 35);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(88, 25);
            ShowBtn.TabIndex = 2;
            ShowBtn.Text = "SHOW";
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 70);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 3;
            label2.Text = "SELECT A COUNTRY TO DISPLAY IN LISTBOX";
            // 
            // CountryCombobox
            // 
            CountryCombobox.FormattingEnabled = true;
            CountryCombobox.Location = new Point(58, 89);
            CountryCombobox.Name = "CountryCombobox";
            CountryCombobox.Size = new Size(366, 23);
            CountryCombobox.TabIndex = 4;
            // 
            // displayListbox
            // 
            displayListbox.FormattingEnabled = true;
            displayListbox.ItemHeight = 15;
            displayListbox.Location = new Point(59, 126);
            displayListbox.Name = "displayListbox";
            displayListbox.Size = new Size(366, 214);
            displayListbox.TabIndex = 5;
            // 
            // LESSON7_EX6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 436);
            Controls.Add(displayListbox);
            Controls.Add(CountryCombobox);
            Controls.Add(label2);
            Controls.Add(ShowBtn);
            Controls.Add(NumTimesDisplayTxtbox);
            Controls.Add(label1);
            Name = "LESSON7_EX6";
            Text = "la";
            Load += LESSON7_EX6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NumTimesDisplayTxtbox;
        private TextBox textBox1;
        private Button ShowBtn;
        private Label label2;
        private ComboBox CountryCombobox;
        private ListBox displayListbox;
    }
}