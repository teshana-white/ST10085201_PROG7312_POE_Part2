namespace ST10085201_PROG7312_POE_Part1
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.listBoxAttachments = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnViewIssues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location:";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(11, 53);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 87);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(89, 17);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(200, 20);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Water",
            "Electricity",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(89, 50);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 21);
            this.cmbCategory.TabIndex = 1;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(89, 87);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(300, 100);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.Location = new System.Drawing.Point(14, 230);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(69, 13);
            this.lblAttachments.TabIndex = 10;
            this.lblAttachments.Text = "Attachments:";
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Location = new System.Drawing.Point(89, 225);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(100, 23);
            this.btnAttachFile.TabIndex = 3;
            this.btnAttachFile.Text = "Attach File";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // listBoxAttachments
            // 
            this.listBoxAttachments.FormattingEnabled = true;
            this.listBoxAttachments.Location = new System.Drawing.Point(209, 225);
            this.listBoxAttachments.Name = "listBoxAttachments";
            this.listBoxAttachments.Size = new System.Drawing.Size(180, 69);
            this.listBoxAttachments.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(58, 310);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(164, 310);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(100, 23);
            this.btnBackToMenu.TabIndex = 6;
            this.btnBackToMenu.Text = "Back to Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnViewIssues
            // 
            this.btnViewIssues.Location = new System.Drawing.Point(270, 310);
            this.btnViewIssues.Name = "btnViewIssues";
            this.btnViewIssues.Size = new System.Drawing.Size(100, 23);
            this.btnViewIssues.TabIndex = 7;
            this.btnViewIssues.Text = "View Issues";
            this.btnViewIssues.UseVisualStyleBackColor = true;
            this.btnViewIssues.Click += new System.EventHandler(this.btnViewIssues_Click);
            // 
            // ReportIssuesForm
            // 
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAttachments);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.listBoxAttachments);
            this.Controls.Add(this.btnAttachFile);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnViewIssues);
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.ListBox listBoxAttachments;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnViewIssues;
    }
}