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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity4_PrintFrm));
            printDisplayListBox = new ListBox();
            SuspendLayout();
            // 
            // printDisplayListBox
            // 
            resources.ApplyResources(printDisplayListBox, "printDisplayListBox");
            printDisplayListBox.FormattingEnabled = true;
            printDisplayListBox.Name = "printDisplayListBox";
            printDisplayListBox.SelectedIndexChanged += printDisplayListbox_SelectedIndexChanged;
            // 
            // Activity4_PrintFrm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(printDisplayListBox);
            Name = "Activity4_PrintFrm";
            Load += Activity4_PrintFrm_Load;
            ResumeLayout(false);
        }

        #endregion

        public ListBox printDisplayListBox;
    }
}