﻿using System;
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
    public partial class AnnouncementsForm : Form
    {
        private static List<Events> addedEvents = new List<Events>();

        public AnnouncementsForm ()
        {
            InitializeComponent();
            this.Load += new EventHandler(ViewEventsForm_Load);
        }

        private void ViewEventsForm_Load(object sender, EventArgs e)
        {
            ViewAnnouncements();
        }

        private void ViewAnnouncements()
        {
            if (AddEventsForm.addedEvents.Count == 0)
            {
                lbAnnouncements.Items.Add("No events have been added yet.");
            }
            else
            {
                // Loop through the events and add them to the ListBox
                foreach (var ev in AddEventsForm.addedEvents)
                {
                    lbAnnouncements.Items.Add($"Name: {ev.Name}, Category: {ev.Category}, Date: {ev.Date.ToShortDateString()}");
                }
            }
            
        }


        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Return to main menu
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) // fixed the exit button that previously did not work
        {
            // Closes the application
            Application.Exit();
        }
    }
}
