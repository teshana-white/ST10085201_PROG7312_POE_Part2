namespace ST10085201_PROG7312_POE_Part1
{
    partial class AnnouncementsForm
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
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.btnBacktoMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.Location = new System.Drawing.Point(29, 12);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(390, 264);
            this.lbAnnouncements.TabIndex = 0;
            // 
            // btnBacktoMenu
            // 
            this.btnBacktoMenu.Location = new System.Drawing.Point(111, 302);
            this.btnBacktoMenu.Name = "btnBacktoMenu";
            this.btnBacktoMenu.Size = new System.Drawing.Size(100, 23);
            this.btnBacktoMenu.TabIndex = 6;
            this.btnBacktoMenu.Text = "Back to Main";
            this.btnBacktoMenu.UseVisualStyleBackColor = true;
            this.btnBacktoMenu.Click += new System.EventHandler(this.btnBackToMenu_Click); 
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBacktoMenu);
            this.Controls.Add(this.lbAnnouncements);
            this.Name = "AnnouncementsForm";
            this.Text = "Announcements";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.Button btnBacktoMenu;
        private System.Windows.Forms.Button btnExit;
    }
}