namespace ST10085201_PROG7312_POE_Part1
{
    partial class AddEventsForm
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
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpEvents = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.rtbEventDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(12, 16);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(69, 13);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Event Name:";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(151, 16);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(272, 20);
            this.txtEventName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 47);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Event Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Cultural",
            "Professional",
            "Sports",
            "Political",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(151, 44);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(272, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // dtpEvents
            // 
            this.dtpEvents.Location = new System.Drawing.Point(151, 76);
            this.dtpEvents.Name = "dtpEvents";
            this.dtpEvents.Size = new System.Drawing.Size(272, 20);
            this.dtpEvents.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 82);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Event Date:";
            // 
            // rtbEventDescription
            // 
            this.rtbEventDescription.Location = new System.Drawing.Point(151, 109);
            this.rtbEventDescription.Name = "rtbEventDescription";
            this.rtbEventDescription.Size = new System.Drawing.Size(272, 150);
            this.rtbEventDescription.TabIndex = 6;
            this.rtbEventDescription.Text = "";
            this.rtbEventDescription.TextChanged += new System.EventHandler(this.rtbEventDescription_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Event Description:";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(186, 309);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(192, 23);
            this.btnBackToMain.TabIndex = 8;
            this.btnBackToMain.Text = "Back to Events and Announcements";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(80, 309);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = true;
            this.lblAnnouncement.Location = new System.Drawing.Point(12, 270);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(133, 13);
            this.lblAnnouncement.TabIndex = 11;
            this.lblAnnouncement.Text = "Event Announcemenment:";
            this.lblAnnouncement.Click += new System.EventHandler(this.lblAnnouncement_Click);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(335, 270);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 12;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(384, 270);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 13;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // AddEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.lblAnnouncement);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rtbEventDescription);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpEvents);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.lblEventName);
            this.Name = "AddEventsForm";
            this.Text = "Add Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpEvents;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RichTextBox rtbEventDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAnnouncement;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
    }
}