namespace LESSON1
{
    partial class Activity4_PrintFrm
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
            printDisplayListbox = new ListBox();
            SuspendLayout();
            // 
            // printDisplayListbox
            // 
            printDisplayListbox.FormattingEnabled = true;
            printDisplayListbox.ItemHeight = 15;
            printDisplayListbox.Location = new Point(14, 16);
            printDisplayListbox.Name = "printDisplayListbox";
            printDisplayListbox.Size = new Size(484, 499);
            printDisplayListbox.TabIndex = 0;
            // 
            // Activity4_PrintFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 549);
            Controls.Add(printDisplayListbox);
            Name = "Activity4_PrintFrm";
            Text = "Activity4_PrintFrm";
            Load += Activity4_PrintFrm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox printDisplayListbox;
    }
}