namespace MuniciTrack
{
    partial class ReportIssueListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewIssues = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIssues).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewIssues
            // 
            dataGridViewIssues.AllowUserToAddRows = false;
            dataGridViewIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIssues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIssues.Dock = DockStyle.Fill;
            dataGridViewIssues.Location = new Point(0, 0);
            dataGridViewIssues.Name = "dataGridViewIssues";
            dataGridViewIssues.ReadOnly = true;
            dataGridViewIssues.RowHeadersWidth = 62;
            dataGridViewIssues.Size = new Size(800, 604);
            dataGridViewIssues.TabIndex = 0;
            dataGridViewIssues.CellContentClick += dataGridViewIssues_CellContentClick;
            // 
            // ReportIssueListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 604);
            Controls.Add(dataGridViewIssues);
            Name = "ReportIssueListForm";
            Text = "ReportIssueListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewIssues).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewIssues;
    }
}