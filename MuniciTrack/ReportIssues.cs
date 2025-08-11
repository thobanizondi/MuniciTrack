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
    public partial class ReportIssues : Form
    {
        // This form allows users to report issues to the municipality  
        private IssueManager issueManager = new IssueManager();
        private string attachmentFilePath = string.Empty;
        public ReportIssues()
        {
            InitializeComponent();

        }


        private bool ValidateForm()
        {
            // Validate the form inputs 

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter your full name.");
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location.");
                txtLocation.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(richTxtDescription.Text))
            {
                MessageBox.Show("Please enter a description of the issue.");
                richTxtDescription.Focus();
                return false;
            }

            if (!IsCategorySelected())
            {
                MessageBox.Show("Please select a category.");
                return false;
            }

            if (!IsStatusSelected())
            {
                MessageBox.Show("Please select the status of the issue.");
                return false;
            }
            return true;
        }


        private bool IsCategorySelected()
        {
            // Check if any category radio button is selected
            return rbInfrastructure.Checked || rbElectricity.Checked || rbWater.Checked ||
                rbWaste.Checked || rbSanitation.Checked || rbtOther.Checked;
        }

        private bool IsStatusSelected()
        {
            // Check if any status radio button is selected
            return rdbOpen.Checked || rdbInProgress.Checked || rdbClosed.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private string GetSelectedCategory()
        {
            // Return the selected category based on the checked radio button
            if (rbInfrastructure.Checked) return "Infrastructure";
            if (rbElectricity.Checked) return "Electricity";
            if (rbWater.Checked) return "Water";
            if (rbWaste.Checked) return "Waste";
            if (rbSanitation.Checked) return "Sanitation";
            if (rbtOther.Checked) return "Other";
            return "Unspecified";
        }
        private string GetSelectedStatus()
        {
            // Return the selected status based on the checked radio button
            if (rdbOpen.Checked) return "Open";
            if (rdbInProgress.Checked) return "In Progress";
            if (rdbClosed.Checked) return "Closed";
            return "Open"; // Default fallback
        }

        private void btnUploadAttachment_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an attachment
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an attachment";
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachmentFilePath = openFileDialog.FileName;
                MessageBox.Show("Attachment uploaded successfully!");
            }
        }

        private void ReportIssues_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            // Validate the form inputs before proceeding
            if (!ValidateForm())
                return;

            // Create a new issue object and populate it with form data 
            Issue newIssue = new Issue
            {
                fullName = txtFullName.Text,
                Location = txtLocation.Text,
                Category = GetSelectedCategory(),
                Description = richTxtDescription.Text,
                AttachmentPath = attachmentFilePath,
                Status = GetSelectedStatus()
            };

            // Add the new issue to the issue manager and display a success message

            issueManager.AddIssue(newIssue);
            MessageBox.Show($"Issue #{newIssue.Id} saved successfully!");

            ReportIssueListForm listForm = new ReportIssueListForm();
            listForm.LoadIssues(issueManager.GetAllIssues());
            listForm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Close the current form and return to the main form   
            Main main = new Main();
            main.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}


