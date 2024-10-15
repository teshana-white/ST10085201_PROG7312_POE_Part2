namespace ST10085201_PROG7312_POE_Part1
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnViewEvents;
        private System.Windows.Forms.Button btnViewAnnouncement;
        private System.Windows.Forms.Button btnBacktoMenu;
        private System.Windows.Forms.Button btnExit;

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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnViewEvents = new System.Windows.Forms.Button();
            this.btnViewAnnouncement = new System.Windows.Forms.Button();
            this.btnBacktoMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbRecommendations = new System.Windows.Forms.ListBox();
            this.lbSearchHistory = new System.Windows.Forms.ListBox();
            this.lblRecommedations = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(25, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search for Events";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(25, 49);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(100, 23);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnViewEvents
            // 
            this.btnViewEvents.Location = new System.Drawing.Point(170, 49);
            this.btnViewEvents.Name = "btnViewEvents";
            this.btnViewEvents.Size = new System.Drawing.Size(100, 23);
            this.btnViewEvents.TabIndex = 3;
            this.btnViewEvents.Text = "View All Events";
            this.btnViewEvents.UseVisualStyleBackColor = true;
            this.btnViewEvents.Click += new System.EventHandler(this.btnViewEvents_Click);
            // 
            // btnViewAnnouncement
            // 
            this.btnViewAnnouncement.Location = new System.Drawing.Point(276, 49);
            this.btnViewAnnouncement.Name = "btnViewAnnouncement";
            this.btnViewAnnouncement.Size = new System.Drawing.Size(150, 23);
            this.btnViewAnnouncement.TabIndex = 4;
            this.btnViewAnnouncement.Text = "View All Announcements";
            this.btnViewAnnouncement.UseVisualStyleBackColor = true;
            this.btnViewAnnouncement.Click += new System.EventHandler(this.btnViewAnnouncements_Click);
            // 
            // btnBacktoMenu
            // 
            this.btnBacktoMenu.Location = new System.Drawing.Point(113, 316);
            this.btnBacktoMenu.Name = "btnBacktoMenu";
            this.btnBacktoMenu.Size = new System.Drawing.Size(100, 23);
            this.btnBacktoMenu.TabIndex = 5;
            this.btnBacktoMenu.Text = "Back to Main";
            this.btnBacktoMenu.UseVisualStyleBackColor = true;
            this.btnBacktoMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(219, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbRecommendations
            // 
            this.lbRecommendations.FormattingEnabled = true;
            this.lbRecommendations.Location = new System.Drawing.Point(25, 104);
            this.lbRecommendations.Name = "lbRecommendations";
            this.lbRecommendations.Size = new System.Drawing.Size(401, 82);
            this.lbRecommendations.TabIndex = 8;
            // 
            // lbSearchHistory
            // 
            this.lbSearchHistory.FormattingEnabled = true;
            this.lbSearchHistory.Location = new System.Drawing.Point(25, 217);
            this.lbSearchHistory.Name = "lbSearchHistory";
            this.lbSearchHistory.Size = new System.Drawing.Size(401, 82);
            this.lbSearchHistory.TabIndex = 9;
            // 
            // lblRecommedations
            // 
            this.lblRecommedations.AutoSize = true;
            this.lblRecommedations.Location = new System.Drawing.Point(25, 85);
            this.lblRecommedations.Name = "lblRecommedations";
            this.lblRecommedations.Size = new System.Drawing.Size(135, 13);
            this.lblRecommedations.TabIndex = 10;
            this.lblRecommedations.Text = "Search Recommendations:";
            this.lblRecommedations.Click += new System.EventHandler(this.lblRecommedations_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(25, 201);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(79, 13);
            this.lblHistory.TabIndex = 11;
            this.lblHistory.Text = "Search History:";
            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lblRecommedations);
            this.Controls.Add(this.lbSearchHistory);
            this.Controls.Add(this.lbRecommendations);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBacktoMenu);
            this.Controls.Add(this.btnViewAnnouncement);
            this.Controls.Add(this.btnViewEvents);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.txtSearch);
            this.Name = "LocalEventsForm";
            this.Text = "Local Events & Announcements";
            this.Load += new System.EventHandler(this.LocalEventsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbRecommendations;
        private System.Windows.Forms.ListBox lbSearchHistory;
        private System.Windows.Forms.Label lblRecommedations;
        private System.Windows.Forms.Label lblHistory;
    }
}