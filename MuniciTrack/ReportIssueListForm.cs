using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuniciTrack
{
    public partial class ReportIssueListForm : Form
    {
        public ReportIssueListForm()
        {
            InitializeComponent();

            // Create a bottom panel for the button
            Panel bottomPanel = new Panel();
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Height = 50;
            bottomPanel.Padding = new Padding(10);

            // Create the Back button
            Button btnBack = new Button();
            btnBack.Text = "Back to Report Issue";
            btnBack.Dock = DockStyle.Right;
            btnBack.Click += BtnBack_Click;

            bottomPanel.Controls.Add(btnBack);
            this.Controls.Add(bottomPanel);

            // Configure the DataGridView
            dataGridViewIssues.Dock = DockStyle.Fill;
            dataGridViewIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIssues.ReadOnly = true;
            dataGridViewIssues.AllowUserToAddRows = false;
            dataGridViewIssues.AllowUserToDeleteRows = false;
        }

                private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
            ReportIssues reportIssuesForm = new ReportIssues(); // Create a new instance of ReportIssues
            reportIssuesForm.Show(); // Show the ReportIssues form
        }   




        public void LoadIssues(List<Issue> issues)
        {
            // Clear any existing data in the DataGridView
            dataGridViewIssues.DataSource = null;
            dataGridViewIssues.DataSource = issues;

            CustomizeGridHeaders();
        }

        private void CustomizeGridHeaders()
        {
            // Customize the headers of the DataGridView columns    
            dataGridViewIssues.Columns["Id"].HeaderText = "Issue ID";
            dataGridViewIssues.Columns["fullName"].HeaderText = "Full Name";
            dataGridViewIssues.Columns["Location"].HeaderText = "Location";
            dataGridViewIssues.Columns["Category"].HeaderText = "Category";
            dataGridViewIssues.Columns["Description"].HeaderText = "Description";
            dataGridViewIssues.Columns["AttachmentPath"].HeaderText = "Attachment";
            dataGridViewIssues.Columns["Status"].HeaderText = "Status";
        }

        private void dataGridViewIssues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
