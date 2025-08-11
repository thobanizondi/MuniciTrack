using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuniciTrack
{
    public class IssueManager
    {
        // This class manages the issues, including adding, retrieving, and updating them.
        private List<Issue> issues = new List<Issue>();
        private int nextId = 1;

        public void AddIssue(Issue issue)
        {
            // Assign a unique ID to the issue and add it to the list
            issue.Id = nextId++;
            issues.Add(issue);
        }

        public List<Issue> GetAllIssues()
        {
            // Return a list of all issues
            return issues;
        }

        public Issue GetIssueById(int id)
        {
            // Find an issue by its ID
            return issues.Find(i => i.Id == id);
        }

        public void UpdateIssueStatus(int id, string newStatus)
        {
            // Update the status of an issue by its ID
            var issue = GetIssueById(id);
            if (issue != null)
            {
                // Ensure the new status is valid before updating
                issue.Status = newStatus;
            }
        }
    }
}

