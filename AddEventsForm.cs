using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10085201_PROG7312_POE_Part1
{
    public partial class AddEventsForm : Form
    {
        // Generic list to store events reported by the user
        public static List<Events> addedEvents = new List<Events>();

        public AddEventsForm()
        {
            InitializeComponent();
            
            rbYes.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbNo.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Event handler for the radio buttons
            if (rbYes.Checked)
            {
                lblAnnouncement.Text = "Your event will appear in announcements";
            }
            else if (rbNo.Checked)
            {
                lblAnnouncement.Text = "Your event will not appear in announcements";
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Capture the details entered by the user
            string eventName = txtEventName.Text;
            string category = cmbCategory.SelectedItem?.ToString();  // Safely handle selected item
            DateTime eventDate = dtpEvents.Value;
            string description = rtbEventDescription.Text;
            bool showInAnnouncements = rbYes.Checked;

            // Check if the required fields are filled
            if (string.IsNullOrEmpty(eventName) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill in all required fields (Event Name and Category).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Events object and add it to the list
            Events newEvent = new Events(eventName, category,eventDate, description, showInAnnouncements)
            {
                Name = eventName,
                Category = category,
                Date = eventDate,
                Description = description,
                Announcements = showInAnnouncements
            };

            addedEvents.Add(newEvent);  // Add the event to the list

            MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the form after submission
            ClearForm();
        }


        // Method to clear form after pressing submit
        private void ClearForm()
        {
            txtEventName.Clear();
            cmbCategory.SelectedIndex = -1;
            dtpEvents.Value = DateTime.Now;
            rtbEventDescription.Clear();
            rbYes.Checked = false;
            rbNo.Checked = false;
        }

        
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            // Return to main menu
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Close();
        }

        private void rtbEventDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAnnouncement_Click(object sender, EventArgs e)
        {

        }

    }
}
