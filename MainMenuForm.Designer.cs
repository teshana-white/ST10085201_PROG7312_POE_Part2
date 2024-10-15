using System;

namespace ST10085201_PROG7312_POE_Part1
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
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
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Location = new System.Drawing.Point(135, 35);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(169, 50);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click_1);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Location = new System.Drawing.Point(135, 113);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(169, 50);
            this.btnLocalEvents.TabIndex = 1;
            this.btnLocalEvents.Text = "Local Events";
            this.btnLocalEvents.UseVisualStyleBackColor = true;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click_1);
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.Location = new System.Drawing.Point(135, 190);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(169, 50);
            this.btnServiceStatus.TabIndex = 2;
            this.btnServiceStatus.Text = "Service Status";
            this.btnServiceStatus.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(135, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load_1);
            this.ResumeLayout(false);

        }
        #endregion
    }
}