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
    public partial class LocalEventsForm : Form
    {

        private static List<Events> addedEvents = new List<Events>();

        // Dictionary to store search history with the date of the search as key
        private SortedDictionary<DateTime, string> searchHistory;

        // List to store events added by the user
        private List<Events> eventSearch;

        public LocalEventsForm()
        {
            InitializeComponent();
            searchHistory = new SortedDictionary<DateTime, string>();
            eventSearch = new List<Events>();
        }

        
        // Event handler for add event button 
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddEventsForm addEventsForm = new AddEventsForm();
            addEventsForm.ShowDialog(); 
            this.Close();
        }

        // Method to add the new event from add event form to the events list
        private void AddEvent(Events newEvent)
        {
            eventSearch.Add(newEvent); 
            MessageBox.Show
                ($"Event '" +
                $"{newEvent.Name}' " +
                $"has been added to the system"); 
        } 
        
        // Search and recommended search feautures
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            List<string> recommendations = RecommendEvents(query);

            lbRecommendations.Items.Clear();
            foreach (var recommendation in recommendations)
            {
                lbRecommendations.Items.Add(recommendation);
            }
        }

        private List<string> RecommendEvents(string query)
        {
            return eventSearch
                .Where(e => e.Name.ToLower().Contains(query) 
                         || e.Category.ToLower().Contains(query))
                .Select(e => $"{e.Name} - {e.Category} " +
                             $"({e.Date.ToShortDateString()})")
                .ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            DateTime searchDate = DateTime.Now;

            searchHistory.Add(searchDate, query);

            lbSearchHistory.Items.Clear();
            foreach (var entry in searchHistory)
            {
                lbSearchHistory.Items.Add($"{entry.Key}: {entry.Value}");
            }

            txtSearch.Clear();
        }

        // Clears search history on close
        private void LocalEventsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            searchHistory.Clear();
        }

        // Opens the Add Events Form so that user may record an event on the application 


        // Event handler to open the announcements form
        private void btnViewAnnouncements_Click(object sender, EventArgs e)
        {         

            AnnouncementsForm announcementsForm = new AnnouncementsForm();
            announcementsForm.ShowDialog();
            this.Close();
        }



        // Event handler to open the view events form
        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            ViewEventsForm viewEventsForm = new ViewEventsForm();
            viewEventsForm.ShowDialog();
            this.Close();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Return to main menu
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) // fixed the exit button that previously did not work
        {
            // Closes the application
            Application.Exit();
        }

        private void LocalEventsForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {

        }

        private void btnEvent_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblRecommedations_Click(object sender, EventArgs e)
        {

        }
    }
}
