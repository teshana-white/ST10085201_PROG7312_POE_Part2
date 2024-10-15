namespace ST10085201_PROG7312_POE_Part1
{
    partial class ViewEventsForm
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
            this.lbAllEvents = new System.Windows.Forms.ListBox();
            this.btnBacktoMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAllEvents
            // 
            this.lbAllEvents.FormattingEnabled = true;
            this.lbAllEvents.Location = new System.Drawing.Point(29, 12);
            this.lbAllEvents.Name = "lbAllEvents";
            this.lbAllEvents.Size = new System.Drawing.Size(390, 264);
            this.lbAllEvents.TabIndex = 0;
            // 
            // btnBacktoMenu
            // 
            this.btnBacktoMenu.Location = new System.Drawing.Point(112, 305);
            this.btnBacktoMenu.Name = "btnBacktoMenu";
            this.btnBacktoMenu.Size = new System.Drawing.Size(100, 23);
            this.btnBacktoMenu.TabIndex = 7;
            this.btnBacktoMenu.Text = "Back to Main";
            this.btnBacktoMenu.UseVisualStyleBackColor = true;
            this.btnBacktoMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(218, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ViewEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBacktoMenu);
            this.Controls.Add(this.lbAllEvents);
            this.Name = "ViewEventsForm";
            this.Text = "Events";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllEvents;
        private System.Windows.Forms.Button btnBacktoMenu;
        private System.Windows.Forms.Button btnExit;
    }
}